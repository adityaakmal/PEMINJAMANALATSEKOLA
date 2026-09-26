    using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    //FORM PEMINJAMAN
    public partial class FLaporan : Form
    {
        public FLaporan()
        {
            InitializeComponent();
        }

        private void FLaporan_Load(object sender, EventArgs e)
        {
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("Semua Status");
            cmbFilterStatus.Items.Add("Menunggu");
            cmbFilterStatus.Items.Add("Diproses");
            cmbFilterStatus.Items.Add("Selesai");
            cmbFilterStatus.Items.Add("Ditolak");
            cmbFilterStatus.SelectedIndex = 0;

            cmbFilterApproval.Items.Clear();
            cmbFilterApproval.Items.Add("Semua Approval");
            cmbFilterApproval.Items.Add("Menunggu");
            cmbFilterApproval.Items.Add("Disetujui");
            cmbFilterApproval.Items.Add("Ditolak");
            cmbFilterApproval.SelectedIndex = 0;

            dtpDari.Value   = DateTime.Now.AddMonths(-3);
            dtpSampai.Value = DateTime.Now;

            TampilData();
            TampilRingkasan();
        }

        private void TampilData()
        {
            guna2DataGridView1.Rows.Clear();

            string filterStatus   = cmbFilterStatus.SelectedItem?.ToString()   ?? "Semua Status";
            string filterApproval = cmbFilterApproval.SelectedItem?.ToString() ?? "Semua Approval";
            string dari   = dtpDari.Value.ToString("yyyy-MM-dd");
            string sampai = dtpSampai.Value.ToString("yyyy-MM-dd");
            string keyword = txtCari.Text.Trim().Replace("'", "''");

            string sql =
                "SELECT kode_peminjaman, nama_peminjam, nama_alat, jumlah, " +
                "tgl_pinjam, tgl_kembali_rencana, status_peminjaman, " +
                "status_approval, tanggal_approval, " +
                "tgl_kembali_aktual, kondisi_alat " +
                "FROM laporan " +
                "WHERE tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'";

            if (filterStatus != "Semua Status")
                sql += " AND status_peminjaman = '" + filterStatus + "'";

            if (filterApproval != "Semua Approval")
                sql += " AND status_approval = '" + filterApproval + "'";

            if (!string.IsNullOrWhiteSpace(keyword))
                sql += " AND (kode_peminjaman LIKE '%" + keyword + "%' " +
                       "OR nama_peminjam LIKE '%" + keyword + "%' " +
                       "OR nama_alat LIKE '%" + keyword + "%')";

            sql += " ORDER BY tgl_pinjam DESC";

            DB.crud(sql);

            int no = 1;
            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                string statusPeminjaman = row["status_peminjaman"].ToString();
                string statusApproval   = row["status_approval"].ToString();

                guna2DataGridView1.Rows.Add(
                    no++,
                    row["kode_peminjaman"].ToString(),
                    row["nama_peminjam"].ToString(),
                    row["nama_alat"].ToString(),
                    row["jumlah"].ToString(),
                    row["tgl_pinjam"].ToString(),
                    row["tgl_kembali_rencana"].ToString(),
                    statusPeminjaman,
                    statusApproval,
                    row["tanggal_approval"].ToString(),
                    row["tgl_kembali_aktual"].ToString(),
                    row["kondisi_alat"].ToString()
                );

                // warna status peminjaman di kolom 7
                int baris = guna2DataGridView1.Rows.Count - 1;
                System.Drawing.Color warna;
                switch (statusPeminjaman)
                {
                    case "Selesai":  warna = System.Drawing.Color.FromArgb(39, 174, 96);   break;
                    case "Diproses": warna = System.Drawing.Color.FromArgb(67, 97, 238);   break;
                    case "Ditolak":  warna = System.Drawing.Color.FromArgb(231, 76, 60);   break;
                    case "Menunggu": warna = System.Drawing.Color.FromArgb(247, 148, 29);  break;
                    default:         warna = System.Drawing.Color.FromArgb(50, 50, 70);    break;
                }
                guna2DataGridView1.Rows[baris].Cells["colStatusPeminjaman"].Style.ForeColor = warna;
                guna2DataGridView1.Rows[baris].Cells["colStatusPeminjaman"].Style.Font =
                    new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            }

            lblJumlah.Text = "Total: " + guna2DataGridView1.Rows.Count + " record";
        }

        private void TampilRingkasan()
        {
            try
            {
                string dari   = dtpDari.Value.ToString("yyyy-MM-dd");
                string sampai = dtpSampai.Value.ToString("yyyy-MM-dd");

                DB.crud("SELECT COUNT(*) AS total FROM laporan WHERE tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'");
                lblTotal.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM laporan WHERE status_peminjaman='Menunggu' AND tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'");
                lblMenunggu.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM laporan WHERE status_peminjaman='Diproses' AND tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'");
                lblDiproses.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM laporan WHERE status_peminjaman='Selesai' AND tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'");
                lblSelesai.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                DB.crud("SELECT COUNT(*) AS total FROM laporan WHERE status_peminjaman='Ditolak' AND tgl_pinjam BETWEEN '" + dari + "' AND '" + sampai + "'");
                lblDitolak.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();
            }
            catch { }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilData();
            TampilRingkasan();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            cmbFilterStatus.SelectedIndex   = 0;
            cmbFilterApproval.SelectedIndex = 0;
            dtpDari.Value   = DateTime.Now.AddMonths(-3);
            dtpSampai.Value = DateTime.Now;
            TampilData();
            TampilRingkasan();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter   = "CSV Files (*.csv)|*.csv",
                FileName = "laporan_peminjaman_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("No,Kode Peminjaman,Nama Peminjam,Nama Alat,Jumlah," +
                                     "Tgl Pinjam,Tgl Kembali Rencana,Status Peminjaman," +
                                     "Status Approval,Tgl Approval,Tgl Kembali Aktual,Kondisi Alat");

                        foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                        {
                            string line = "";
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                string val = row.Cells[i].Value?.ToString() ?? "";
                                val = val.Replace("\"", "\"\"");
                                line += "\"" + val + "\"";
                                if (i < row.Cells.Count - 1) line += ",";
                            }
                            sw.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Laporan berhasil diekspor:\n" + sfd.FileName,
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal ekspor: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TampilData();
                TampilRingkasan();
            }
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)   { TampilData(); TampilRingkasan(); }
        private void cmbFilterApproval_SelectedIndexChanged(object sender, EventArgs e) { TampilData(); TampilRingkasan(); }
        private void dtpDari_ValueChanged(object sender, EventArgs e)   { TampilData(); TampilRingkasan(); }
        private void dtpSampai_ValueChanged(object sender, EventArgs e) { TampilData(); TampilRingkasan(); }
    }
}
