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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUser.Text != "")
                {
                    txtPass.Select();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            DB.crud($"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'");

            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = DB.ds.Tables[0].Rows[0];

                int idUser = Convert.ToInt32(row["id_user"]);
                string nama = row["nama"].ToString();
                string role = row["id_role"].ToString();

                // simpan ke UserSession, bisa diakses form manapun nanti
                UserSession.SetSession(idUser, nama, role);

                // TETAP pakai constructor asli, tidak diubah
                FMenuUtama menu = new FMenuUtama(nama, role);
                menu.Show();
                this.Hide();

                txtUser.Clear();
                txtPass.Clear();

                MessageBox.Show("Selamat datang " + nama + " 😊.", "Login berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username atau Password salah.", "Gagal Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPass.Text != "")
                {
                    btnlogin.Select();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}