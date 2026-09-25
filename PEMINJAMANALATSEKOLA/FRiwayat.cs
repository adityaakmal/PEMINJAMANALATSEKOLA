using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class FRiwayat : Form
    {
        public FRiwayat()
        {
            InitializeComponent();
        }

        private void FRiwayat_Load(object sender, EventArgs e)
        {
            // isi combobox filter status
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("Semua");
            cmbFilterStatus.Items.Add("Menunggu");
            cmbFilterStatus.Items.Add("Diproses");
            cmbFilterStatus.Items.Add("Selesai");
            cmbFilterStatus.Items.Add("Ditolak");
            cmbFilterStatus.SelectedIndex = 0;

            dtpDari.Value  = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;

            TampilData();
        }

        private void TampilData()
        {
            guna2DataGridView1.Rows.Clear();

            string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "Semua";
            string dari   = dtpDari.Value.ToString("yyyy-MM-dd");
            string sampai = dtpSampai.Value.ToString("yyyy-MM-dd");
            string keyword = txtCari.Text.Trim().Replace("'", "''");

            string sql = "SELECT r.id_riwayat, r.kode_peminjaman, " +
                         "u.nama AS nama_user, r.status_lama, r.status_baru, " +
                         "r.waktu_perubahan, r.keterangan " +
                         "FROM riwayat r " +
                         "LEFT JOIN users u ON r.id_user = u.id_user " +
                         "WHERE DATE(r.waktu_perubahan) BETWEEN '" + dari + "' AND '" + sampai + "'";

            if (filterStatus != "Semua")
                sql += " AND r.status_baru = '" + filterStatus + "'";

            if (!string.IsNullOrWhiteSpace(keyword))
                sql += " AND (r.kode_peminjaman LIKE '%" + keyword + "%' " +
                       "OR u.nama LIKE '%" + keyword + "%')";

            sql += " ORDER BY r.waktu_perubahan DESC";

            DB.crud(sql);

            int no = 1;
            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                // warna badge status
                string statusBaru = row["status_baru"].ToString();

                guna2DataGridView1.Rows.Add(
                    no++,
                    row["id_riwayat"].ToString(),
                    row["kode_peminjaman"].ToString(),
                    row["nama_user"].ToString(),
                    row["status_lama"].ToString(),
                    statusBaru,
                    row["waktu_perubahan"].ToString(),
                    row["keterangan"].ToString()
                );

                // warna baris berdasarkan status
                int baris = guna2DataGridView1.Rows.Count - 1;
                switch (statusBaru)
                {
                    case "Disetujui":
                    case "Diproses":
                        guna2DataGridView1.Rows[baris].DefaultCellStyle.ForeColor =
                            System.Drawing.Color.FromArgb(39, 174, 96);
                        break;
                    case "Selesai":
                        guna2DataGridView1.Rows[baris].DefaultCellStyle.ForeColor =
                            System.Drawing.Color.FromArgb(67, 97, 238);
                        break;
                    case "Ditolak":
                        guna2DataGridView1.Rows[baris].DefaultCellStyle.ForeColor =
                            System.Drawing.Color.FromArgb(231, 76, 60);
                        break;
                    case "Menunggu":
                        guna2DataGridView1.Rows[baris].DefaultCellStyle.ForeColor =
                            System.Drawing.Color.FromArgb(247, 148, 29);
                        break;
                }
            }

            lblJumlah.Text = "Total: " + guna2DataGridView1.Rows.Count + " record";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            cmbFilterStatus.SelectedIndex = 0;
            dtpDari.Value   = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;
            TampilData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter   = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "riwayat_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // header
                        sw.WriteLine("No,ID Riwayat,Kode Peminjaman,Nama User,Status Lama,Status Baru,Waktu Perubahan,Keterangan");

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
                    MessageBox.Show("Data berhasil diekspor ke:\n" + sfd.FileName,
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
                TampilData();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilData();
        }

        private void dtpDari_ValueChanged(object sender, EventArgs e)   { TampilData(); }
        private void dtpSampai_ValueChanged(object sender, EventArgs e) { TampilData(); }
    }
}
