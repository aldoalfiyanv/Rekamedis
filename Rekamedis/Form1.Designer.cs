namespace Rekamedis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilPuskesmas = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.kelolaTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahPengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilPuskesmas,
            this.about,
            this.kelolaTarif,
            this.ubahPassword,
            this.login,
            this.logout,
            this.tambahPengguna});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilPuskesmas
            // 
            this.profilPuskesmas.Name = "profilPuskesmas";
            this.profilPuskesmas.Size = new System.Drawing.Size(108, 20);
            this.profilPuskesmas.Text = "Profil Puskesmas";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 20);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // kelolaTarif
            // 
            this.kelolaTarif.Name = "kelolaTarif";
            this.kelolaTarif.Size = new System.Drawing.Size(78, 20);
            this.kelolaTarif.Text = "Kelola Tarif";
            // 
            // ubahPassword
            // 
            this.ubahPassword.Name = "ubahPassword";
            this.ubahPassword.Size = new System.Drawing.Size(100, 20);
            this.ubahPassword.Text = "Ubah Password";
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(49, 20);
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(57, 20);
            this.logout.Text = "Logout";
            // 
            // tambahPengguna
            // 
            this.tambahPengguna.Name = "tambahPengguna";
            this.tambahPengguna.Size = new System.Drawing.Size(120, 20);
            this.tambahPengguna.Text = "Tambah Pengguna";
            this.tambahPengguna.Click += new System.EventHandler(this.tambahPenggunaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "APLIKASI REKAMEDIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUSKESMAS MARGADANA KOTA TEGAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(665, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jl. Dr. Copto Mangunkusumo No.72, Sumurpanggang, Kec. Margadana, Kota Tegal, Jawa" +
    " Tengah 52147";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(706, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem profilPuskesmas;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem kelolaTarif;
        private System.Windows.Forms.ToolStripMenuItem ubahPassword;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem tambahPengguna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem logout;
    }
}

