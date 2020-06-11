namespace PcKasaPatchUygulaması
{
    partial class Pc_Kasa_Dialog
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.okbutonu.Location = new System.Drawing.Point(344, 190);
            this.okbutonu.Name = "okbutonu";
            this.okbutonu.Size = new System.Drawing.Size(170, 38);
            this.okbutonu.TabIndex = 8;
            this.okbutonu.Text = "ANLADIM";
            this.okbutonu.UseVisualStyleBackColor = false;
            this.okbutonu.Click += new System.EventHandler(this.okbutonu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PcKasaPatchUygulaması.Properties.Resources.Uyarı1;
            this.pictureBox2.Location = new System.Drawing.Point(192, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(554, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.mark_sign_white_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Pc_Kasa_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 230);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.okbutonu);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Pc_Kasa_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Penceresi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button okbutonu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}