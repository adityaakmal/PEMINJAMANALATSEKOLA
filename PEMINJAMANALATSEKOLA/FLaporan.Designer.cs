
namespace PEMINJAMANALATSEKOLA
{
    partial class FLaporan
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

            this.pnlBg            = new System.Windows.Forms.Panel();
            // header
            this.pnlHeader        = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.lblSub           = new System.Windows.Forms.Label();
            // summary cards row
            this.pnlCards         = new System.Windows.Forms.Panel();
            this.cardTotal        = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalNum      = new System.Windows.Forms.Label();
            this.lblTotalLbl      = new System.Windows.Forms.Label();
            this.lblTotal         = new System.Windows.Forms.Label();
            this.cardMenunggu     = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMenungguLbl   = new System.Windows.Forms.Label();
            this.lblMenunggu      = new System.Windows.Forms.Label();
            this.cardDiproses     = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiprosesLbl   = new System.Windows.Forms.Label();
            this.lblDiproses      = new System.Windows.Forms.Label();
            this.cardSelesai      = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelesaiLbl    = new System.Windows.Forms.Label();
            this.lblSelesai       = new System.Windows.Forms.Label();
            this.cardDitolak      = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDitolakLbl    = new System.Windows.Forms.Label();
            this.lblDitolak       = new System.Windows.Forms.Label();
            // filter bar
            this.pnlFilter        = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCari          = new System.Windows.Forms.Label();
            this.txtCari          = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus        = new System.Windows.Forms.Label();
            this.cmbFilterStatus  = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblApproval      = new System.Windows.Forms.Label();
            this.cmbFilterApproval = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDari          = new System.Windows.Forms.Label();
            this.dtpDari          = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSampai        = new System.Windows.Forms.Label();
            this.dtpSampai        = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCari          = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset         = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportCSV     = new Guna.UI2.WinForms.Guna2Button();
            // grid
            this.pnlGrid          = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJumlah        = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNo            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKode          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeminjam      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlat          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumlah        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglPinjam     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglRencana    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusPeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusApproval   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglApproval      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglAktual        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKondisi          = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlBg.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // ── pnlBg ──────────────────────────────────────────────────
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Controls.Add(this.pnlHeader);
            this.pnlBg.Controls.Add(this.pnlCards);
            this.pnlBg.Controls.Add(this.pnlFilter);
            this.pnlBg.Controls.Add(this.pnlGrid);

            // ── pnlHeader ──────────────────────────────────────────────
            this.pnlHeader.BorderRadius = 16;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
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
            this.lblTitle.Text = "Laporan Peminjaman Alat";

            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Location = new System.Drawing.Point(22, 44);
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Rekap lengkap seluruh transaksi peminjaman, persetujuan, dan pengembalian";

            // ── pnlCards (summary) ─────────────────────────────────────
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Location = new System.Drawing.Point(20, 100);
            this.pnlCards.Size = new System.Drawing.Size(940, 90);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Controls.Add(this.cardTotal);
            this.pnlCards.Controls.Add(this.cardMenunggu);
            this.pnlCards.Controls.Add(this.cardDiproses);
            this.pnlCards.Controls.Add(this.cardSelesai);
            this.pnlCards.Controls.Add(this.cardDitolak);

