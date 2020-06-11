namespace PcKasaPatchUygulaması
{
    partial class Java_Net_Dialog
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
            this.okbutonu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // okbutonu
            // 
            this.okbutonu.BackColor = System.Drawing.Color.Transparent;
            this.okbutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okbutonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbutonu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutonu.FlatAppearance.BorderSize = 6;
            this.okbutonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbutonu.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okbutonu.Location = new System.Drawing.Point(339, 190);
            this.okbutonu.Name = "okbutonu";
            this.okbutonu.Size = new System.Drawing.Size(170, 38);
            this.okbutonu.TabIndex = 11;
            this.okbutonu.Text = "ANLADIM";
            this.okbutonu.UseVisualStyleBackColor = false;
            this.okbutonu.Click += new System.EventHandler(this.okbutonu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.mark_sign_white_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PcKasaPatchUygulaması.Properties.Resources.uyarı2;
            this.pictureBox2.Location = new System.Drawing.Point(188, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(554, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Java_Net_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PcKasaPatchUygulaması.Properties.Resources.Blue_Wallpaper_colors_34503103_1440_900;
            this.ClientSize = new System.Drawing.Size(744, 236);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.okbutonu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Java_Net_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Penceresi";
            this.Load += new System.EventHandler(this.Java_Net_Dialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okbutonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}