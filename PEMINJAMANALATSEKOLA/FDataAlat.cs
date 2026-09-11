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
            DB.crud("SELECT * FROM alat");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["kode_alat"];
                string Namaalat = "" + Row["nama_alat"];
                string kategori = "" + Row["id_kategori"];
                string jumlah = "" + Row["jumlah"];
                string kondisi = "" + Row["kondisi"];

                guna2DataGridView1.Rows.Add(id, Namaalat, kategori, jumlah, kondisi);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtKodeAlat.Text == "" || txtNamaAlat.Text == "" || cmbKategori.Text == "" || txtjumlah.Text == "" || txtkondisi.Text == "")
            {
                DialogResult DataKosong = MessageBox.Show(
                    "Masukan Data yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                string kodealat = txtKodeAlat.Text;
                string namaalat = txtNamaAlat.Text;
                string kategori = cmbKategori.Text;
                string jumlah = txtjumlah.Text;
                string kondisi = txtkondisi.Text;

                DB.crud($"INSERT INTO alat (kode_alat, nama_alat, id_kategori, jumlah, kondisi ) VALUES ('{kodealat}', '{namaalat}', '{kategori}', '{jumlah}', '{kondisi}')");

                tampildata();
            }
        }

     
            private void guna2Button2_Click(object sender, EventArgs e)
            {
                string kodealat = txtKodeAlat.Text;
                string namaalat = txtNamaAlat.Text;
                string kategori = cmbKategori.Text;
                string jumlah = txtjumlah.Text;
                string kondisi = txtkondisi.Text;

                DB.crud($"UPDATE alat SET " +
                        $"nama_alat = '{namaalat}', " +
                        $"id_kategori = '{kategori}', " +
                        $"jumlah = '{jumlah}', " +
                        $"kondisi = '{kondisi}' " +
                        $"WHERE kode_alat = '{kodealat}'");

                MessageBox.Show("Data berhasil diupdate");
                tampildata();
            }

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;

            if (Kolom == 5)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM alat WHERE kode_alat = '{id}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        string kodealat = row["kode_alat"].ToString();
                        string nama_alat = row["nama_alat"].ToString();
                        string kategori = row["id_kategori"].ToString();      
                        string jumlah = row["jumlah"].ToString();
                        string kondisi = row["kondisi"].ToString();

                        txtKodeAlat.Text = kodealat;
                        txtNamaAlat.Text = nama_alat;
                        cmbKategori.Text = kategori;
                        txtjumlah.Text = jumlah;
                        txtkondisi.Text = kondisi;
                    }
                    break;
                }
            }
        
    

            if (Kolom == 6)
            {
                if (Baris < 0) return;

                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value?.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Data tidak valid.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult setuju = MessageBox.Show(
                    "Apakah Yakin Mau Hapus? " + id, "pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (setuju == DialogResult.Yes)
                {
                    int rows = DB.execute($"DELETE FROM alat WHERE kode_alat = '{id}'");

                    if (rows > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan / gagal dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                tampildata();
            }
        }


        private void cmbKategori_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT * FROM kategori");
            cmbKategori.Items.Clear();

            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                string kategori = "" + row["id_kategori"];
                cmbKategori.Items.Add(kategori);
            }
        }
    }
}
