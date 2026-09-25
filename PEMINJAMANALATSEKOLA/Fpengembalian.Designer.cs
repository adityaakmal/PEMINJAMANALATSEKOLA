
namespace PEMINJAMANALATSEKOLA
{
    partial class Fpengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fpengembalian));

            // controls
            this.pnlBg               = new System.Windows.Forms.Panel();
            this.pnlHeader           = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMainTitle        = new System.Windows.Forms.Label();
            this.lblMainSub          = new System.Windows.Forms.Label();
            this.pnlForm             = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle        = new System.Windows.Forms.Label();
            this.sep                 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label4              = new System.Windows.Forms.Label();
            this.cmbkodepeminjam     = new Guna.UI2.WinForms.Guna2ComboBox();
            // info box
            this.pnlInfo             = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInfoPeminjam     = new System.Windows.Forms.Label();
            this.lblNamaPeminjam     = new System.Windows.Forms.Label();
            this.lblInfoAlat         = new System.Windows.Forms.Label();
            this.lblNamaAlat         = new System.Windows.Forms.Label();
            this.label1              = new System.Windows.Forms.Label();
            this.dtp_tgl_apengembalian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2              = new System.Windows.Forms.Label();
            this.cmbKondisialat      = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7              = new System.Windows.Forms.Label();
            this.cmbPenerima         = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6              = new System.Windows.Forms.Label();
            this.txtCatatanPengembalian = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3              = new System.Windows.Forms.Label();
            this.lblidpengembalian   = new System.Windows.Forms.Label();
            this.guna2Button1        = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update          = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrid             = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle        = new System.Windows.Forms.Label();
            this.guna2DataGridView1  = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7             = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8             = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Shapes1        = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2        = new Guna.UI2.WinForms.Guna2Shapes();

            this.pnlBg.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // hidden compat
            this.guna2Shapes1.Visible = false; this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes2.Visible = false; this.guna2Shapes2.Name = "guna2Shapes2";

            // ── pnlBg ───────────────────────────────────────────────────
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Controls.Add(this.pnlHeader);
            this.pnlBg.Controls.Add(this.pnlForm);
            this.pnlBg.Controls.Add(this.pnlGrid);
            this.pnlBg.Controls.Add(this.guna2Shapes1);
            this.pnlBg.Controls.Add(this.guna2Shapes2);

            // ── pnlHeader ───────────────────────────────────────────────
            this.pnlHeader.BorderRadius = 16;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.pnlHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlHeader.Size = new System.Drawing.Size(940, 70);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblMainTitle);
            this.pnlHeader.Controls.Add(this.lblMainSub);

            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(20, 10);
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Name = "lblMainTitle"; this.lblMainTitle.Text = "📦  Data Pengembalian";

            this.lblMainSub.AutoSize = true;
            this.lblMainSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMainSub.ForeColor = System.Drawing.Color.FromArgb(220, 255, 255, 255);
            this.lblMainSub.Location = new System.Drawing.Point(22, 44);
            this.lblMainSub.BackColor = System.Drawing.Color.Transparent;
            this.lblMainSub.Name = "lblMainSub"; this.lblMainSub.Text = "Kelola pengembalian alat — hanya meminjam berstatus Diproses";

            // ── pnlForm ─────────────────────────────────────────────────
            this.pnlForm.BorderRadius = 16;
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(20, 100);
            this.pnlForm.Size = new System.Drawing.Size(460, 600);
            this.pnlForm.Name = "pnlForm";

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Name = "lblFormTitle"; this.lblFormTitle.Text = "Form Pengembalian";

            this.sep.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.sep.FillColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.BorderColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.Location = new System.Drawing.Point(20, 42); this.sep.Size = new System.Drawing.Size(420, 2);
            this.sep.Name = "sep"; this.sep.UseTransparentBackground = true; this.sep.BackColor = System.Drawing.Color.Transparent;

            // hidden compat labels
            this.label3.AutoSize = true; this.label3.Visible = false; this.label3.Name = "label3"; this.label3.Text = " ";
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.lblidpengembalian.AutoSize = true; this.lblidpengembalian.Visible = false;
            this.lblidpengembalian.Name = "lblidpengembalian"; this.lblidpengembalian.Text = "";
            this.lblidpengembalian.Location = new System.Drawing.Point(0, 0);
            this.lblidpengembalian.BackColor = System.Drawing.Color.White;
            this.lblidpengembalian.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);

            int formY = 55; int gap = 62;

            // Kode Peminjaman
            this.label4.AutoSize = true; this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, formY); this.label4.Name = "label4"; this.label4.Text = "Kode Peminjaman";
            this.cmbkodepeminjam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbkodepeminjam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkodepeminjam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbkodepeminjam.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbkodepeminjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbkodepeminjam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbkodepeminjam.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbkodepeminjam.ItemHeight = 30; this.cmbkodepeminjam.Name = "cmbkodepeminjam";
            this.cmbkodepeminjam.BackColor = System.Drawing.Color.Transparent;
            this.cmbkodepeminjam.Location = new System.Drawing.Point(20, formY + 20);
            this.cmbkodepeminjam.Size = new System.Drawing.Size(420, 38);
            this.cmbkodepeminjam.SelectedIndexChanged += new System.EventHandler(this.cmbkodepeminjam_SelectedIndexChanged);
            formY += gap;

            // Info box (peminjam + alat names) 
            this.pnlInfo.BorderRadius = 10;
            this.pnlInfo.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.pnlInfo.Location = new System.Drawing.Point(20, formY);
            this.pnlInfo.Size = new System.Drawing.Size(420, 60);
            this.pnlInfo.Name = "pnlInfo";

            this.lblInfoPeminjam.AutoSize = true;
            this.lblInfoPeminjam.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblInfoPeminjam.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblInfoPeminjam.Location = new System.Drawing.Point(10, 8);
            this.lblInfoPeminjam.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoPeminjam.Name = "lblInfoPeminjam"; this.lblInfoPeminjam.Text = "Peminjam:";

            this.lblNamaPeminjam.AutoSize = true;
            this.lblNamaPeminjam.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNamaPeminjam.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblNamaPeminjam.Location = new System.Drawing.Point(85, 8);
            this.lblNamaPeminjam.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaPeminjam.Name = "lblNamaPeminjam"; this.lblNamaPeminjam.Text = "-";

            this.lblInfoAlat.AutoSize = true;
            this.lblInfoAlat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblInfoAlat.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblInfoAlat.Location = new System.Drawing.Point(10, 32);
            this.lblInfoAlat.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoAlat.Name = "lblInfoAlat"; this.lblInfoAlat.Text = "Alat:";

            this.lblNamaAlat.AutoSize = true;
            this.lblNamaAlat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNamaAlat.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblNamaAlat.Location = new System.Drawing.Point(85, 32);
            this.lblNamaAlat.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaAlat.Name = "lblNamaAlat"; this.lblNamaAlat.Text = "-";

            this.pnlInfo.Controls.Add(this.lblInfoPeminjam);
            this.pnlInfo.Controls.Add(this.lblNamaPeminjam);
            this.pnlInfo.Controls.Add(this.lblInfoAlat);
            this.pnlInfo.Controls.Add(this.lblNamaAlat);
            formY += 70;

            // Tgl Pengembalian
            this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, formY); this.label1.Name = "label1"; this.label1.Text = "Tanggal Pengembalian Aktual";
            this.dtp_tgl_apengembalian.Checked = true;
            this.dtp_tgl_apengembalian.FillColor = System.Drawing.Color.White;
            this.dtp_tgl_apengembalian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_tgl_apengembalian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tgl_apengembalian.Location = new System.Drawing.Point(20, formY + 20);
            this.dtp_tgl_apengembalian.Size = new System.Drawing.Size(420, 38);
            this.dtp_tgl_apengembalian.Name = "dtp_tgl_apengembalian";
            this.dtp_tgl_apengembalian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_tgl_apengembalian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_tgl_apengembalian.Value = System.DateTime.Now;
            formY += gap;

            // Kondisi Alat
            this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, formY); this.label2.Name = "label2"; this.label2.Text = "Kondisi Alat";
            this.cmbKondisialat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKondisialat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKondisialat.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbKondisialat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbKondisialat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKondisialat.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbKondisialat.ItemHeight = 30; this.cmbKondisialat.Name = "cmbKondisialat";
            this.cmbKondisialat.BackColor = System.Drawing.Color.Transparent;
            this.cmbKondisialat.Location = new System.Drawing.Point(20, formY + 20);
            this.cmbKondisialat.Size = new System.Drawing.Size(420, 38);
            formY += gap;

            // Nama Penerima
            this.label7.AutoSize = true; this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, formY); this.label7.Name = "label7"; this.label7.Text = "Nama Penerima";
            this.cmbPenerima.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPenerima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenerima.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbPenerima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbPenerima.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPenerima.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbPenerima.ItemHeight = 30; this.cmbPenerima.Name = "cmbPenerima";
            this.cmbPenerima.BackColor = System.Drawing.Color.Transparent;
            this.cmbPenerima.Location = new System.Drawing.Point(20, formY + 20);
            this.cmbPenerima.Size = new System.Drawing.Size(420, 38);
            formY += gap;

            // Catatan
            this.label6.AutoSize = true; this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, formY); this.label6.Name = "label6"; this.label6.Text = "Catatan Pengembalian";
            this.txtCatatanPengembalian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatatanPengembalian.DefaultText = ""; this.txtCatatanPengembalian.SelectedText = "";
            this.txtCatatanPengembalian.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtCatatanPengembalian.BorderRadius = 8;
            this.txtCatatanPengembalian.PlaceholderText = "Catatan tambahan...";
            this.txtCatatanPengembalian.Location = new System.Drawing.Point(20, formY + 20);
            this.txtCatatanPengembalian.Size = new System.Drawing.Size(420, 38);
            this.txtCatatanPengembalian.Name = "txtCatatanPengembalian";
            this.txtCatatanPengembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtCatatanPengembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtCatatanPengembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtCatatanPengembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtCatatanPengembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtCatatanPengembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            formY += gap;

            // Buttons
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Location = new System.Drawing.Point(20, formY + 5);
            this.guna2Button1.Size = new System.Drawing.Size(200, 42);
            this.guna2Button1.Text = "💾  Simpan"; this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent; this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.btn_update.FillColor = System.Drawing.Color.FromArgb(247, 148, 29);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.BorderRadius = 8;
            this.btn_update.Location = new System.Drawing.Point(240, formY + 5);
            this.btn_update.Size = new System.Drawing.Size(200, 42);
            this.btn_update.Text = "✏️  Update"; this.btn_update.Name = "btn_update";
            this.btn_update.BackColor = System.Drawing.Color.Transparent; this.btn_update.UseTransparentBackground = true;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);

            // add all to pnlForm
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.sep);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.cmbkodepeminjam);
            this.pnlForm.Controls.Add(this.pnlInfo);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.dtp_tgl_apengembalian);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.cmbKondisialat);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.cmbPenerima);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.txtCatatanPengembalian);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.lblidpengembalian);
            this.pnlForm.Controls.Add(this.guna2Button1);
            this.pnlForm.Controls.Add(this.btn_update);

            // ── pnlGrid ─────────────────────────────────────────────────
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(500, 100);
            this.pnlGrid.Size = new System.Drawing.Size(460, 600);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Size = new System.Drawing.Size(350, 28);
            this.lblGridTitle.Text = "Riwayat Pengembalian"; this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Name = "lblGridTitle";

            // DataGridView
            this.guna2DataGridView1.AllowUserToAddRows = false; this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.ReadOnly = true; this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;

            hdrStyle.BackColor = System.Drawing.Color.FromArgb(76, 201, 160);
            hdrStyle.ForeColor = System.Drawing.Color.White;
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            hdrStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.guna2DataGridView1.ColumnHeadersHeight = 38;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.BackColor = System.Drawing.Color.White; rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle; this.guna2DataGridView1.RowTemplate.Height = 30;
            altStyle.BackColor = System.Drawing.Color.FromArgb(240, 255, 250);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 225, 240);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 52);
            this.guna2DataGridView1.Size = new System.Drawing.Size(430, 535);
            this.guna2DataGridView1.Name = "guna2DataGridView1"; this.guna2DataGridView1.TabIndex = 50;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);

            this.Column1.HeaderText  = "ID";          this.Column1.Name  = "Column1";  this.Column1.ReadOnly  = true; this.Column1.FillWeight  = 8;
            this.Column2.HeaderText  = "Kode Pinjam"; this.Column2.Name  = "Column2";  this.Column2.ReadOnly  = true; this.Column2.FillWeight  = 12;
            this.Column6.HeaderText  = "Peminjam";    this.Column6.Name  = "Column6";  this.Column6.ReadOnly  = true; this.Column6.FillWeight  = 14;
            this.Column9.HeaderText  = "Alat";        this.Column9.Name  = "Column9";  this.Column9.ReadOnly  = true; this.Column9.FillWeight  = 13;
            this.Column3.HeaderText  = "Tgl Kembali"; this.Column3.Name  = "Column3";  this.Column3.ReadOnly  = true; this.Column3.FillWeight  = 13;
            this.Column4.HeaderText  = "Kondisi";     this.Column4.Name  = "Column4";  this.Column4.ReadOnly  = true; this.Column4.FillWeight  = 10;
            this.Column10.HeaderText = "Penerima";    this.Column10.Name = "Column10"; this.Column10.ReadOnly = true; this.Column10.FillWeight = 13;
            this.Column5.HeaderText  = "Catatan";     this.Column5.Name  = "Column5";  this.Column5.ReadOnly  = true; this.Column5.FillWeight  = 12;
            this.Column7.HeaderText  = "Edit";        this.Column7.Name  = "Column7";  this.Column7.ReadOnly  = true; this.Column7.FillWeight  = 7;
            this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
            this.Column8.HeaderText  = "Hapus";       this.Column8.Name  = "Column8";  this.Column8.ReadOnly  = true; this.Column8.FillWeight  = 7;
            this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
            this.guna2DataGridView1.Columns.AddRange(Column1, Column2, Column6, Column9, Column3, Column4, Column10, Column5, Column7, Column8);

            // ── Form ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 720);
            this.Controls.Add(this.pnlBg);
            this.Name = "Fpengembalian"; this.Text = "Pengembalian Alat";
            this.Load += new System.EventHandler(this.Fpengembalian_Load);

            this.pnlBg.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader, pnlForm, pnlGrid, pnlInfo;
        private System.Windows.Forms.Label lblMainTitle, lblMainSub, lblFormTitle, lblGridTitle;
        private Guna.UI2.WinForms.Guna2Shapes sep, guna2Shapes1, guna2Shapes2;
        private System.Windows.Forms.Label label1, label2, label3, label4, label6, label7;
        private System.Windows.Forms.Label lblInfoPeminjam, lblNamaPeminjam, lblInfoAlat, lblNamaAlat;
        private System.Windows.Forms.Label lblidpengembalian;
        private Guna.UI2.WinForms.Guna2ComboBox cmbkodepeminjam, cmbKondisialat, cmbPenerima;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_tgl_apengembalian;
        private Guna.UI2.WinForms.Guna2TextBox txtCatatanPengembalian;
        private Guna.UI2.WinForms.Guna2Button guna2Button1, btn_update;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1, Column2, Column6, Column9, Column3, Column4, Column10, Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column7, Column8;
    }
}
