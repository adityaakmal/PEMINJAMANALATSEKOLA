using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class Fpengembalian : Form
    {
        public Fpengembalian()
        {
            InitializeComponent();
        }


        private void Fpengembalian_Load(object sender, EventArgs e)
        {
            muatKodePeminjaman();
            muatKondisiAlat();
            muatPenerima();
            tampildata();
        }
        private void muatKodePeminjaman()
        {
            DB.crud("SELECT kode_peminjaman FROM peminjaman WHERE status = 'Diproses'");
            cmbkodepeminjam.DataSource = DB.ds.Tables[0].Copy();
            cmbkodepeminjam.DisplayMember = "kode_peminjaman";
            cmbkodepeminjam.ValueMember = "kode_peminjaman";
            cmbkodepeminjam.SelectedIndex = -1;
            cmbkodepeminjam.Text = "";
        }
        private void muatKondisiAlat()
        {
            cmbKondisialat.Items.Clear();
            cmbKondisialat.Items.Add("Baik");
            cmbKondisialat.Items.Add("Rusak");
            cmbKondisialat.Items.Add("Hilang");
            cmbKondisialat.SelectedIndex = -1;
        }

        private void muatPenerima()
        {
            DB.crud("SELECT id_user, nama FROM users");
            cmbPenerima.DataSource = DB.ds.Tables[0].Copy();
            cmbPenerima.DisplayMember = "nama";
            cmbPenerima.ValueMember = "id_user";
            cmbPenerima.SelectedIndex = -1;
            cmbPenerima.Text = "";
        }
        private void bersihkan()
        {
            cmbkodepeminjam.SelectedIndex = -1;
            lblNamaPeminjam.Text = "";
            lblNamaAlat.Text = "";
            dtp_tgl_apengembalian.Value = DateTime.Now;
            cmbKondisialat.SelectedIndex = -1;
            cmbPenerima.SelectedIndex = -1;
            txtCatatanPengembalian.Clear();
            lblidpengembalian.Text = "";
        }
        private void tampildata()
        {
            guna2DataGridView1.Rows.Clear();

            DB.crud("SELECT pg.id_pengembalian, pg.kode_peminjaman, " +
                    "up.nama AS nama_peminjam, al.nama_alat, " +
                    "p.tgl_kembali_rencana, pg.tgl_kembali_aktual, " +
                    "pg.kondisi_alat, upn.nama AS nama_penerima, " +
                    "pg.catatan_pengembalian " +
                    "FROM pengembalian pg " +
                    "LEFT JOIN peminjaman p ON pg.kode_peminjaman = p.kode_peminjaman " +
                    "LEFT JOIN users up ON p.id_user = up.id_user " +
                    "LEFT JOIN alat al ON p.kode_alat = al.kode_alat " +
                    "LEFT JOIN users upn ON pg.id_penerima = upn.id_user");

            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(
                    row["id_pengembalian"].ToString(),
                    row["kode_peminjaman"].ToString(),
                    row["nama_peminjam"].ToString(),
                    row["nama_alat"].ToString(),
                    row["tgl_kembali_aktual"].ToString(),
                    row["kondisi_alat"].ToString(),
                    row["nama_penerima"].ToString(),
                    row["catatan_pengembalian"].ToString()
                );
            }
        }
        private bool validasiInput()
        {
            if (cmbkodepeminjam.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kode peminjaman terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbKondisialat.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kondisi alat terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPenerima.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih penerima terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!validasiInput()) return;

            string kodePeminjaman = cmbkodepeminjam.SelectedValue.ToString();
            string tglKembaliAktual = dtp_tgl_apengembalian.Value.ToString("yyyy-MM-dd");
            string kondisiAlat = cmbKondisialat.Text;
            int idPenerima = Convert.ToInt32(cmbPenerima.SelectedValue);
            string catatan = txtCatatanPengembalian.Text;

            DB.crud($"INSERT INTO pengembalian " +
                    $"(kode_peminjaman, tgl_kembali_aktual, kondisi_alat, id_penerima, catatan_pengembalian) " +
                    $"VALUES " +
                    $"('{kodePeminjaman}', '{tglKembaliAktual}', '{kondisiAlat}', {idPenerima}, '{catatan}')");

            DB.crud($"UPDATE peminjaman SET status = 'Selesai' WHERE kode_peminjaman = '{kodePeminjaman}'");

            MessageBox.Show("Data pengembalian berhasil disimpan.");
            bersihkan();
            muatKodePeminjaman();
            tampildata();
        }

        private void cmbkodepeminjam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkodepeminjam.SelectedIndex == -1) return;

            string kode = cmbkodepeminjam.SelectedValue.ToString();

            DB.crud($"SELECT u.nama AS nama_peminjam, a.nama_alat, p.jumlah " +
                    $"FROM peminjaman p " +
                    $"LEFT JOIN users u ON p.id_user = u.id_user " +
                    $"LEFT JOIN alat a ON p.kode_alat = a.kode_alat " +
                    $"WHERE p.kode_peminjaman = '{kode}'");

            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = DB.ds.Tables[0].Rows[0];
                lblNamaPeminjam.Text = row["nama_peminjam"].ToString();
                lblNamaAlat.Text = row["nama_alat"].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblidpengembalian.Text))
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu.");
                return;
            }

            if (!validasiInput()) return;

            string idPengembalian = lblidpengembalian.Text;
            string tglKembaliAktual = dtp_tgl_apengembalian.Value.ToString("yyyy-MM-dd");
            string kondisiAlat = cmbKondisialat.Text;
            int idPenerima = Convert.ToInt32(cmbPenerima.SelectedValue);
            string catatan = txtCatatanPengembalian.Text;

            DB.crud($"UPDATE pengembalian SET " +
                    $"tgl_kembali_aktual = '{tglKembaliAktual}', " +
                    $"kondisi_alat = '{kondisiAlat}', " +
                    $"id_penerima = {idPenerima}, " +
                    $"catatan_pengembalian = '{catatan}' " +
                    $"WHERE id_pengembalian = {idPengembalian}");

            MessageBox.Show("Data pengembalian berhasil diupdate.");
            bersihkan();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;
            if (Baris < 0) return;

            // --- EDIT ---
            if (Kolom == 8) // sesuaikan index kolom tombol Edit di grid kamu
            {
                string idPengembalian = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();

                DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? ID " + idPengembalian, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"SELECT * FROM pengembalian WHERE id_pengembalian = {idPengembalian}");

                    if (DB.ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = DB.ds.Tables[0].Rows[0];

                        lblidpengembalian.Text = row["id_pengembalian"].ToString();
                        cmbkodepeminjam.SelectedValue = row["kode_peminjaman"].ToString();
                        // cmbKodePeminjaman_SelectedIndexChanged otomatis terpanggil,
                        // lblNamaPeminjam & lblNamaAlat ikut terisi otomatis
                        dtp_tgl_apengembalian.Value = Convert.ToDateTime(row["tgl_kembali_aktual"]);
                        cmbKondisialat.Text = row["kondisi_alat"].ToString();
                        cmbPenerima.SelectedValue = Convert.ToInt32(row["id_penerima"]);
                        txtCatatanPengembalian.Text = row["catatan_pengembalian"].ToString();
                    }
                }
            }

            // --- DELETE ---
            if (Kolom == 9) // sesuaikan index kolom tombol Delete di grid kamu
            {
                string idPengembalian = guna2DataGridView1.Rows[Baris].Cells[0].Value?.ToString();
                string kodePeminjaman = guna2DataGridView1.Rows[Baris].Cells[1].Value?.ToString();

                if (string.IsNullOrEmpty(idPengembalian))
                {
                    MessageBox.Show("Data tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult setuju = MessageBox.Show(
                    "Apakah Yakin Mau Hapus data pengembalian ini?", "pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (setuju == DialogResult.Yes)
                {
                    int rows = DB.execute($"DELETE FROM pengembalian WHERE id_pengembalian = {idPengembalian}");

                    if (rows > 0)
                    {
                        DB.crud($"UPDATE peminjaman SET status = 'Diproses' WHERE kode_peminjaman = '{kodePeminjaman}'");
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan / gagal dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    bersihkan();
                    muatKodePeminjaman();
                    tampildata();
                }
            }
        }
    }
}   
