
namespace PEMINJAMANALATSEKOLA
{
    partial class FRiwayat
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
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle  = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle  = new System.Windows.Forms.DataGridViewCellStyle();

            // ── Controls ──────────────────────────────────────────────
            this.pnlBg           = new System.Windows.Forms.Panel();
            // header banner
            this.pnlHeader       = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.lblSub          = new System.Windows.Forms.Label();
            // filter bar
            this.pnlFilter       = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCari         = new System.Windows.Forms.Label();
            this.txtCari         = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus       = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDari         = new System.Windows.Forms.Label();
            this.dtpDari         = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSampai       = new System.Windows.Forms.Label();
            this.dtpSampai       = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCari         = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset        = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport       = new Guna.UI2.WinForms.Guna2Button();
            // grid area
            this.pnlGrid         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJumlah       = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            // columns
            this.colNo           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKode         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusLama   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusBaru   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaktu        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeterangan   = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlBg.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // ── pnlBg ──────────────────────────────────────────────────
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Controls.Add(this.pnlHeader);
            this.pnlBg.Controls.Add(this.pnlFilter);
            this.pnlBg.Controls.Add(this.pnlGrid);

            // ── pnlHeader ──────────────────────────────────────────────
            this.pnlHeader.BorderRadius = 16;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.pnlHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlHeader.Size = new System.Drawing.Size(940, 70);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Riwayat Perubahan Status";

            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(210, 255, 255, 255);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Location = new System.Drawing.Point(22, 44);
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Rekam jejak seluruh perubahan status peminjaman";

            // ── pnlFilter ──────────────────────────────────────────────
            this.pnlFilter.BorderRadius = 16;
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(20, 100);
            this.pnlFilter.Size = new System.Drawing.Size(940, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Controls.Add(this.lblCari);
            this.pnlFilter.Controls.Add(this.txtCari);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cmbFilterStatus);
            this.pnlFilter.Controls.Add(this.lblDari);
            this.pnlFilter.Controls.Add(this.dtpDari);
            this.pnlFilter.Controls.Add(this.lblSampai);
            this.pnlFilter.Controls.Add(this.dtpSampai);
            this.pnlFilter.Controls.Add(this.btnCari);
            this.pnlFilter.Controls.Add(this.btnReset);
            this.pnlFilter.Controls.Add(this.btnExport);

            // lblCari
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCari.ForeColor = System.Drawing.Color.FromArgb(80, 80, 110);
            this.lblCari.BackColor = System.Drawing.Color.Transparent;
            this.lblCari.Location = new System.Drawing.Point(15, 12);
            this.lblCari.Name = "lblCari"; this.lblCari.Text = "Cari";

