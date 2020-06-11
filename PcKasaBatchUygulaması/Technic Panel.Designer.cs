namespace PcKasaPatchUygulaması
{
    partial class Technic_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technic_Panel));
            this.solpanel = new System.Windows.Forms.Panel();
            this.btnsoruncoz = new System.Windows.Forms.Button();
            this.btnkurulum = new System.Windows.Forms.Button();
            this.panelsoruncoz = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.teknosalogo = new System.Windows.Forms.PictureBox();
            this.kirkikilogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soruncoz2 = new PcKasaPatchUygulaması.soruncoz();
            this.kurulum2 = new PcKasaPatchUygulaması.kurulum();
            this.solpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teknosalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirkikilogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // solpanel
            // 
            this.solpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.solpanel.Controls.Add(this.btnsoruncoz);
            this.solpanel.Controls.Add(this.btnkurulum);
            this.solpanel.Controls.Add(this.panelsoruncoz);
            this.solpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solpanel.Location = new System.Drawing.Point(0, 0);
            this.solpanel.Name = "solpanel";
            this.solpanel.Size = new System.Drawing.Size(195, 506);
            this.solpanel.TabIndex = 25;
            this.solpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnsoruncoz
            // 
            this.btnsoruncoz.BackColor = System.Drawing.Color.Transparent;
            this.btnsoruncoz.BackgroundImage = global::PcKasaPatchUygulaması.Properties.Resources.sorunlar;
            this.btnsoruncoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsoruncoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsoruncoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.btnsoruncoz.Location = new System.Drawing.Point(21, 324);
            this.btnsoruncoz.Name = "btnsoruncoz";
            this.btnsoruncoz.Size = new System.Drawing.Size(149, 150);
            this.btnsoruncoz.TabIndex = 30;
            this.btnsoruncoz.UseVisualStyleBackColor = false;
            this.btnsoruncoz.Click += new System.EventHandler(this.Btnsoruncoz_Click);
            // 
            // btnkurulum
            // 
            this.btnkurulum.BackColor = System.Drawing.Color.Transparent;
            this.btnkurulum.BackgroundImage = global::PcKasaPatchUygulaması.Properties.Resources.kurulum;
            this.btnkurulum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkurulum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkurulum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.btnkurulum.Location = new System.Drawing.Point(21, 94);
            this.btnkurulum.Name = "btnkurulum";
            this.btnkurulum.Size = new System.Drawing.Size(149, 150);
            this.btnkurulum.TabIndex = 29;
            this.btnkurulum.UseVisualStyleBackColor = false;
            this.btnkurulum.Click += new System.EventHandler(this.Btnkurulum_Click);
            // 
            // panelsoruncoz
            // 
            this.panelsoruncoz.Location = new System.Drawing.Point(201, 49);
            this.panelsoruncoz.Name = "panelsoruncoz";
            this.panelsoruncoz.Size = new System.Drawing.Size(595, 457);
            this.panelsoruncoz.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.teknosalogo);
            this.panel2.Controls.Add(this.kirkikilogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 46);
            this.panel2.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(748, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 41);
            this.button5.TabIndex = 28;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // teknosalogo
            // 
            this.teknosalogo.BackColor = System.Drawing.Color.Transparent;
            this.teknosalogo.Image = ((System.Drawing.Image)(resources.GetObject("teknosalogo.Image")));
            this.teknosalogo.Location = new System.Drawing.Point(284, 6);
            this.teknosalogo.Name = "teknosalogo";
            this.teknosalogo.Size = new System.Drawing.Size(121, 37);
            this.teknosalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teknosalogo.TabIndex = 23;
            this.teknosalogo.TabStop = false;
            // 
            // kirkikilogo
            // 
            this.kirkikilogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kirkikilogo.Image = global::PcKasaPatchUygulaması.Properties.Resources._42bilisim;
            this.kirkikilogo.Location = new System.Drawing.Point(538, 2);
            this.kirkikilogo.Name = "kirkikilogo";
            this.kirkikilogo.Size = new System.Drawing.Size(102, 41);
            this.kirkikilogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kirkikilogo.TabIndex = 22;
            this.kirkikilogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.küçük_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // soruncoz2
            // 
            this.soruncoz2.AutoScroll = true;
            this.soruncoz2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.soruncoz2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruncoz2.BackgroundImage")));
            this.soruncoz2.Location = new System.Drawing.Point(190, 46);
            this.soruncoz2.Name = "soruncoz2";
            this.soruncoz2.Size = new System.Drawing.Size(609, 457);
            this.soruncoz2.TabIndex = 28;
            // 
            // kurulum2
            // 
            this.kurulum2.AutoScroll = true;
            this.kurulum2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kurulum2.BackgroundImage")));
            this.kurulum2.Location = new System.Drawing.Point(190, 46);
            this.kurulum2.Name = "kurulum2";
            this.kurulum2.Size = new System.Drawing.Size(603, 457);
            this.kurulum2.TabIndex = 27;
            // 
            // Technic_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(795, 506);
            this.Controls.Add(this.soruncoz2);
            this.Controls.Add(this.kurulum2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.solpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Technic_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technic_Panel";
            this.Load += new System.EventHandler(this.Technic_Panel_Load);
            this.solpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teknosalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirkikilogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox teknosalogo;
        private System.Windows.Forms.Panel solpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelsoruncoz;
        public System.Windows.Forms.Button button5;
        private kurulum kurulum2;
        private System.Windows.Forms.Button btnkurulum;
        private System.Windows.Forms.Button btnsoruncoz;
        private soruncoz soruncoz2;
        private System.Windows.Forms.PictureBox kirkikilogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}