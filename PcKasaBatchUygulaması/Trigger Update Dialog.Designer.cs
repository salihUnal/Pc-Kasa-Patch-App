namespace PcKasaPatchUygulaması
{
    partial class Trigger_Update_Dialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okbutonu
            // 
            this.okbutonu.BackColor = System.Drawing.Color.Transparent;
            this.okbutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okbutonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbutonu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.okbutonu.FlatAppearance.BorderSize = 3;
            this.okbutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okbutonu.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.okbutonu.Location = new System.Drawing.Point(244, 133);
            this.okbutonu.Name = "okbutonu";
            this.okbutonu.Size = new System.Drawing.Size(170, 38);
            this.okbutonu.TabIndex = 5;
            this.okbutonu.Text = "ANLADIM";
            this.okbutonu.UseVisualStyleBackColor = false;
            this.okbutonu.Click += new System.EventHandler(this.okbutonu_Click);
            this.okbutonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.okbutonu_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(-1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 110);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pc Kasa yazılımınız güncellenecektir. Güncellemenin doğru yapılabilmesi için Lütf" +
    "en  \"UPDATE TAMAMLANDI\" uyarısı açılana kadar Pc Kasaya \"MÜDAHALE ETMEYİNİZ\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Kozuka Gothic Pro M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(615, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 54;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Trigger_Update_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PcKasaPatchUygulaması.Properties.Resources.Blue_Wallpaper_colors_34503103_1440_900;
            this.ClientSize = new System.Drawing.Size(661, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okbutonu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trigger_Update_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Penceresi";
            this.Load += new System.EventHandler(this.Trigger_Update_Dialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okbutonu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
    }
}