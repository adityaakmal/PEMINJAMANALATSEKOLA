using System;
using System.Data;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class FDataAlat : Form
    {
        public FDataAlat()
        {
            InitializeComponent();
            tampildata();
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT a.kode_alat, a.nama_alat, k.nama_kategori, a.jumlah, a.kondisi " +
                    "FROM alat a LEFT JOIN kategori k ON a.id_kategori = k.id_kategori");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(
                    "" + Row["kode_alat"],
                    "" + Row["nama_alat"],
                    "" + Row["nama_kategori"],
                    "" + Row["jumlah"],
                    "" + Row["kondisi"]
                );
            }
        }

        private void BersihkanForm()
        {
            txtKodeAlat.Text = "";
            txtNamaAlat.Text = "";
            cmbKategori.SelectedIndex = -1;
            cmbKategori.Text = "";
            txtjumlah.Text = "";
            txtkondisi.Text = "";
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtKodeAlat.Text == "" || txtNamaAlat.Text == "" || cmbKategori.SelectedIndex == -1 || txtjumlah.Text == "" || txtkondisi.Text == "")
            {
                MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kodealat   = txtKodeAlat.Text;
            string namaalat   = txtNamaAlat.Text;
            string idKategori = cmbKategori.SelectedValue.ToString();
            string jumlah     = txtjumlah.Text;
            string kondisi    = txtkondisi.Text;

            DB.crud($"INSERT INTO alat (kode_alat, nama_alat, id_kategori, jumlah, kondisi) " +
                    $"VALUES ('{kodealat}', '{namaalat}', '{idKategori}', '{jumlah}', '{kondisi}')");
            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BersihkanForm();
            tampildata();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtKodeAlat.Text == "")
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kodealat   = txtKodeAlat.Text;
            string namaalat   = txtNamaAlat.Text;
            string idKategori = cmbKategori.SelectedValue != null ? cmbKategori.SelectedValue.ToString() : cmbKategori.Text;
            string jumlah     = txtjumlah.Text;
            string kondisi    = txtkondisi.Text;

            DB.crud($"UPDATE alat SET " +
                    $"nama_alat = '{namaalat}', " +
                    $"id_kategori = '{idKategori}', " +
                    $"jumlah = '{jumlah}', " +
                    $"kondisi = '{kondisi}' " +
                    $"WHERE kode_alat = '{kodealat}'");

            MessageBox.Show("Data berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BersihkanForm();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;
            if (Baris < 0) return;

            // Column 5 = Edit icon
            if (Kolom == 5)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"SELECT * FROM alat WHERE kode_alat = '{id}'");
                    if (DB.ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = DB.ds.Tables[0].Rows[0];
                        txtKodeAlat.Text  = row["kode_alat"].ToString();
                        txtNamaAlat.Text  = row["nama_alat"].ToString();
                        cmbKategori.Text  = row["id_kategori"].ToString();
                        txtjumlah.Text    = row["jumlah"].ToString();
                        txtkondisi.Text   = row["kondisi"].ToString();
                    }
                }
            }

            // Column 6 = Delete icon
            if (Kolom == 6)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(id)) { MessageBox.Show("Data tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Hapus? " + id, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    int rows = DB.execute($"DELETE FROM alat WHERE kode_alat = '{id}'");
                    if (rows > 0)
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data tidak ditemukan / gagal dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tampildata();
                }
            }
        }

        private void cmbKategori_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT id_kategori, nama_kategori FROM kategori");
            cmbKategori.DataSource = DB.ds.Tables[0].Copy();
            cmbKategori.DisplayMember = "nama_kategori";
            cmbKategori.ValueMember = "id_kategori";
        }
    }
}
