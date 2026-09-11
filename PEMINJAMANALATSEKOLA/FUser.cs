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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
            tampildata();
        }
        public void bersih()
        {
            txtNama.Clear();
            txtUser.Clear();
            txtPass.Clear();
            cmbrole.Text = "";
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM users");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["id_user"];
                string Nama = "" + Row["nama"];
                string user = "" + Row["username"];
                string pass = "" + Row["password"];
                string role = "" + Row["id_role"];
                guna2DataGridView1.Rows.Add(id, Nama, user, pass, role);
            }
        }

        private void cmbrole_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT id_role, nama_role FROM roles");

            cmbrole.DataSource = DB.ds.Tables[0];
            cmbrole.DisplayMember = "nama_role";  // yang ditampilkan ke user
            cmbrole.ValueMember = "id_role";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtUser.Text == "" || txtPass.Text == "" || cmbrole.SelectedIndex == -1)
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
                string Nama = txtNama.Text;
                string user = txtUser.Text;
                string pass = txtPass.Text;
                int idRole = Convert.ToInt32(cmbrole.SelectedValue); 

                DB.crud($"INSERT INTO users (nama, username, password, id_role) VALUES ('{Nama}', '{user}', '{pass}', {idRole})");
                bersih();
                tampildata();
            }
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = label4.Text;
            string Nama = txtNama.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            int idRole = Convert.ToInt32(cmbrole.SelectedValue);

            DB.crud($"UPDATE users SET username = '{user}', password = '{pass}', id_role = {idRole}, nama = '{Nama}' WHERE id_user = '{id}'");
            bersih();
            tampildata();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;

            if (Kolom == 5)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM users WHERE id_user = '{id}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        string idU = "" + row["id_user"];
                        string user = "" + row["username"];
                        string pass = "" + row["password"];
                        string role = "" + row["id_role"];
                        string nama = "" + row["nama"];

                        label4.Text = idU;
                        txtNama.Text = nama;
                        txtUser.Text = user;
                        txtPass.Text = pass;
                        cmbrole.Text = role;
                    }
                }
            }

            if (Kolom == 6)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Hapus? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        DB.crud($"DELETE FROM users WHERE id_user = '{id}'");
                    }
                    tampildata();
                }
            }
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNama.Text != "")
                {
                    txtUser.Select();
                }
            }
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

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPass.Text != "")
                {
                    cmbrole.Select();
                }
            }
        }
    }
}