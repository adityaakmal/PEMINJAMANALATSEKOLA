using System;
using System.Data;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class Fpersetujuan : Form
    {
        public Fpersetujuan()
        {
            InitializeComponent();
        }

        private void Fpersetujuan_Load(object sender, EventArgs e)
        {
            muatKodePeminjaman();
            tampildata();
        }

        private void muatKodePeminjaman()
        {
            DB.crud("SELECT kode_peminjaman FROM peminjaman WHERE status = 'Menunggu'");
            cmbKodePeminjaman.DataSource     = DB.ds.Tables[0].Copy();
            cmbKodePeminjaman.DisplayMember  = "kode_peminjaman";
            cmbKodePeminjaman.ValueMember    = "kode_peminjaman";
            cmbKodePeminjaman.SelectedIndex  = -1;
            cmbKodePeminjaman.Text           = "";
        }

        private void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT ps.id_persetujuan, ps.kode_peminjaman, " +
                    "u.nama AS nama_approver, ps.status_approval, " +
                    "ps.tanggal_approval, ps.catatan_approval " +
                    "FROM persetujuan ps " +
                    "LEFT JOIN users u ON ps.id_approver = u.id_user " +
                    "ORDER BY ps.id_persetujuan DESC");

            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(
                    row["id_persetujuan"].ToString(),
                    row["kode_peminjaman"].ToString(),
                    row["nama_approver"].ToString(),
                    row["status_approval"].ToString(),
                    row["tanggal_approval"].ToString(),
                    row["catatan_approval"].ToString()
                );
            }
        }

        private void bersihkan()
        {
            cmbKodePeminjaman.SelectedIndex = -1;
            cmbKodePeminjaman.Text          = "";
            txtApprover.Clear();
            cmbrole.SelectedIndex           = -1;
            txtUser.Clear();
            guna2DateTimePicker1.Value      = DateTime.Now;
            lblTanggal.Text                 = "";
            lblInfoPeminjam.Text            = "-";
        }

        private bool validasiInput()
        {
            if (cmbKodePeminjaman.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kode peminjaman!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApprover.Text))
            {
                MessageBox.Show("Masukkan nama approver!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbrole.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih status approval!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Simpan — insert persetujuan + update peminjaman status jika Disetujui
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!validasiInput()) return;

            string kodePeminjaman  = cmbKodePeminjaman.SelectedValue.ToString();
            string approver        = txtApprover.Text.Trim();
            string statusApproval  = cmbrole.Text;          // "Disetujui" atau "Ditolak"
            string catatan         = txtUser.Text;
            string tglApproval     = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");

            // Cari id_user approver DARI nama
            DB.crud($"SELECT id_user FROM users WHERE nama = '{approver}' LIMIT 1");
            if (DB.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Approver tidak ditemukan di data user!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idApprover = Convert.ToInt32(DB.ds.Tables[0].Rows[0]["id_user"]);

            DB.crud($"INSERT INTO persetujuan (kode_peminjaman, id_approver, status_approval, tanggal_approval, catatan_approval) " +
                    $"VALUES ('{kodePeminjaman}', {idApprover}, '{statusApproval}', '{tglApproval}', '{catatan}')");

            // Jika disetujui, update status peminjaman jadi Diproses
            if (statusApproval.Trim().ToLower() == "disetujui")
                DB.crud($"UPDATE peminjaman SET status = 'Diproses' WHERE kode_peminjaman = '{kodePeminjaman}'");
            else if (statusApproval.Trim().ToLower() == "ditolak")
                DB.crud($"UPDATE peminjaman SET status = 'Ditolak' WHERE kode_peminjaman = '{kodePeminjaman}'");

            MessageBox.Show("Persetujuan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersihkan();
            muatKodePeminjaman();
            tampildata();
        }

        // Update
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblTanggal.Text))
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validasiInput()) return;

            string idPersetujuan  = lblTanggal.Text;
            string statusApproval = cmbrole.Text;
            string catatan        = txtUser.Text;
            string tglApproval    = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");

            DB.crud($"SELECT kode_peminjaman FROM persetujuan WHERE id_persetujuan = {idPersetujuan}");
            string kodePeminjaman = DB.ds.Tables[0].Rows.Count > 0
                ? DB.ds.Tables[0].Rows[0]["kode_peminjaman"].ToString()
                : "";

            DB.crud($"UPDATE persetujuan SET " +
                    $"status_approval = '{statusApproval}', " +
                    $"tanggal_approval = '{tglApproval}', " +
                    $"catatan_approval = '{catatan}' " +
                    $"WHERE id_persetujuan = {idPersetujuan}");

            if (!string.IsNullOrEmpty(kodePeminjaman))
            {
                if (statusApproval.Trim().ToLower() == "disetujui")
                    DB.crud($"UPDATE peminjaman SET status = 'Diproses' WHERE kode_peminjaman = '{kodePeminjaman}'");
                else if (statusApproval.Trim().ToLower() == "ditolak")
                    DB.crud($"UPDATE peminjaman SET status = 'Ditolak' WHERE kode_peminjaman = '{kodePeminjaman}'");
            }

            MessageBox.Show("Persetujuan berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bersihkan();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            if (Baris < 0) return;

            string idPersetujuan = guna2DataGridView1.Rows[Baris].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(idPersetujuan)) return;

            // Click any cell to load into form for editing
            DB.crud($"SELECT * FROM persetujuan WHERE id_persetujuan = {idPersetujuan}");
            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = DB.ds.Tables[0].Rows[0];
                lblTanggal.Text        = row["id_persetujuan"].ToString();
                cmbKodePeminjaman.Text = row["kode_peminjaman"].ToString();
                cmbrole.Text           = row["status_approval"].ToString();
                txtUser.Text           = row["catatan_approval"].ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(row["tanggal_approval"]);

                // Load approver name
                string idApprover = row["id_approver"].ToString();
                DB.crud($"SELECT nama FROM users WHERE id_user = {idApprover}");
                txtApprover.Text = DB.ds.Tables[0].Rows.Count > 0
                    ? DB.ds.Tables[0].Rows[0]["nama"].ToString()
                    : "";
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKodePeminjaman.SelectedIndex == -1)
            {
                lblInfoPeminjam.Text = "-";
                return;
            }
            string kode = cmbKodePeminjaman.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(kode)) return;

            DB.crud($"SELECT u.nama AS nama_peminjam, a.nama_alat, p.tgl_pinjam, p.tgl_kembali_rencana " +
                    $"FROM peminjaman p " +
                    $"LEFT JOIN users u ON p.id_user = u.id_user " +
                    $"LEFT JOIN alat a ON p.kode_alat = a.kode_alat " +
                    $"WHERE p.kode_peminjaman = '{kode}'");

            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = DB.ds.Tables[0].Rows[0];
                lblInfoPeminjam.Text = $"{row["nama_peminjam"]}  |  {row["nama_alat"]}  |  Pinjam: {row["tgl_pinjam"]:d}  Kembali: {row["tgl_kembali_rencana"]:d}";
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void lblInfoPeminjam_Click(object sender, EventArgs e)
        {

        }
    }
}
