
namespace PEMINJAMANALATSEKOLA
{
    partial class FDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBg = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.card1 = new Guna.UI2.WinForms.Guna2Panel();
            this.card2 = new Guna.UI2.WinForms.Guna2Panel();
            this.card3 = new Guna.UI2.WinForms.Guna2Panel();
            this.card4 = new Guna.UI2.WinForms.Guna2Panel();
            this.card5 = new Guna.UI2.WinForms.Guna2Panel();
            this.card6 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglPinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglKembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAlat = new System.Windows.Forms.Label();
            this.lbl1Title = new System.Windows.Forms.Label();
            this.lbl1Icon = new System.Windows.Forms.Label();
            this.lblTotalUser = new System.Windows.Forms.Label();
            this.lbl2Title = new System.Windows.Forms.Label();
            this.lbl2Icon = new System.Windows.Forms.Label();
            this.lblTotalPeminjaman = new System.Windows.Forms.Label();
            this.lbl3Title = new System.Windows.Forms.Label();
            this.lbl3Icon = new System.Windows.Forms.Label();
            this.lblMenunggu = new System.Windows.Forms.Label();
            this.lbl4Title = new System.Windows.Forms.Label();
            this.lbl4Icon = new System.Windows.Forms.Label();
            this.lblDiproses = new System.Windows.Forms.Label();
            this.lbl5Title = new System.Windows.Forms.Label();
            this.lbl5Icon = new System.Windows.Forms.Label();
            this.lblSelesai = new System.Windows.Forms.Label();
            this.lbl6Title = new System.Windows.Forms.Label();
            this.lbl6Icon = new System.Windows.Forms.Label();
            this.pnlBg.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBg
            // 
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlBg.Controls.Add(this.lblTitle);
            this.pnlBg.Controls.Add(this.lblSubtitle);
            this.pnlBg.Controls.Add(this.btnRefresh);
            this.pnlBg.Controls.Add(this.pnlCards);
            this.pnlBg.Controls.Add(this.pnlGrid);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Location = new System.Drawing.Point(0, 0);
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Size = new System.Drawing.Size(1273, 680);
            this.pnlBg.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.lblSubtitle.Location = new System.Drawing.Point(313, 30);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(402, 23);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Selamat datang di Sistem Peminjaman Alat Sekolah";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(840, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "⟳ Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlCards
            // 
            this.pnlCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Controls.Add(this.card1);
            this.pnlCards.Controls.Add(this.card2);
            this.pnlCards.Controls.Add(this.card3);
            this.pnlCards.Controls.Add(this.card4);
            this.pnlCards.Controls.Add(this.card5);
            this.pnlCards.Controls.Add(this.card6);
            this.pnlCards.Location = new System.Drawing.Point(20, 90);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1241, 150);
            this.pnlCards.TabIndex = 3;
            // 
            // card1
            // 
            this.card1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.card1.Location = new System.Drawing.Point(11, 0);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(192, 100);
            this.card1.TabIndex = 0;
            this.card1.Paint += new System.Windows.Forms.PaintEventHandler(this.card1_Paint);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(0, 0);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(200, 100);
            this.card2.TabIndex = 1;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(0, 0);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(200, 100);
            this.card3.TabIndex = 2;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(0, 0);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(200, 100);
            this.card4.TabIndex = 3;
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(0, 0);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(200, 100);
            this.card5.TabIndex = 4;
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(0, 0);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(200, 100);
            this.card6.TabIndex = 5;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.dgvRecent);
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(20, 255);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1241, 400);
            this.pnlGrid.TabIndex = 4;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(400, 28);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Peminjaman Terbaru";
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecent.ColumnHeadersHeight = 36;
            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKode,
            this.colPeminjam,
            this.colAlat,
            this.colTglPinjam,
            this.colTglKembali,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.dgvRecent.Location = new System.Drawing.Point(15, 52);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowHeadersWidth = 51;
            this.dgvRecent.RowTemplate.Height = 32;
            this.dgvRecent.Size = new System.Drawing.Size(1223, 335);
            this.dgvRecent.TabIndex = 1;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvRecent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.dgvRecent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dgvRecent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRecent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecent.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvRecent.ThemeStyle.ReadOnly = true;
            this.dgvRecent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRecent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.dgvRecent.ThemeStyle.RowsStyle.Height = 32;
            this.dgvRecent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvRecent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // colKode
            // 
            this.colKode.HeaderText = "Kode Peminjaman";
            this.colKode.MinimumWidth = 6;
            this.colKode.Name = "colKode";
            this.colKode.ReadOnly = true;
            // 
            // colPeminjam
            // 
            this.colPeminjam.HeaderText = "Nama Peminjam";
            this.colPeminjam.MinimumWidth = 6;
            this.colPeminjam.Name = "colPeminjam";
            this.colPeminjam.ReadOnly = true;
            // 
            // colAlat
            // 
            this.colAlat.HeaderText = "Nama Alat";
            this.colAlat.MinimumWidth = 6;
            this.colAlat.Name = "colAlat";
            this.colAlat.ReadOnly = true;
            // 
            // colTglPinjam
            // 
            this.colTglPinjam.HeaderText = "Tgl Pinjam";
            this.colTglPinjam.MinimumWidth = 6;
            this.colTglPinjam.Name = "colTglPinjam";
            this.colTglPinjam.ReadOnly = true;
            // 
            // colTglKembali
            // 
            this.colTglKembali.HeaderText = "Tgl Kembali";
            this.colTglKembali.MinimumWidth = 6;
            this.colTglKembali.Name = "colTglKembali";
            this.colTglKembali.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // lblTotalAlat
            // 
            this.lblTotalAlat.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAlat.Name = "lblTotalAlat";
            this.lblTotalAlat.Size = new System.Drawing.Size(100, 23);
            this.lblTotalAlat.TabIndex = 0;
            // 
            // lbl1Title
            // 
            this.lbl1Title.Location = new System.Drawing.Point(0, 0);
            this.lbl1Title.Name = "lbl1Title";
            this.lbl1Title.Size = new System.Drawing.Size(100, 23);
            this.lbl1Title.TabIndex = 0;
            // 
            // lbl1Icon
            // 
            this.lbl1Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl1Icon.Name = "lbl1Icon";
            this.lbl1Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl1Icon.TabIndex = 0;
            // 
            // lblTotalUser
            // 
            this.lblTotalUser.Location = new System.Drawing.Point(0, 0);
            this.lblTotalUser.Name = "lblTotalUser";
            this.lblTotalUser.Size = new System.Drawing.Size(100, 23);
            this.lblTotalUser.TabIndex = 0;
            // 
            // lbl2Title
            // 
            this.lbl2Title.Location = new System.Drawing.Point(0, 0);
            this.lbl2Title.Name = "lbl2Title";
            this.lbl2Title.Size = new System.Drawing.Size(100, 23);
            this.lbl2Title.TabIndex = 0;
            // 
            // lbl2Icon
            // 
            this.lbl2Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl2Icon.Name = "lbl2Icon";
            this.lbl2Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl2Icon.TabIndex = 0;
            // 
            // lblTotalPeminjaman
            // 
            this.lblTotalPeminjaman.Location = new System.Drawing.Point(0, 0);
            this.lblTotalPeminjaman.Name = "lblTotalPeminjaman";
            this.lblTotalPeminjaman.Size = new System.Drawing.Size(100, 23);
            this.lblTotalPeminjaman.TabIndex = 0;
            // 
            // lbl3Title
            // 
            this.lbl3Title.Location = new System.Drawing.Point(0, 0);
            this.lbl3Title.Name = "lbl3Title";
            this.lbl3Title.Size = new System.Drawing.Size(100, 23);
            this.lbl3Title.TabIndex = 0;
            // 
            // lbl3Icon
            // 
            this.lbl3Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl3Icon.Name = "lbl3Icon";
            this.lbl3Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl3Icon.TabIndex = 0;
            // 
            // lblMenunggu
            // 
            this.lblMenunggu.Location = new System.Drawing.Point(0, 0);
            this.lblMenunggu.Name = "lblMenunggu";
            this.lblMenunggu.Size = new System.Drawing.Size(100, 23);
            this.lblMenunggu.TabIndex = 0;
            // 
            // lbl4Title
            // 
            this.lbl4Title.Location = new System.Drawing.Point(0, 0);
            this.lbl4Title.Name = "lbl4Title";
            this.lbl4Title.Size = new System.Drawing.Size(100, 23);
            this.lbl4Title.TabIndex = 0;
            // 
            // lbl4Icon
            // 
            this.lbl4Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl4Icon.Name = "lbl4Icon";
            this.lbl4Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl4Icon.TabIndex = 0;
            // 
            // lblDiproses
            // 
            this.lblDiproses.Location = new System.Drawing.Point(0, 0);
            this.lblDiproses.Name = "lblDiproses";
            this.lblDiproses.Size = new System.Drawing.Size(100, 23);
            this.lblDiproses.TabIndex = 0;
            // 
            // lbl5Title
            // 
            this.lbl5Title.Location = new System.Drawing.Point(0, 0);
            this.lbl5Title.Name = "lbl5Title";
            this.lbl5Title.Size = new System.Drawing.Size(100, 23);
            this.lbl5Title.TabIndex = 0;
            // 
            // lbl5Icon
            // 
            this.lbl5Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl5Icon.Name = "lbl5Icon";
            this.lbl5Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl5Icon.TabIndex = 0;
            // 
            // lblSelesai
            // 
            this.lblSelesai.Location = new System.Drawing.Point(0, 0);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(100, 23);
            this.lblSelesai.TabIndex = 0;
            // 
            // lbl6Title
            // 
            this.lbl6Title.Location = new System.Drawing.Point(0, 0);
            this.lbl6Title.Name = "lbl6Title";
            this.lbl6Title.Size = new System.Drawing.Size(100, 23);
            this.lbl6Title.TabIndex = 0;
            // 
            // lbl6Icon
            // 
            this.lbl6Icon.Location = new System.Drawing.Point(0, 0);
            this.lbl6Icon.Name = "lbl6Icon";
            this.lbl6Icon.Size = new System.Drawing.Size(100, 23);
            this.lbl6Icon.TabIndex = 0;
            // 
            // FDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1273, 680);
            this.Controls.Add(this.pnlBg);
            this.Name = "FDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FDashboard_Load);
            this.pnlBg.ResumeLayout(false);
            this.pnlBg.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Panel pnlCards;
        private Guna.UI2.WinForms.Guna2Panel card1, card2, card3, card4, card5, card6;
        private System.Windows.Forms.Label lblTotalAlat, lbl1Title, lbl1Icon;
        private System.Windows.Forms.Label lblTotalUser, lbl2Title, lbl2Icon;
        private System.Windows.Forms.Label lblTotalPeminjaman, lbl3Title, lbl3Icon;
        private System.Windows.Forms.Label lblMenunggu, lbl4Title, lbl4Icon;
        private System.Windows.Forms.Label lblDiproses, lbl5Title, lbl5Icon;
        private System.Windows.Forms.Label lblSelesai, lbl6Title, lbl6Icon;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglPinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglKembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
