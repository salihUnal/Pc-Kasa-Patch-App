namespace PcKasaPatchUygulaması
{
    partial class ScannerFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerFrm));
			this.kapatBtn = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// kapatBtn
			// 
			this.kapatBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.kapatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kapatBtn.ForeColor = System.Drawing.Color.Red;
			this.kapatBtn.Location = new System.Drawing.Point(154, 679);
			this.kapatBtn.Name = "kapatBtn";
			this.kapatBtn.Size = new System.Drawing.Size(133, 23);
			this.kapatBtn.TabIndex = 1;
			this.kapatBtn.Text = "Pencereyi Kapat";
			this.kapatBtn.UseVisualStyleBackColor = true;
			this.kapatBtn.Click += new System.EventHandler(this.kapatBtn_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBox1.Location = new System.Drawing.Point(-1, 542);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(479, 131);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.taramaayarlari;
			this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(479, 534);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// ScannerFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.kapatBtn;
			this.ClientSize = new System.Drawing.Size(479, 714);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.kapatBtn);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ScannerFrm";
			this.Text = "Tarama Ayarları";
			this.Load += new System.EventHandler(this.ScannerFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kapatBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}