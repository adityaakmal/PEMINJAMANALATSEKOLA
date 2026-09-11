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
    public partial class FMenuUtama : Form
    {
        private string namaUser;
        private string roleUser;
        public FMenuUtama()
        {
            InitializeComponent();
        }

        public FMenuUtama(string nama, string role)
        {
            InitializeComponent();
            namaUser = nama;
            roleUser = role;
        }

        private void FMenuUtama_Load(object sender, EventArgs e)
        {
           // lblUserAktif.Text = "Login sebagai: " + namaUser + " (" + roleUser + ")";
            AturHakAkses();
        }

        private void AturHakAkses()
        {
            if (roleUser.Trim().ToLower() == "petugas")
            {
                SembunyikanMenu("btnDataMaster");   // <- GANTI dengan nama asli parent "Data Master"
                SembunyikanMenu("btnUser");
                SembunyikanMenu("btnRole");
                SembunyikanMenu("btnKategoriAlat");
                SembunyikanMenu("btnDataAlat");
                SembunyikanMenu("btnDataPeminjam");
            }
        }

        // Method bantu: cari kontrol berdasarkan nama, di manapun posisinya (termasuk di dalam panel)
        private void SembunyikanMenu(string namaKontrol)
        {
            Control[] hasil = this.Controls.Find(namaKontrol, true); // true = cari sampai ke dalam (nested)
            if (hasil.Length > 0)
            {
                hasil[0].Visible = false;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (PNLSIDE.Visible == true)
            {
                PNLSIDE.Visible = false;
            }
            else
            {
                PNLSIDE.Visible = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("apakah mau keluar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                Flogin F1 = new Flogin();
                F1.Visible = true;
                this.Hide();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             FDashboard hal1= new FDashboard() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal1, PNLKONTEN);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
             FUser hal2 = new FUser() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal2, PNLKONTEN);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FRole hal3 = new FRole() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal3, PNLKONTEN);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (pnldpdown.Visible == true)
            {
                pnldpdown.Visible = false;
            }
            else
            {
                pnldpdown.Visible = true;
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FKategoriAlat hal3 = new FKategoriAlat() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal3, PNLKONTEN);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
             FDataAlat hal3 = new FDataAlat() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal3, PNLKONTEN);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Fpeminjaman hal3 = new Fpeminjaman() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal3, PNLKONTEN);
        }

        private void btnTransakasi_Click(object sender, EventArgs e)
        {
            if (pnldropdown2.Visible == true)
            {
                pnldropdown2.Visible = false;
            }
            else
            {
                pnldropdown2.Visible = true;
            }
        }

       

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            Fpengembalian hal2 = new Fpengembalian() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal2, PNLKONTEN);
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            Fpersetujuan hal2 = new Fpersetujuan() { TopLevel = false, TopMost = true };
            KF.untukformadit(hal2, PNLKONTEN);
        }
    }
}
