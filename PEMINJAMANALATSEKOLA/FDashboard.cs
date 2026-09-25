using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class FDashboard : Form
    {
        public FDashboard()
        {
            InitializeComponent();
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            MuatStatistik();
          System.Action<Guna.UI2.WinForms.Guna2Panel, System.Windows.Forms.Label, System.Windows.Forms.Label, System.Windows.Forms.Label, int, string, string, Color> buildCard =
    (panel, numLbl, titleLbl, iconLbl, x, icon, title, clr) =>
    {
        panel.BorderRadius = 16;
        panel.FillColor = clr;
        panel.Location = new System.Drawing.Point(x, 5);
        panel.Size = new System.Drawing.Size(144, 130);

        iconLbl.Font = new System.Drawing.Font("Segoe UI", 22F);
        iconLbl.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
        iconLbl.Location = new System.Drawing.Point(10, 10);
        iconLbl.Size = new System.Drawing.Size(50, 40);
        iconLbl.Text = icon;
        iconLbl.BackColor = System.Drawing.Color.Transparent;

        numLbl.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
        numLbl.ForeColor = System.Drawing.Color.White;
        numLbl.Location = new System.Drawing.Point(8, 45);
        numLbl.Size = new System.Drawing.Size(130, 50);
        numLbl.Text = "0";
        numLbl.BackColor = System.Drawing.Color.Transparent;
        numLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        titleLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        titleLbl.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
        titleLbl.Location = new System.Drawing.Point(8, 100);
        titleLbl.Size = new System.Drawing.Size(130, 20);
        titleLbl.Text = title;
        titleLbl.BackColor = System.Drawing.Color.Transparent;

        panel.Controls.Add(iconLbl);
        panel.Controls.Add(numLbl);
        panel.Controls.Add(titleLbl);
    };

buildCard(card1, lblTotalAlat, lbl1Title, lbl1Icon, 0,   "🔧", "Total Alat",       System.Drawing.Color.FromArgb(67, 97, 238));
buildCard(card2, lblTotalUser, lbl2Title, lbl2Icon, 155, "👤", "Total User",       System.Drawing.Color.FromArgb(76, 201, 160));
//buildCard(card3, lblTotalPeminjaman, lbl3Title, lbl3Icon, 310, "📋", "Total Peminjaman", System.Drawing.Color.FromArgb(247, 148, /* lanjutkan angka aslinya */));
buildCard(card4, lblMenunggu, lbl4Title, lbl4Icon, 465, "⏳", "Menunggu",         System.Drawing.Color.FromArgb(255, 99, 99));
buildCard(card5, lblDiproses, lbl5Title, lbl5Icon, 620, "🔒", "Diproses",         System.Drawing.Color.FromArgb(114, 9, 183));
buildCard(card6, lblSelesai, lbl6Title, lbl6Icon, 775,  "☑", "Selesai",          System.Drawing.Color.FromArgb(39, 174, 96));
        }

        private void MuatStatistik()
        {
            try
            {
                DB.crud("SELECT COUNT(*) AS total FROM alat");
                lblTotalAlat.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM users");
                lblTotalUser.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM peminjaman WHERE status = 'Menunggu'");
                lblMenunggu.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM peminjaman WHERE status = 'Diproses'");
                lblDiproses.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM peminjaman WHERE status = 'Selesai'");
                lblSelesai.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM peminjaman");
                lblTotalPeminjaman.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                // Load recent peminjaman
                DB.crud("SELECT p.kode_peminjaman, u.nama AS nama_peminjam, a.nama_alat, " +
                        "p.tgl_pinjam, p.tgl_kembali_rencana, p.status " +
                        "FROM peminjaman p " +
                        "LEFT JOIN users u ON p.id_user = u.id_user " +
                        "LEFT JOIN alat a ON p.kode_alat = a.kode_alat " +
                        "ORDER BY p.tgl_pinjam DESC LIMIT 10");

                dgvRecent.Rows.Clear();
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    dgvRecent.Rows.Add(
                        row["kode_peminjaman"].ToString(),
                        row["nama_peminjam"].ToString(),
                        row["nama_alat"].ToString(),
                        row["tgl_pinjam"].ToString(),
                        row["tgl_kembali_rencana"].ToString(),
                        row["status"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                // Silently ignore if tables don't exist yet
                Console.WriteLine("Dashboard load error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatStatistik();
        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
