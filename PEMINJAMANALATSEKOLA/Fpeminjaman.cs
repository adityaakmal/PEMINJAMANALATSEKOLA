using System;
using System.Data;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class Fpeminjaman : Form
    {
        public Fpeminjaman()
        {
            InitializeComponent();
        }

        private void Fpeminjaman_Load(object sender, EventArgs e)
        {
            tampildata();
            muatNamaAlat();
            muatUser();
            txtKodePeminjaman.Text = GenerateKodePeminjaman();
            txtKodePeminjaman.ReadOnly = true;
        }

        private string GenerateKodePeminjaman()
        {
            DB.crud("SELECT kode_peminjaman FROM peminjaman ORDER BY kode_peminjaman DESC LIMIT 1");
            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                string kodeTerakhir = DB.ds.Tables[0].Rows[0]["kode_peminjaman"].ToString();
                int angka = int.Parse(kodeTerakhir.Substring(3)) + 1;
                return "PJM" + angka.ToString("D3");
            }
            return "PJM001";
        }

        private void bersihkan()
        {
            txtKodePeminjaman.Text = GenerateKodePeminjaman();
            txtKodePeminjaman.ReadOnly = true;
            cmbuser.SelectedIndex = -1;
            cmbalat.SelectedIndex = -1;
            txtJumlah.Clear();
            dtpTanggalPinjam.Value = DateTime.Now;
            dtpTanggalKembali.Value = DateTime.Now;
            txtKeterangan.Clear();
        }

        private void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT p.kode_peminjaman, u.nama AS nama_peminjam, a.nama_alat, " +
                    "p.jumlah, p.tgl_pinjam, p.tgl_kembali_rencana, p.status, p.keterangan " +
                    "FROM peminjaman p " +
                    "LEFT JOIN users u ON p.id_user = u.id_user " +
                    "LEFT JOIN alat a ON p.kode_alat = a.kode_alat");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(
                    "" + Row["kode_peminjaman"],
                    "" + Row["nama_peminjam"],
                    "" + Row["nama_alat"],
                    "" + Row["jumlah"],
                    "" + Row["keterangan"],
                    "" + Row["tgl_pinjam"],
                    "" + Row["tgl_kembali_rencana"],
                    "" + Row["status"]
                );
            }
        }

        private void muatUser()
        {
            DB.crud("SELECT id_user, nama FROM users");
            cmbuser.DataSource = DB.ds.Tables[0].Copy();
            cmbuser.DisplayMember = "nama";
            cmbuser.ValueMember = "id_user";
            cmbuser.SelectedIndex = -1;
            cmbuser.Text = "";
        }

        private void muatNamaAlat()
        {
            DB.crud("SELECT kode_alat, nama_alat FROM alat");
            cmbalat.DataSource = DB.ds.Tables[0].Copy();
            cmbalat.DisplayMember = "nama_alat";
            cmbalat.ValueMember = "kode_alat";
            cmbalat.SelectedIndex = -1;
            cmbalat.Text = "";
        }

        private bool validasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtKodePeminjaman.Text))
            {
                MessageBox.Show("Kode peminjaman tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbuser.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih nama peminjam terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Fixed: was checking cmbuser again instead of cmbalat
            if (cmbalat.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih nama alat terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Jumlah tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtJumlah.Text, out int jumlahValue) || jumlahValue <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka lebih dari 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpTanggalKembali.Value.Date < dtpTanggalPinjam.Value.Date)
            {
                MessageBox.Show("Tanggal kembali tidak boleh lebih awal dari tanggal pinjam!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!validasiInput()) return;

            string kodepeminjaman = txtKodePeminjaman.Text;
            int    idUser         = Convert.ToInt32(cmbuser.SelectedValue);
            string kodealat       = cmbalat.SelectedValue.ToString();
            int    jumlah         = Convert.ToInt32(txtJumlah.Text);
            string tglpinjam      = dtpTanggalPinjam.Value.ToString("yyyy-MM-dd");
            string tglkembali     = dtpTanggalKembali.Value.ToString("yyyy-MM-dd");
            string keterangan     = txtKeterangan.Text;

            DB.crud($"INSERT INTO peminjaman (kode_peminjaman, id_user, kode_alat, jumlah, " +
                    $"tgl_pinjam, tgl_kembali_rencana, keterangan, status) VALUES " +
                    $"('{kodepeminjaman}', {idUser}, '{kodealat}', {jumlah}, " +
                    $"'{tglpinjam}', '{tglkembali}', '{keterangan}', 'Menunggu')");

            MessageBox.Show("Data peminjaman berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersihkan();
            tampildata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKodePeminjaman.Text))
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validasiInput()) return;

            string kodepeminjaman = txtKodePeminjaman.Text;
            int    idUser         = Convert.ToInt32(cmbuser.SelectedValue);
            string kodealat       = cmbalat.SelectedValue.ToString();
            int    jumlah         = Convert.ToInt32(txtJumlah.Text);
            string tglpinjam      = dtpTanggalPinjam.Value.ToString("yyyy-MM-dd");
            string tglkembali     = dtpTanggalKembali.Value.ToString("yyyy-MM-dd");
            string keterangan     = txtKeterangan.Text;

            DB.crud($"UPDATE peminjaman SET " +
                    $"id_user = {idUser}, kode_alat = '{kodealat}', jumlah = {jumlah}, " +
                    $"tgl_pinjam = '{tglpinjam}', tgl_kembali_rencana = '{tglkembali}', keterangan = '{keterangan}' " +
                    $"WHERE kode_peminjaman = '{kodepeminjaman}'");

            MessageBox.Show("Data peminjaman berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersihkan();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;
            if (Baris < 0) return;

            // Column 8 = Edit
            if (Kolom == 8)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"SELECT * FROM peminjaman WHERE kode_peminjaman = '{id}'");
                    if (DB.ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = DB.ds.Tables[0].Rows[0];
                        txtKodePeminjaman.Text     = row["kode_peminjaman"].ToString();
                        txtKodePeminjaman.ReadOnly = false;
                        cmbuser.SelectedValue      = Convert.ToInt32(row["id_user"]);
                        cmbalat.SelectedValue       = row["kode_alat"].ToString();
                        txtJumlah.Text             = row["jumlah"].ToString();
                        dtpTanggalPinjam.Value      = Convert.ToDateTime(row["tgl_pinjam"]);
                        dtpTanggalKembali.Value     = Convert.ToDateTime(row["tgl_kembali_rencana"]);
                        txtKeterangan.Text          = row["keterangan"].ToString();
                    }
                }
            }

            // Column 9 = Delete
            if (Kolom == 9)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(id)) { MessageBox.Show("Data tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Hapus? " + id, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    int rows = DB.execute($"DELETE FROM peminjaman WHERE kode_peminjaman = '{id}'");
                    if (rows > 0)
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data tidak ditemukan / gagal dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bersihkan();
                    tampildata();
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void guna2Shapes1_Click(object sender, EventArgs e) { }
        private void guna2Shapes2_Click(object sender, EventArgs e) { }
        private void txtKodePeminjaman_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void cmbalat_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
        private void dtpTanggalPinjam_ValueChanged(object sender, EventArgs e) { }
        private void dtpTanggalKembali_ValueChanged(object sender, EventArgs e) { }
        private void txtKeterangan_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void cmbuser_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}
