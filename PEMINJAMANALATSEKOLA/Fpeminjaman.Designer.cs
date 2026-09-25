
namespace PEMINJAMANALATSEKOLA
{
    partial class Fpeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fpeminjaman));

            this.guna2Shapes1        = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2        = new Guna.UI2.WinForms.Guna2Shapes();
            this.pnlBg               = new System.Windows.Forms.Panel();
            this.pnlHeader           = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle            = new System.Windows.Forms.Label();
            this.lblSub              = new System.Windows.Forms.Label();
            this.pnlForm             = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle        = new System.Windows.Forms.Label();
            this.sep                 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label5              = new System.Windows.Forms.Label();
            this.txtKodePeminjaman   = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1              = new System.Windows.Forms.Label();
            this.cmbuser             = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2              = new System.Windows.Forms.Label();
            this.cmbalat             = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7              = new System.Windows.Forms.Label();
            this.txtJumlah           = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6              = new System.Windows.Forms.Label();
            this.txtKeterangan       = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3              = new System.Windows.Forms.Label();
            this.dtpTanggalPinjam    = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8              = new System.Windows.Forms.Label();
            this.dtpTanggalKembali   = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4              = new System.Windows.Forms.Label();
            this.guna2Button1        = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update          = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrid             = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle        = new System.Windows.Forms.Label();
            this.guna2DataGridView1  = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7             = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8             = new System.Windows.Forms.DataGridViewImageColumn();

            this.pnlBg.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // hidden compat shapes
            this.guna2Shapes1.Visible = false; this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.Click += new System.EventHandler(this.guna2Shapes1_Click);
            this.guna2Shapes2.Visible = false; this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.Click += new System.EventHandler(this.guna2Shapes2_Click);

            // ── pnlBg ──
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Controls.Add(this.pnlHeader);
            this.pnlBg.Controls.Add(this.pnlForm);
            this.pnlBg.Controls.Add(this.pnlGrid);
            this.pnlBg.Controls.Add(this.guna2Shapes1);
            this.pnlBg.Controls.Add(this.guna2Shapes2);

            // ── pnlHeader ──
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
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Data Peminjaman";

            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            this.lblSub.Location = new System.Drawing.Point(22, 44);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Kelola transaksi peminjaman alat sekolah";

            // ── pnlForm ──
            this.pnlForm.BorderRadius = 16;
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(20, 100);
            this.pnlForm.Size = new System.Drawing.Size(460, 560);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.sep);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.txtKodePeminjaman);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.cmbuser);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.cmbalat);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.txtJumlah);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.txtKeterangan);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.dtpTanggalPinjam);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.dtpTanggalKembali);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.guna2Button1);
            this.pnlForm.Controls.Add(this.btn_update);

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Text = "Form Input Peminjaman";

            this.sep.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.sep.FillColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.BorderColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.Location = new System.Drawing.Point(20, 42);
            this.sep.Size = new System.Drawing.Size(420, 2);
            this.sep.Name = "sep";
            this.sep.UseTransparentBackground = true;
            this.sep.BackColor = System.Drawing.Color.Transparent;

            // label4 hidden compat
            this.label4.AutoSize = true; this.label4.Visible = false; this.label4.Name = "label4";
            this.label4.Text = " "; this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Click += new System.EventHandler(this.label4_Click);

            // ── Row 1: Kode Peminjaman ──
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 55);
            this.label5.Name = "label5"; this.label5.Text = "Kode Peminjaman";
            this.label5.Click += new System.EventHandler(this.label5_Click);

            this.txtKodePeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKodePeminjaman.DefaultText = ""; this.txtKodePeminjaman.SelectedText = "";
            this.txtKodePeminjaman.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtKodePeminjaman.BorderRadius = 8;
            this.txtKodePeminjaman.PlaceholderText = "Auto-generate...";
            this.txtKodePeminjaman.Location = new System.Drawing.Point(20, 75); this.txtKodePeminjaman.Size = new System.Drawing.Size(420, 38);
            this.txtKodePeminjaman.Name = "txtKodePeminjaman";
            this.txtKodePeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtKodePeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtKodePeminjaman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtKodePeminjaman.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtKodePeminjaman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtKodePeminjaman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtKodePeminjaman.TextChanged += new System.EventHandler(this.txtKodePeminjaman_TextChanged);

            // ── Row 2: Nama Peminjam ──
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1"; this.label1.Text = "Nama Peminjam";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            this.cmbuser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbuser.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbuser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbuser.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbuser.ItemHeight = 30; this.cmbuser.Name = "cmbuser"; this.cmbuser.BackColor = System.Drawing.Color.Transparent;
            this.cmbuser.Location = new System.Drawing.Point(20, 140); this.cmbuser.Size = new System.Drawing.Size(420, 38);
            this.cmbuser.SelectedIndexChanged += new System.EventHandler(this.cmbuser_SelectedIndexChanged);

            // ── Row 3: Nama Alat ──
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 185);
            this.label2.Name = "label2"; this.label2.Text = "Nama Alat";
            this.label2.Click += new System.EventHandler(this.label2_Click);

            this.cmbalat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbalat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbalat.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbalat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbalat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbalat.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbalat.ItemHeight = 30; this.cmbalat.Name = "cmbalat"; this.cmbalat.BackColor = System.Drawing.Color.Transparent;
            this.cmbalat.Location = new System.Drawing.Point(20, 205); this.cmbalat.Size = new System.Drawing.Size(420, 38);
            this.cmbalat.SelectedIndexChanged += new System.EventHandler(this.cmbalat_SelectedIndexChanged);

            // ── Row 4: Jumlah ──
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 250);
            this.label7.Name = "label7"; this.label7.Text = "Jumlah";
            this.label7.Click += new System.EventHandler(this.label7_Click);

            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = ""; this.txtJumlah.SelectedText = "";
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtJumlah.BorderRadius = 8;
            this.txtJumlah.PlaceholderText = "Jumlah alat...";
            this.txtJumlah.Location = new System.Drawing.Point(20, 270); this.txtJumlah.Size = new System.Drawing.Size(420, 38);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);

            // ── Row 5: Keterangan ──
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 315);
            this.label6.Name = "label6"; this.label6.Text = "Keterangan";
            this.label6.Click += new System.EventHandler(this.label6_Click);

            this.txtKeterangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeterangan.DefaultText = ""; this.txtKeterangan.SelectedText = "";
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtKeterangan.BorderRadius = 8;
            this.txtKeterangan.PlaceholderText = "Keterangan tambahan...";
            this.txtKeterangan.Location = new System.Drawing.Point(20, 335); this.txtKeterangan.Size = new System.Drawing.Size(420, 38);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtKeterangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtKeterangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtKeterangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtKeterangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtKeterangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtKeterangan.TextChanged += new System.EventHandler(this.txtKeterangan_TextChanged);

            // ── Row 6: Tanggal Pinjam (kiri) + Tanggal Kembali (kanan) ──
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 380);
            this.label3.Name = "label3"; this.label3.Text = "Tgl Pinjam";

            this.dtpTanggalPinjam.Checked = true;
            this.dtpTanggalPinjam.FillColor = System.Drawing.Color.White;
            this.dtpTanggalPinjam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTanggalPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalPinjam.Location = new System.Drawing.Point(20, 400);
            this.dtpTanggalPinjam.Size = new System.Drawing.Size(195, 38);
            this.dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            this.dtpTanggalPinjam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalPinjam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalPinjam.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalPinjam.ValueChanged += new System.EventHandler(this.dtpTanggalPinjam_ValueChanged);

            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(230, 380);
            this.label8.Name = "label8"; this.label8.Text = "Tgl Kembali (Rencana)";
            this.label8.Click += new System.EventHandler(this.label8_Click);

            this.dtpTanggalKembali.Checked = true;
            this.dtpTanggalKembali.FillColor = System.Drawing.Color.White;
            this.dtpTanggalKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTanggalKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalKembali.Location = new System.Drawing.Point(230, 400);
            this.dtpTanggalKembali.Size = new System.Drawing.Size(210, 38);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalKembali.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalKembali.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalKembali.ValueChanged += new System.EventHandler(this.dtpTanggalKembali_ValueChanged);

            // ── Buttons ──
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Location = new System.Drawing.Point(20, 455);
            this.guna2Button1.Size = new System.Drawing.Size(200, 42);
            this.guna2Button1.Text = "Simpan"; this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent; this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.btn_update.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.BorderRadius = 8;
            this.btn_update.Location = new System.Drawing.Point(240, 455);
            this.btn_update.Size = new System.Drawing.Size(200, 42);
            this.btn_update.Text = "Update"; this.btn_update.Name = "btn_update";
            this.btn_update.BackColor = System.Drawing.Color.Transparent; this.btn_update.UseTransparentBackground = true;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);

            // ── pnlGrid ──
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(500, 100);
            this.pnlGrid.Size = new System.Drawing.Size(460, 560);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Size = new System.Drawing.Size(350, 28);
            this.lblGridTitle.Text = "Riwayat Peminjaman";
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Name = "lblGridTitle";

            // ── DataGridView ──
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

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 52);
            this.guna2DataGridView1.Size = new System.Drawing.Size(430, 495);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.TabIndex = 17;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);

            this.Column1.HeaderText  = "Kode";        this.Column1.Name  = "Column1";  this.Column1.ReadOnly  = true; this.Column1.FillWeight  = 12;
            this.Column2.HeaderText  = "Peminjam";    this.Column2.Name  = "Column2";  this.Column2.ReadOnly  = true; this.Column2.FillWeight  = 16;
            this.Column3.HeaderText  = "Alat";        this.Column3.Name  = "Column3";  this.Column3.ReadOnly  = true; this.Column3.FillWeight  = 15;
            this.Column4.HeaderText  = "Jml";         this.Column4.Name  = "Column4";  this.Column4.ReadOnly  = true; this.Column4.FillWeight  = 6;
            this.Column10.HeaderText = "Ket.";        this.Column10.Name = "Column10"; this.Column10.ReadOnly = true; this.Column10.FillWeight = 12;
            this.Column5.HeaderText  = "Tgl Pinjam";  this.Column5.Name  = "Column5";  this.Column5.ReadOnly  = true; this.Column5.FillWeight  = 13;
            this.Column6.HeaderText  = "Tgl Kembali"; this.Column6.Name  = "Column6";  this.Column6.ReadOnly  = true; this.Column6.FillWeight  = 13;
            this.Column9.HeaderText  = "Status";      this.Column9.Name  = "Column9";  this.Column9.ReadOnly  = true; this.Column9.FillWeight  = 10;
            this.Column7.HeaderText  = "Edit";        this.Column7.Name  = "Column7";  this.Column7.ReadOnly  = true; this.Column7.FillWeight  = 7;
            this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
            this.Column8.HeaderText  = "Hapus";       this.Column8.Name  = "Column8";  this.Column8.ReadOnly  = true; this.Column8.FillWeight  = 7;
            this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column1, this.Column2, this.Column3, this.Column4, this.Column10,
                this.Column5, this.Column6, this.Column9, this.Column7, this.Column8 });

            // ── Form ──
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.pnlBg);
            this.Name = "Fpeminjaman";
            this.Text = "Peminjaman Alat";
            this.Load += new System.EventHandler(this.Fpeminjaman_Load);

            this.pnlBg.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1, guna2Shapes2, sep;
        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader, pnlForm, pnlGrid;
        private System.Windows.Forms.Label lblTitle, lblSub, lblFormTitle, lblGridTitle;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8;
        private Guna.UI2.WinForms.Guna2TextBox txtKodePeminjaman, txtJumlah, txtKeterangan;
        private Guna.UI2.WinForms.Guna2ComboBox cmbuser, cmbalat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggalPinjam, dtpTanggalKembali;
        private Guna.UI2.WinForms.Guna2Button guna2Button1, btn_update;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1, Column2, Column3, Column4, Column10, Column5, Column6, Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column7, Column8;
    }
}
