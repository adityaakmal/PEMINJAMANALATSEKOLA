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
    public partial class FKategoriAlat : Form
    {
        public FKategoriAlat()
        {
            InitializeComponent();
            tampildata();
        }

        public void tampildata()
        {
            
                guna2DataGridView1.Rows.Clear();
                DB.crud("SELECT * FROM kategori");

                foreach (DataRow Row in DB.ds.Tables[0].Rows)
                {
                    string id = "" + Row["id_kategori"];
                    string Namakategori = "" + Row["nama_kategori"];
                    string keterangan = "" + Row["keterangan"];

                    guna2DataGridView1.Rows.Add(id, Namakategori, keterangan);
                }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtIDKategori.Text == "" || txtnamakategori.Text == "" || txtketerangan.Text == "")
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
                string Kategori = txtIDKategori.Text;
                string namakategori = txtnamakategori.Text;
                string keterangan = txtketerangan.Text;

                DB.crud($"INSERT INTO kategori (id_kategori, nama_kategori, keterangan) VALUES ('{Kategori}', '{namakategori}', '{keterangan}')");

                tampildata();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = label4.Text;
            string namaKategori = txtnamakategori.Text;
            string keterangan = txtketerangan.Text;

            DB.crud($"UPDATE kategori SET nama_kategori = '{namaKategori}', keterangan = '{keterangan}' WHERE id_kategori = '{id}'");
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;

            if (Kolom == 3)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM kategori WHERE id_kategori = '{id}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        string idK = "" + row["id_kategori"];
                        string nama_kategori = "" + row["nama_kategori"];
                        string keterangan = "" + row["keterangan"];
                       
                    

                        label4.Text = idK;
                        txtnamakategori.Text = nama_kategori;
                        txtketerangan.Text = keterangan;
                       
                    }
                }
            }

            if (Kolom == 4)
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
                    int rows = DB.execute($"DELETE FROM kategori WHERE id_kategori = '{id}'");

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

        private void txtIDKategori_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {
            //123
        }
    }
}
