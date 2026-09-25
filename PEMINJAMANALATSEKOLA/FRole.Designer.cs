
namespace PEMINJAMANALATSEKOLA
{
    partial class FRole
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRole));

            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlBg           = new System.Windows.Forms.Panel();
            this.pnlForm         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.lblSub          = new System.Windows.Forms.Label();
            this.separator       = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1          = new System.Windows.Forms.Label();
            this.txtID           = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4          = new System.Windows.Forms.Label();
            this.txtRole         = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1    = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2    = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrid         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle    = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3         = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4         = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2          = new System.Windows.Forms.Label();
            this.label3          = new System.Windows.Forms.Label();

            this.pnlBg.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();

            // pnlBg
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Controls.Add(this.pnlForm);
            this.pnlBg.Controls.Add(this.pnlGrid);
            this.pnlBg.Name = "pnlBg";

            // pnlForm (left card)
            this.pnlForm.BorderRadius = 16;
            this.pnlForm.FillColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(20, 20);
            this.pnlForm.Size = new System.Drawing.Size(320, 400);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblTitle);
            this.pnlForm.Controls.Add(this.lblSub);
            this.pnlForm.Controls.Add(this.separator);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.txtID);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.txtRole);
            this.pnlForm.Controls.Add(this.guna2Button1);
            this.pnlForm.Controls.Add(this.guna2Button2);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label3);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Data Role";

            // lblSub
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(130, 130, 160);
            this.lblSub.Location = new System.Drawing.Point(20, 48);
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Name = "lblSub";
            this.lblSub.Text = "Kelola data role pengguna";

            // separator
            this.separator.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.separator.FillColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.separator.BorderColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.separator.Location = new System.Drawing.Point(20, 70);
            this.separator.Size = new System.Drawing.Size(280, 2);
            this.separator.Name = "separator";
            this.separator.UseTransparentBackground = true;
            this.separator.BackColor = System.Drawing.Color.Transparent;

            // label1 (ID Role)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label1.Location = new System.Drawing.Point(20, 85);
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Text = "ID Role";

            // txtID
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.PlaceholderText = "Masukkan ID Role...";
            this.txtID.SelectedText = "";
            this.txtID.Location = new System.Drawing.Point(20, 108);
            this.txtID.Size = new System.Drawing.Size(280, 38);
            this.txtID.BorderRadius = 8;
            this.txtID.Name = "txtID";
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);

            // label4 (Role)
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            this.label4.Text = "Nama Role";

            // txtRole
            this.txtRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRole.DefaultText = "";
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRole.PlaceholderText = "Masukkan Nama Role...";
            this.txtRole.SelectedText = "";
            this.txtRole.Location = new System.Drawing.Point(20, 185);
            this.txtRole.Size = new System.Drawing.Size(280, 38);
            this.txtRole.BorderRadius = 8;
            this.txtRole.Name = "txtRole";
            this.txtRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);

            // guna2Button1 (Simpan)
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Location = new System.Drawing.Point(20, 248);
            this.guna2Button1.Size = new System.Drawing.Size(130, 40);
            this.guna2Button1.Text = "💾  Simpan";
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            // guna2Button2 (Update)
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Location = new System.Drawing.Point(170, 248);
            this.guna2Button2.Size = new System.Drawing.Size(130, 40);
            this.guna2Button2.Text = "✏️  Update";
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);

            // label2, label3 (hidden, kept for compatibility)
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(0, 0); this.label2.Visible = false; this.label2.Name = "label2";
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(0, 0); this.label3.Visible = false; this.label3.Name = "label3"; this.label3.Text = "ID";

            // pnlGrid (right data panel)
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(360, 20);
            this.pnlGrid.Size = new System.Drawing.Size(580, 560);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Size = new System.Drawing.Size(300, 28);
            this.lblGridTitle.Text = "Daftar Role";
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Name = "lblGridTitle";

            // guna2DataGridView1
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
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle;
            this.guna2DataGridView1.RowTemplate.Height = 34;

            altStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 255);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 225, 240);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 52);
            this.guna2DataGridView1.Size = new System.Drawing.Size(550, 495);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);

            // Columns
            this.Column1.HeaderText = "ID"; this.Column1.Name = "Column1"; this.Column1.ReadOnly = true; this.Column1.FillWeight = 20;
            this.Column2.HeaderText = "Nama Role"; this.Column2.Name = "Column2"; this.Column2.ReadOnly = true; this.Column2.FillWeight = 50;
            this.Column3.HeaderText = "Edit"; this.Column3.Name = "Column3"; this.Column3.ReadOnly = true; this.Column3.FillWeight = 15;
            this.Column3.Image = ((System.Drawing.Image)(resources.GetObject("Column3.Image")));
            this.Column4.HeaderText = "Hapus"; this.Column4.Name = "Column4"; this.Column4.ReadOnly = true; this.Column4.FillWeight = 15;
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.guna2DataGridView1.Columns.AddRange(this.Column1, this.Column2, this.Column3, this.Column4);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.pnlBg);
            this.Name = "FRole";
            this.Text = "Data Role";

            this.pnlBg.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel pnlBg;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblTitle, lblSub;
        private Guna.UI2.WinForms.Guna2Shapes separator;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtRole;
        private Guna.UI2.WinForms.Guna2Button guna2Button1, guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}