            // helper inline: build a small summary card
            int cx = 0; int cw = 175; int ch = 80;
            System.Drawing.Color[] clrs = new System.Drawing.Color[] {
                System.Drawing.Color.FromArgb(67, 97, 238),
                System.Drawing.Color.FromArgb(247, 148, 29),
                System.Drawing.Color.FromArgb(114, 9, 183),
                System.Drawing.Color.FromArgb(39, 174, 96),
                System.Drawing.Color.FromArgb(231, 76, 60)
            };
            Guna.UI2.WinForms.Guna2Panel[] cards   = { cardTotal, cardMenunggu, cardDiproses, cardSelesai, cardDitolak };
            System.Windows.Forms.Label[]   lblNums  = { lblTotal, lblMenunggu, lblDiproses, lblSelesai, lblDitolak };
            System.Windows.Forms.Label[]   lblLbls  = { lblTotalLbl, lblMenungguLbl, lblDiprosesLbl, lblSelesaiLbl, lblDitolakLbl };
            string[]                        texts    = { "Total", "Menunggu", "Diproses", "Selesai", "Ditolak" };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].BorderRadius = 12;
                cards[i].FillColor = clrs[i];
                cards[i].Location = new System.Drawing.Point(cx, 5);
                cards[i].Size = new System.Drawing.Size(cw, ch);

                lblNums[i].Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
                lblNums[i].ForeColor = System.Drawing.Color.White;
                lblNums[i].BackColor = System.Drawing.Color.Transparent;
                lblNums[i].Location = new System.Drawing.Point(15, 10);
                lblNums[i].Size = new System.Drawing.Size(cw - 20, 38);
                lblNums[i].Text = "0";
                lblNums[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                lblLbls[i].Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                lblLbls[i].ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
                lblLbls[i].BackColor = System.Drawing.Color.Transparent;
                lblLbls[i].Location = new System.Drawing.Point(15, 54);
                lblLbls[i].Size = new System.Drawing.Size(cw - 20, 18);
                lblLbls[i].Text = texts[i];

                cards[i].Controls.Add(lblNums[i]);
                cards[i].Controls.Add(lblLbls[i]);
                cx += cw + 10;
            }

            // hidden lblTotalNum compat
            this.lblTotalNum.Visible = false; this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Location = new System.Drawing.Point(0, 0);

            // ── pnlFilter ──────────────────────────────────────────────
            this.pnlFilter.BorderRadius = 16;
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(20, 205);
            this.pnlFilter.Size = new System.Drawing.Size(940, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Controls.Add(this.lblCari);
            this.pnlFilter.Controls.Add(this.txtCari);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cmbFilterStatus);
            this.pnlFilter.Controls.Add(this.lblApproval);
            this.pnlFilter.Controls.Add(this.cmbFilterApproval);
            this.pnlFilter.Controls.Add(this.lblDari);
            this.pnlFilter.Controls.Add(this.dtpDari);
            this.pnlFilter.Controls.Add(this.lblSampai);
            this.pnlFilter.Controls.Add(this.dtpSampai);
            this.pnlFilter.Controls.Add(this.btnCari);
            this.pnlFilter.Controls.Add(this.btnReset);
            this.pnlFilter.Controls.Add(this.btnExportCSV);

            // filter controls - label style helper
            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 110);

            this.lblCari.AutoSize = true; this.lblCari.Font = lblFont; this.lblCari.ForeColor = lblColor;
            this.lblCari.BackColor = System.Drawing.Color.Transparent; this.lblCari.Name = "lblCari";
            this.lblCari.Location = new System.Drawing.Point(15, 12); this.lblCari.Text = "Cari";

            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam; this.txtCari.DefaultText = ""; this.txtCari.SelectedText = "";
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F); this.txtCari.BorderRadius = 8;
            this.txtCari.PlaceholderText = "Kode / Nama peminjam / Alat...";
            this.txtCari.Location = new System.Drawing.Point(15, 30); this.txtCari.Size = new System.Drawing.Size(180, 36);
            this.txtCari.Name = "txtCari";
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);

            this.lblStatus.AutoSize = true; this.lblStatus.Font = lblFont; this.lblStatus.ForeColor = lblColor;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent; this.lblStatus.Name = "lblStatus";
            this.lblStatus.Location = new System.Drawing.Point(210, 12); this.lblStatus.Text = "Status Peminjaman";

            this.cmbFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbFilterStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterStatus.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbFilterStatus.ItemHeight = 28; this.cmbFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterStatus.Location = new System.Drawing.Point(210, 30); this.cmbFilterStatus.Size = new System.Drawing.Size(130, 36);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);

            this.lblApproval.AutoSize = true; this.lblApproval.Font = lblFont; this.lblApproval.ForeColor = lblColor;
            this.lblApproval.BackColor = System.Drawing.Color.Transparent; this.lblApproval.Name = "lblApproval";
            this.lblApproval.Location = new System.Drawing.Point(355, 12); this.lblApproval.Text = "Status Approval";

            this.cmbFilterApproval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterApproval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterApproval.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbFilterApproval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbFilterApproval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterApproval.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbFilterApproval.ItemHeight = 28; this.cmbFilterApproval.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterApproval.Location = new System.Drawing.Point(355, 30); this.cmbFilterApproval.Size = new System.Drawing.Size(120, 36);
            this.cmbFilterApproval.Name = "cmbFilterApproval";
            this.cmbFilterApproval.SelectedIndexChanged += new System.EventHandler(this.cmbFilterApproval_SelectedIndexChanged);

            this.lblDari.AutoSize = true; this.lblDari.Font = lblFont; this.lblDari.ForeColor = lblColor;
            this.lblDari.BackColor = System.Drawing.Color.Transparent; this.lblDari.Name = "lblDari";
            this.lblDari.Location = new System.Drawing.Point(490, 12); this.lblDari.Text = "Dari";

            this.dtpDari.Checked = true; this.dtpDari.FillColor = System.Drawing.Color.White;
            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDari.Location = new System.Drawing.Point(490, 30); this.dtpDari.Size = new System.Drawing.Size(120, 36);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDari.Value = System.DateTime.Now;
            this.dtpDari.ValueChanged += new System.EventHandler(this.dtpDari_ValueChanged);

            this.lblSampai.AutoSize = true; this.lblSampai.Font = lblFont; this.lblSampai.ForeColor = lblColor;
            this.lblSampai.BackColor = System.Drawing.Color.Transparent; this.lblSampai.Name = "lblSampai";
            this.lblSampai.Location = new System.Drawing.Point(625, 12); this.lblSampai.Text = "Sampai";

            this.dtpSampai.Checked = true; this.dtpSampai.FillColor = System.Drawing.Color.White;
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSampai.Location = new System.Drawing.Point(625, 30); this.dtpSampai.Size = new System.Drawing.Size(120, 36);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSampai.Value = System.DateTime.Now;
            this.dtpSampai.ValueChanged += new System.EventHandler(this.dtpSampai_ValueChanged);

            this.btnCari.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.BorderRadius = 8; this.btnCari.Name = "btnCari";
            this.btnCari.Location = new System.Drawing.Point(760, 28); this.btnCari.Size = new System.Drawing.Size(70, 36);
            this.btnCari.Text = "Cari"; this.btnCari.BackColor = System.Drawing.Color.Transparent; this.btnCari.UseTransparentBackground = true;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray; this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169); this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);

            this.btnReset.FillColor = System.Drawing.Color.FromArgb(150, 150, 170);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.BorderRadius = 8; this.btnReset.Name = "btnReset";
            this.btnReset.Location = new System.Drawing.Point(840, 28); this.btnReset.Size = new System.Drawing.Size(70, 36);
            this.btnReset.Text = "Reset"; this.btnReset.BackColor = System.Drawing.Color.Transparent; this.btnReset.UseTransparentBackground = true;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray; this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169); this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnExportCSV.FillColor = System.Drawing.Color.FromArgb(247, 148, 29);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.BorderRadius = 8; this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Location = new System.Drawing.Point(828, 28); // repositioned below
            this.btnExportCSV.Location = new System.Drawing.Point(756, 28);
            this.btnExportCSV.Location = new System.Drawing.Point(740, 28);
            // final position — put export at far right
            this.btnReset.Location    = new System.Drawing.Point(755, 28); this.btnReset.Size    = new System.Drawing.Size(65, 36);
            this.btnCari.Location     = new System.Drawing.Point(680, 28); this.btnCari.Size     = new System.Drawing.Size(65, 36);
            this.btnExportCSV.Location = new System.Drawing.Point(830, 28); this.btnExportCSV.Size = new System.Drawing.Size(95, 36);
            this.btnExportCSV.Text = "Export CSV"; this.btnExportCSV.BackColor = System.Drawing.Color.Transparent; this.btnExportCSV.UseTransparentBackground = true;
            this.btnExportCSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray; this.btnExportCSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportCSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169); this.btnExportCSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            // ── pnlGrid ────────────────────────────────────────────────
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(20, 300);
            this.pnlGrid.Size = new System.Drawing.Size(940, 420);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblJumlah);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblJumlah.BackColor = System.Drawing.Color.Transparent;
            this.lblJumlah.Location = new System.Drawing.Point(20, 12);
            this.lblJumlah.Name = "lblJumlah"; this.lblJumlah.Text = "Total: 0 record";

            // DataGridView
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.guna2DataGridView1.ColumnHeadersHeight = 38;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle;
            this.guna2DataGridView1.RowTemplate.Height = 30;

            altStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 255);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 225, 240);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 40);
            this.guna2DataGridView1.Size = new System.Drawing.Size(910, 368);
            this.guna2DataGridView1.Name = "guna2DataGridView1";

            this.colNo.HeaderText             = "No";               this.colNo.Name             = "colNo";             this.colNo.ReadOnly             = true; this.colNo.FillWeight             = 4;
            this.colKode.HeaderText            = "Kode";             this.colKode.Name            = "colKode";            this.colKode.ReadOnly            = true; this.colKode.FillWeight            = 9;
            this.colPeminjam.HeaderText        = "Peminjam";         this.colPeminjam.Name        = "colPeminjam";        this.colPeminjam.ReadOnly        = true; this.colPeminjam.FillWeight        = 12;
            this.colAlat.HeaderText            = "Alat";             this.colAlat.Name            = "colAlat";            this.colAlat.ReadOnly            = true; this.colAlat.FillWeight            = 11;
            this.colJumlah.HeaderText          = "Jml";              this.colJumlah.Name          = "colJumlah";          this.colJumlah.ReadOnly          = true; this.colJumlah.FillWeight          = 5;
            this.colTglPinjam.HeaderText       = "Tgl Pinjam";       this.colTglPinjam.Name       = "colTglPinjam";       this.colTglPinjam.ReadOnly       = true; this.colTglPinjam.FillWeight       = 9;
            this.colTglRencana.HeaderText      = "Tgl Kembali";      this.colTglRencana.Name      = "colTglRencana";      this.colTglRencana.ReadOnly      = true; this.colTglRencana.FillWeight      = 9;
            this.colStatusPeminjaman.HeaderText = "Status Pinjam";   this.colStatusPeminjaman.Name = "colStatusPeminjaman"; this.colStatusPeminjaman.ReadOnly = true; this.colStatusPeminjaman.FillWeight = 10;
            this.colStatusApproval.HeaderText  = "Approval";         this.colStatusApproval.Name  = "colStatusApproval";  this.colStatusApproval.ReadOnly  = true; this.colStatusApproval.FillWeight  = 9;
            this.colTglApproval.HeaderText     = "Tgl Approval";     this.colTglApproval.Name     = "colTglApproval";     this.colTglApproval.ReadOnly     = true; this.colTglApproval.FillWeight     = 10;
            this.colTglAktual.HeaderText       = "Tgl Kembali Aktual"; this.colTglAktual.Name     = "colTglAktual";       this.colTglAktual.ReadOnly       = true; this.colTglAktual.FillWeight       = 10;
            this.colKondisi.HeaderText         = "Kondisi";           this.colKondisi.Name         = "colKondisi";         this.colKondisi.ReadOnly         = true; this.colKondisi.FillWeight         = 8;

            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNo, this.colKode, this.colPeminjam, this.colAlat, this.colJumlah,
                this.colTglPinjam, this.colTglRencana, this.colStatusPeminjaman,
                this.colStatusApproval, this.colTglApproval, this.colTglAktual, this.colKondisi });

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 740);
            this.Controls.Add(this.pnlBg);
            this.Name = "FLaporan";
            this.Text = "Laporan Peminjaman";
            this.Load += new System.EventHandler(this.FLaporan_Load);

            this.pnlBg.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader, pnlFilter, pnlGrid;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Label lblTitle, lblSub, lblJumlah;
        // summary cards
        private Guna.UI2.WinForms.Guna2Panel cardTotal, cardMenunggu, cardDiproses, cardSelesai, cardDitolak;
        private System.Windows.Forms.Label lblTotalNum, lblTotalLbl, lblTotal;
        private System.Windows.Forms.Label lblMenungguLbl, lblMenunggu;
        private System.Windows.Forms.Label lblDiprosesLbl, lblDiproses;
        private System.Windows.Forms.Label lblSelesaiLbl, lblSelesai;
        private System.Windows.Forms.Label lblDitolakLbl, lblDitolak;
        // filter
        private System.Windows.Forms.Label lblCari, lblStatus, lblApproval, lblDari, lblSampai;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterStatus, cmbFilterApproval;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDari, dtpSampai;
        private Guna.UI2.WinForms.Guna2Button btnCari, btnReset, btnExportCSV;
        // grid
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo, colKode, colPeminjam, colAlat, colJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglPinjam, colTglRencana;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusPeminjaman, colStatusApproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglApproval, colTglAktual, colKondisi;
    }
}
