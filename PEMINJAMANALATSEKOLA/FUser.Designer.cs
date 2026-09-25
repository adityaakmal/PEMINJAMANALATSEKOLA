
namespace PEMINJAMANALATSEKOLA
{
    partial class FUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUser));

            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlBg            = new System.Windows.Forms.Panel();
            this.pnlForm          = new Guna.UI2.WinForms.Guna2Panel();
            this.label6           = new System.Windows.Forms.Label();
            this.label7           = new System.Windows.Forms.Label();
            this.guna2Shapes4     = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1           = new System.Windows.Forms.Label();
            this.txtNama          = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5           = new System.Windows.Forms.Label();
            this.cmbrole          = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2           = new System.Windows.Forms.Label();
            this.txtUser          = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3           = new System.Windows.Forms.Label();
            this.txtPass          = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4           = new System.Windows.Forms.Label();
            this.guna2Button1     = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2     = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrid          = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle     = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7          = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8          = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Shapes1     = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2     = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes3     = new Guna.UI2.WinForms.Guna2Shapes();

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
            this.pnlForm.Size = new System.Drawing.Size(340, 560);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.guna2Shapes4);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.txtNama);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.cmbrole);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.txtUser);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.txtPass);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.guna2Button1);
            this.pnlForm.Controls.Add(this.guna2Button2);
            this.pnlForm.Controls.Add(this.guna2Shapes1);
            this.pnlForm.Controls.Add(this.guna2Shapes2);
            this.pnlForm.Controls.Add(this.guna2Shapes3);

            // label6 (title)
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            this.label6.Text = "Data User";

            // label7 (subtitle)
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(130, 130, 160);
            this.label7.Location = new System.Drawing.Point(20, 50);
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            this.label7.Text = "Kelola akun pengguna sistem";

            // guna2Shapes4 (separator line)
            this.guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.guna2Shapes4.BorderColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.guna2Shapes4.Location = new System.Drawing.Point(20, 76);
            this.guna2Shapes4.Size = new System.Drawing.Size(300, 2);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.UseTransparentBackground = true;
            this.guna2Shapes4.BackColor = System.Drawing.Color.Transparent;

            // hidden shapes kept for compatibility
            this.guna2Shapes1.Visible = false; this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.Click += new System.EventHandler(this.guna2Shapes1_Click);
            this.guna2Shapes2.Visible = false; this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes3.Visible = false; this.guna2Shapes3.Name = "guna2Shapes3";

            int y = 92;
            int gap = 72;

            // label1, txtNama
            this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(70,70,100); this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, y); this.label1.Name = "label1"; this.label1.Text = "Nama Lengkap";
            this.txtNama.Location = new System.Drawing.Point(20, y + 20); this.txtNama.Size = new System.Drawing.Size(300, 38);
            this.txtNama.BorderRadius = 8; this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNama.PlaceholderText = "Masukkan nama..."; this.txtNama.DefaultText = ""; this.txtNama.SelectedText = "";
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208,208,208);
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(226,226,226);
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtNama.Name = "txtNama"; this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            y += gap;

            // label5, cmbrole
            this.label5.AutoSize = true; this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(70,70,100); this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, y); this.label5.Name = "label5"; this.label5.Text = "Role";
            this.cmbrole.Location = new System.Drawing.Point(20, y + 20); this.cmbrole.Size = new System.Drawing.Size(300, 38);
            this.cmbrole.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrole.FocusedColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.cmbrole.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbrole.ItemHeight = 30; this.cmbrole.Name = "cmbrole"; this.cmbrole.BackColor = System.Drawing.Color.Transparent;
            this.cmbrole.DropDown += new System.EventHandler(this.cmbrole_DropDown);
            y += gap;

            // label2, txtUser
            this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(70,70,100); this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, y); this.label2.Name = "label2"; this.label2.Text = "Username";
            this.txtUser.Location = new System.Drawing.Point(20, y + 20); this.txtUser.Size = new System.Drawing.Size(300, 38);
            this.txtUser.BorderRadius = 8; this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.PlaceholderText = "Masukkan username..."; this.txtUser.DefaultText = ""; this.txtUser.SelectedText = "";
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208,208,208);
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(226,226,226);
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtUser.Name = "txtUser"; this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            y += gap;

            // label3, txtPass
            this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(70,70,100); this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, y); this.label3.Name = "label3"; this.label3.Text = "Password";
            this.txtPass.Location = new System.Drawing.Point(20, y + 20); this.txtPass.Size = new System.Drawing.Size(300, 38);
            this.txtPass.BorderRadius = 8; this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPass.PlaceholderText = "Masukkan password..."; this.txtPass.DefaultText = ""; this.txtPass.SelectedText = "";
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208,208,208);
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(226,226,226);
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138,138,138);
            this.txtPass.Name = "txtPass"; this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            y += gap;

            // label4 (hidden ID holder)
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Visible = false; this.label4.Name = "label4"; this.label4.Text = "ID";
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Click += new System.EventHandler(this.label4_Click);

            // buttons
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Location = new System.Drawing.Point(20, y + 10);
            this.guna2Button1.Size = new System.Drawing.Size(140, 40);
            this.guna2Button1.Text = "💾  Simpan";
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);

            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(76, 201, 160);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Location = new System.Drawing.Point(180, y + 10);
            this.guna2Button2.Size = new System.Drawing.Size(140, 40);
            this.guna2Button2.Text = "✏️  Update";
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);

            // pnlGrid
            this.pnlGrid.BorderRadius = 16;
            this.pnlGrid.FillColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(380, 20);
            this.pnlGrid.Size = new System.Drawing.Size(560, 560);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);

            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 15);
            this.lblGridTitle.Size = new System.Drawing.Size(300, 28);
            this.lblGridTitle.Text = "Daftar User";
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Name = "lblGridTitle";

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
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.DefaultCellStyle = rowStyle;
            this.guna2DataGridView1.RowTemplate.Height = 32;

            altStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 255);
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = altStyle;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 225, 240);

            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 52);
            this.guna2DataGridView1.Size = new System.Drawing.Size(530, 495);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click);

            this.Column1.HeaderText = "ID";       this.Column1.Name = "Column1"; this.Column1.ReadOnly = true; this.Column1.FillWeight = 10;
            this.Column2.HeaderText = "Nama";     this.Column2.Name = "Column2"; this.Column2.ReadOnly = true; this.Column2.FillWeight = 22;
            this.Column3.HeaderText = "Username"; this.Column3.Name = "Column3"; this.Column3.ReadOnly = true; this.Column3.FillWeight = 20;
            this.Column4.HeaderText = "Password"; this.Column4.Name = "Column4"; this.Column4.ReadOnly = true; this.Column4.FillWeight = 18;
            this.Column5.HeaderText = "Role";     this.Column5.Name = "Column5"; this.Column5.ReadOnly = true; this.Column5.FillWeight = 15;
            this.Column7.HeaderText = "Edit";     this.Column7.Name = "Column7"; this.Column7.ReadOnly = true; this.Column7.FillWeight = 8;
            this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
            this.Column8.HeaderText = "Hapus";    this.Column8.Name = "Column8"; this.Column8.ReadOnly = true; this.Column8.FillWeight = 8;
            this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
            this.guna2DataGridView1.Columns.AddRange(Column1, Column2, Column3, Column4, Column5, Column7, Column8);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.pnlBg);
            this.Controls.Add(this.label4);
            this.Name = "FUser";
            this.Text = "Data User";

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
        private System.Windows.Forms.Label label6, label7;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4, guna2Shapes1, guna2Shapes2, guna2Shapes3;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNama, txtUser, txtPass;
        private Guna.UI2.WinForms.Guna2ComboBox cmbrole;
        private Guna.UI2.WinForms.Guna2Button guna2Button1, guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1, Column2, Column3, Column4, Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column7, Column8;
    }
}