            // txtCari
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = ""; this.txtCari.SelectedText = "";
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.BorderRadius = 8;
            this.txtCari.PlaceholderText = "Kode / Nama user...";
            this.txtCari.Location = new System.Drawing.Point(15, 30);
            this.txtCari.Size = new System.Drawing.Size(180, 36);
            this.txtCari.Name = "txtCari";
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 80, 110);
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(210, 12);
            this.lblStatus.Name = "lblStatus"; this.lblStatus.Text = "Status";

            // cmbFilterStatus
            this.cmbFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.FocusedColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.cmbFilterStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterStatus.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbFilterStatus.ItemHeight = 28;
            this.cmbFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterStatus.Location = new System.Drawing.Point(210, 30);
            this.cmbFilterStatus.Size = new System.Drawing.Size(130, 36);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);

            // lblDari
            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDari.ForeColor = System.Drawing.Color.FromArgb(80, 80, 110);
            this.lblDari.BackColor = System.Drawing.Color.Transparent;
            this.lblDari.Location = new System.Drawing.Point(355, 12);
            this.lblDari.Name = "lblDari"; this.lblDari.Text = "Dari";

            // dtpDari
            this.dtpDari.Checked = true;
            this.dtpDari.FillColor = System.Drawing.Color.White;
            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDari.Location = new System.Drawing.Point(355, 30);
            this.dtpDari.Size = new System.Drawing.Size(130, 36);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDari.Value = System.DateTime.Now;
            this.dtpDari.ValueChanged += new System.EventHandler(this.dtpDari_ValueChanged);

            // lblSampai
            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSampai.ForeColor = System.Drawing.Color.FromArgb(80, 80, 110);
            this.lblSampai.BackColor = System.Drawing.Color.Transparent;
            this.lblSampai.Location = new System.Drawing.Point(500, 12);
            this.lblSampai.Name = "lblSampai"; this.lblSampai.Text = "Sampai";

            // dtpSampai
            this.dtpSampai.Checked = true;
            this.dtpSampai.FillColor = System.Drawing.Color.White;
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSampai.Location = new System.Drawing.Point(500, 30);
            this.dtpSampai.Size = new System.Drawing.Size(130, 36);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSampai.Value = System.DateTime.Now;
            this.dtpSampai.ValueChanged += new System.EventHandler(this.dtpSampai_ValueChanged);

            // btnCari
            this.btnCari.FillColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.BorderRadius = 8;
            this.btnCari.Location = new System.Drawing.Point(648, 28);
            this.btnCari.Size = new System.Drawing.Size(80, 36);
            this.btnCari.Text = "Cari";
            this.btnCari.Name = "btnCari";
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);

            // btnReset
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(150, 150, 170);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.BorderRadius = 8;
            this.btnReset.Location = new System.Drawing.Point(740, 28);
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.Text = "Reset";
            this.btnReset.Name = "btnReset";
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.UseTransparentBackground = true;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // btnExport
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(247, 148, 29);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.BorderRadius = 8;
            this.btnExport.Location = new System.Drawing.Point(835, 28);
            this.btnExport.Size = new System.Drawing.Size(90, 36);
            this.btnExport.Text = "Export CSV";
            this.btnExport.Name = "btnExport";
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.UseTransparentBackground = true;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // ── pnlGrid ────────────────────────────────────────────────
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(20, 195);
            this.pnlGrid.Size = new System.Drawing.Size(940, 490);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblJumlah);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblJumlah.BackColor = System.Drawing.Color.Transparent;
            this.lblJumlah.Location = new System.Drawing.Point(20, 15);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Text = "Total: 0 record";

            // ── guna2DataGridView1 ──────────────────────────────────────
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.guna2DataGridView1.ColumnHeadersHeight = 38;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle;
            this.guna2DataGridView1.RowTemplate.Height = 32;

            altStyle.BackColor = System.Drawing.Color.FromArgb(240, 255, 245);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 240, 228);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 42);
            this.guna2DataGridView1.Size = new System.Drawing.Size(910, 435);
            this.guna2DataGridView1.Name = "guna2DataGridView1";

            this.colNo.HeaderText        = "No";              this.colNo.Name        = "colNo";        this.colNo.ReadOnly        = true; this.colNo.FillWeight        = 5;
            this.colId.HeaderText        = "ID";              this.colId.Name        = "colId";        this.colId.ReadOnly        = true; this.colId.FillWeight        = 6;
            this.colKode.HeaderText      = "Kode Peminjaman"; this.colKode.Name      = "colKode";      this.colKode.ReadOnly      = true; this.colKode.FillWeight      = 14;
            this.colUser.HeaderText      = "Nama User";       this.colUser.Name      = "colUser";      this.colUser.ReadOnly      = true; this.colUser.FillWeight      = 18;
            this.colStatusLama.HeaderText = "Status Lama";    this.colStatusLama.Name = "colStatusLama"; this.colStatusLama.ReadOnly = true; this.colStatusLama.FillWeight = 13;
            this.colStatusBaru.HeaderText = "Status Baru";    this.colStatusBaru.Name = "colStatusBaru"; this.colStatusBaru.ReadOnly = true; this.colStatusBaru.FillWeight = 13;
            this.colWaktu.HeaderText     = "Waktu Perubahan"; this.colWaktu.Name     = "colWaktu";     this.colWaktu.ReadOnly     = true; this.colWaktu.FillWeight     = 18;
            this.colKeterangan.HeaderText = "Keterangan";     this.colKeterangan.Name = "colKeterangan"; this.colKeterangan.ReadOnly = true; this.colKeterangan.FillWeight = 13;

            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNo, this.colId, this.colKode, this.colUser,
                this.colStatusLama, this.colStatusBaru, this.colWaktu, this.colKeterangan });

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.pnlBg);
            this.Name = "FRiwayat";
            this.Text = "Riwayat Perubahan Status";
            this.Load += new System.EventHandler(this.FRiwayat_Load);

            this.pnlBg.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader, pnlFilter, pnlGrid;
        private System.Windows.Forms.Label lblTitle, lblSub, lblJumlah;
        private System.Windows.Forms.Label lblCari, lblStatus, lblDari, lblSampai;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDari, dtpSampai;
        private Guna.UI2.WinForms.Guna2Button btnCari, btnReset, btnExport;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo, colId, colKode, colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusLama, colStatusBaru, colWaktu, colKeterangan;
    }
}
