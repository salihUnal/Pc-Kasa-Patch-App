namespace PcKasaPatchUygulaması
{
    partial class IntroForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.versLbl = new System.Windows.Forms.Label();
            this.ShopUserBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.miniSimge = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatLbl = new System.Windows.Forms.Label();
            this.tarihLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ExitBtn.FlatAppearance.BorderSize = 4;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(254, 247);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(91, 43);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // versLbl
            // 
            this.versLbl.AutoSize = true;
            this.versLbl.BackColor = System.Drawing.Color.Transparent;
            this.versLbl.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versLbl.ForeColor = System.Drawing.Color.White;
            this.versLbl.Location = new System.Drawing.Point(510, 9);
            this.versLbl.Name = "versLbl";
            this.versLbl.Size = new System.Drawing.Size(64, 13);
            this.versLbl.TabIndex = 6;
            this.versLbl.Text = "versiyon";
            // 
            // ShopUserBtn
            // 
            this.ShopUserBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ShopUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ShopUserBtn.FlatAppearance.BorderSize = 4;
            this.ShopUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ShopUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ShopUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopUserBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ShopUserBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ShopUserBtn.Location = new System.Drawing.Point(303, 173);
            this.ShopUserBtn.Name = "ShopUserBtn";
            this.ShopUserBtn.Size = new System.Drawing.Size(265, 68);
            this.ShopUserBtn.TabIndex = 4;
            this.ShopUserBtn.Text = "Mağaza Personeli";
            this.ShopUserBtn.UseVisualStyleBackColor = false;
            this.ShopUserBtn.Click += new System.EventHandler(this.ShopUserBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.AutoEllipsis = true;
            this.AdminBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AdminBtn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.AdminBtn.FlatAppearance.BorderSize = 4;
            this.AdminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AdminBtn.Location = new System.Drawing.Point(40, 173);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(265, 68);
            this.AdminBtn.TabIndex = 3;
            this.AdminBtn.Text = "Pc Kasa Birimi";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // miniSimge
            // 
            this.miniSimge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.miniSimge.BalloonTipText = "Simge durumu";
            this.miniSimge.BalloonTipTitle = "asasasa";
            this.miniSimge.ContextMenuStrip = this.contextMenuStrip1;
            this.miniSimge.Icon = ((System.Drawing.Icon)(resources.GetObject("miniSimge.Icon")));
            this.miniSimge.Text = "Pc Kasa Patch";
            this.miniSimge.Visible = true;
            this.miniSimge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.KapatToolStripMenuItem_Click);
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.BackColor = System.Drawing.Color.Transparent;
            this.saatLbl.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatLbl.ForeColor = System.Drawing.Color.White;
            this.saatLbl.Location = new System.Drawing.Point(526, 142);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(35, 13);
            this.saatLbl.TabIndex = 8;
            this.saatLbl.Text = "saat";
            // 
            // tarihLbl
            // 
            this.tarihLbl.AutoSize = true;
            this.tarihLbl.BackColor = System.Drawing.Color.Transparent;
            this.tarihLbl.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihLbl.ForeColor = System.Drawing.Color.White;
            this.tarihLbl.Location = new System.Drawing.Point(523, 129);
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(38, 13);
            this.tarihLbl.TabIndex = 9;
            this.tarihLbl.Text = "tarih";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.yenilogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.tarihLbl);
            this.Controls.Add(this.saatLbl);
            this.Controls.Add(this.versLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ShopUserBtn);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ShopUserBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Label versLbl;
        private System.Windows.Forms.NotifyIcon miniSimge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Label tarihLbl;
    }
}