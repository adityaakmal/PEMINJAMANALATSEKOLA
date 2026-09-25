
namespace PEMINJAMANALATSEKOLA
{
    partial class FKategoriAlat
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
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKategoriAlat));

            this.pnlBg           = new System.Windows.Forms.Panel();
            this.pnlForm         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.lblSub          = new System.Windows.Forms.Label();
            this.sep             = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1          = new System.Windows.Forms.Label();
            this.txtIDKategori   = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3          = new System.Windows.Forms.Label();
            this.txtnamakategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2          = new System.Windows.Forms.Label();
            this.txtketerangan   = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4          = new System.Windows.Forms.Label();
            this.guna2Button1    = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2    = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrid         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle    = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3         = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4         = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Shapes1    = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2    = new Guna.UI2.WinForms.Guna2Shapes();

            this.pnlBg.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // pnlBg
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Controls.Add(this.pnlForm);
            this.pnlBg.Controls.Add(this.pnlGrid);

            // pnlForm
            this.pnlForm.BorderRadius = 16;
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(20, 20);
            this.pnlForm.Size = new System.Drawing.Size(340, 500);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblTitle);
            this.pnlForm.Controls.Add(this.lblSub);
            this.pnlForm.Controls.Add(this.sep);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.txtIDKategori);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.txtnamakategori);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.txtketerangan);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.guna2Button1);
            this.pnlForm.Controls.Add(this.guna2Button2);
            this.pnlForm.Controls.Add(this.guna2Shapes1);
            this.pnlForm.Controls.Add(this.guna2Shapes2);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "Kategori Alat";

            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(130, 130, 160);
            this.lblSub.Location = new System.Drawing.Point(20, 50);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Name = "lblSub"; this.lblSub.Text = "Kelola kategori peralatan";

            // sep
            this.sep.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.sep.FillColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.BorderColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.sep.Location = new System.Drawing.Point(20, 76); this.sep.Size = new System.Drawing.Size(300, 2);
            this.sep.Name = "sep"; this.sep.UseTransparentBackground = true; this.sep.BackColor = System.Drawing.Color.Transparent;

            // hidden compat
            this.guna2Shapes1.Visible = false; this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes2.Visible = false; this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.Click += new System.EventHandler(this.guna2Shapes2_Click);

            int y = 92; int gap = 68;

            // label1, txtIDKategori
            this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, y); this.label1.Name = "label1"; this.label1.Text = "ID Kategori";
            this.txtIDKategori.Cursor = System.Windows.Forms.Cursors.IBeam; this.txtIDKategori.DefaultText = ""; this.txtIDKategori.SelectedText = "";
            this.txtIDKategori.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtIDKategori.BorderRadius = 8;
            this.txtIDKategori.PlaceholderText = "Masukkan ID Kategori...";
            this.txtIDKategori.Location = new System.Drawing.Point(20, y + 20); this.txtIDKategori.Size = new System.Drawing.Size(300, 38);
            this.txtIDKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtIDKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtIDKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtIDKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtIDKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtIDKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtIDKategori.Name = "txtIDKategori";
            this.txtIDKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDKategori_KeyPress);
            y += gap;

            // label3, txtnamakategori
            this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, y); this.label3.Name = "label3"; this.label3.Text = "Nama Kategori";
            this.txtnamakategori.Cursor = System.Windows.Forms.Cursors.IBeam; this.txtnamakategori.DefaultText = ""; this.txtnamakategori.SelectedText = "";
            this.txtnamakategori.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtnamakategori.BorderRadius = 8;
            this.txtnamakategori.PlaceholderText = "Masukkan Nama Kategori...";
            this.txtnamakategori.Location = new System.Drawing.Point(20, y + 20); this.txtnamakategori.Size = new System.Drawing.Size(300, 38);
            this.txtnamakategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtnamakategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtnamakategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtnamakategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtnamakategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtnamakategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtnamakategori.Name = "txtnamakategori";
            y += gap;

            // label2, txtketerangan
            this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100); this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, y); this.label2.Name = "label2"; this.label2.Text = "Keterangan";
            this.txtketerangan.Cursor = System.Windows.Forms.Cursors.IBeam; this.txtketerangan.DefaultText = ""; this.txtketerangan.SelectedText = "";
            this.txtketerangan.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtketerangan.BorderRadius = 8;
            this.txtketerangan.PlaceholderText = "Masukkan Keterangan...";
            this.txtketerangan.Location = new System.Drawing.Point(20, y + 20); this.txtketerangan.Size = new System.Drawing.Size(300, 38);
            this.txtketerangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtketerangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtketerangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtketerangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtketerangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtketerangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtketerangan.Name = "txtketerangan";
            y += gap;

            // label4 hidden ID holder
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Visible = false; this.label4.Name = "label4"; this.label4.Text = "ID";
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);

            // Buttons
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Location = new System.Drawing.Point(20, y + 5);
            this.guna2Button1.Size = new System.Drawing.Size(140, 40);
            this.guna2Button1.Text = "💾  Simpan"; this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent; this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Location = new System.Drawing.Point(180, y + 5);
            this.guna2Button2.Size = new System.Drawing.Size(140, 40);
            this.guna2Button2.Text = "✏️  Update"; this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent; this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);

            // pnlGrid
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(380, 20);
            this.pnlGrid.Size = new System.Drawing.Size(580, 500);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Size = new System.Drawing.Size(300, 28);
            this.lblGridTitle.Text = "Daftar Kategori"; this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Name = "lblGridTitle";

            // DataGridView
            this.guna2DataGridView1.AllowUserToAddRows = false; this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.ReadOnly = true; this.guna2DataGridView1.RowHeadersVisible = false;
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

            rowStyle.BackColor = System.Drawing.Color.White; rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle; this.guna2DataGridView1.RowTemplate.Height = 32;
            altStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 255);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 225, 240);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 52);
            this.guna2DataGridView1.Size = new System.Drawing.Size(550, 435);
            this.guna2DataGridView1.Name = "guna2DataGridView1"; this.guna2DataGridView1.TabIndex = 11;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);

            this.Column1.HeaderText = "ID Kategori";    this.Column1.Name = "Column1"; this.Column1.ReadOnly = true; this.Column1.FillWeight = 20;
            this.Column2.HeaderText = "Nama Kategori";  this.Column2.Name = "Column2"; this.Column2.ReadOnly = true; this.Column2.FillWeight = 30;
            this.Column5.HeaderText = "Keterangan";     this.Column5.Name = "Column5"; this.Column5.ReadOnly = true; this.Column5.FillWeight = 35;
            this.Column3.HeaderText = "Edit";            this.Column3.Name = "Column3"; this.Column3.ReadOnly = true; this.Column3.FillWeight = 8;
            this.Column3.Image = ((System.Drawing.Image)(resources.GetObject("Column3.Image")));
            this.Column4.HeaderText = "Hapus";           this.Column4.Name = "Column4"; this.Column4.ReadOnly = true; this.Column4.FillWeight = 8;
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.guna2DataGridView1.Columns.AddRange(Column1, Column2, Column5, Column3, Column4);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 540);
            this.Controls.Add(this.pnlBg);
            this.Name = "FKategoriAlat"; this.Text = "Kategori Alat";

            this.pnlBg.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblTitle, lblSub;
        private Guna.UI2.WinForms.Guna2Shapes sep, guna2Shapes1, guna2Shapes2;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private Guna.UI2.WinForms.Guna2TextBox txtIDKategori, txtnamakategori, txtketerangan;
        private Guna.UI2.WinForms.Guna2Button guna2Button1, guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1, Column2, Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column3, Column4;
    }
}
