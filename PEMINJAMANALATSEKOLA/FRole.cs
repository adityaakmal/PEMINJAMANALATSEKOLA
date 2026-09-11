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
    public partial class FRole : Form
    {
        public FRole()
        {
            InitializeComponent();
            tampildata();
        }
        public void bersih()
        {
            txtID.Clear();
            txtRole.Clear();
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM roles");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["id_role"];
                string role = "" + Row["nama_role"];
                guna2DataGridView1.Rows.Add(id, role);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtRole.Text == "")
            {
                DialogResult DataKosong = MessageBox.Show("Masukan Data yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
  
                string role = txtRole.Text;
                DB.crud($"INSERT INTO roles VALUES (null, '{role}')");
                bersih();
                tampildata();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = label3.Text;
            string role = txtRole.Text;

            DB.crud($"UPDATE roles SET role = '{role}' WHERE id_role = '{id}'");
            bersih();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Baris = e.RowIndex;
            int Kolom = e.ColumnIndex;

            if (Kolom == 2)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM roles WHERE id_role = '{id}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah Yakin Mau Edit? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)

                    {
                        string idU = "" + row["id_role"];
                        string role = "" + row["nama_role"];


                        label4.Text = idU;
                        txtID.Text = idU;
                        txtRole.Text = role;
                    }
                }
            }

            if (Kolom == 3)
            {
                string id = guna2DataGridView1.Rows[Baris].Cells[0].Value.ToString();
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    DialogResult setuju = MessageBox.Show("Apakah mau hapus? " + id, "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        DB.crud($"DELETE FROM roles WHERE id_role = '{id}'");
                    }
                    tampildata();
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtID.Text != "")
                {
                    txtRole.Select();
                }
            }
        }
    }
}
