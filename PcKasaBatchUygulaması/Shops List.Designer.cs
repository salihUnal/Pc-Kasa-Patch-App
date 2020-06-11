namespace PcKasaPatchUygulaması
{
    partial class Shops_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shops_List));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mağazaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mağazaİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazalarDataSet = new PcKasaPatchUygulaması.MagazalarDataSet();
            this._Magazalar_TableAdapter = new PcKasaPatchUygulaması.MagazalarDataSetTableAdapters._Magazalar_TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teknosalogo = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.kirkikilogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazalarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknosalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirkikilogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mağazaKoduDataGridViewTextBoxColumn,
            this.mağazaİsmiDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ilçeDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazalarBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(804, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // mağazaKoduDataGridViewTextBoxColumn
            // 
            this.mağazaKoduDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mağazaKoduDataGridViewTextBoxColumn.DataPropertyName = "Mağaza_Kodu";
            this.mağazaKoduDataGridViewTextBoxColumn.Frozen = true;
            this.mağazaKoduDataGridViewTextBoxColumn.HeaderText = "Mağaza_Kodu";
            this.mağazaKoduDataGridViewTextBoxColumn.Name = "mağazaKoduDataGridViewTextBoxColumn";
            this.mağazaKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.mağazaKoduDataGridViewTextBoxColumn.Width = 113;
            // 
            // mağazaİsmiDataGridViewTextBoxColumn
            // 
            this.mağazaİsmiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mağazaİsmiDataGridViewTextBoxColumn.DataPropertyName = "Mağaza_İsmi";
            this.mağazaİsmiDataGridViewTextBoxColumn.Frozen = true;
            this.mağazaİsmiDataGridViewTextBoxColumn.HeaderText = "Mağaza_İsmi";
            this.mağazaİsmiDataGridViewTextBoxColumn.Name = "mağazaİsmiDataGridViewTextBoxColumn";
            this.mağazaİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            this.mağazaİsmiDataGridViewTextBoxColumn.Width = 107;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.Frozen = true;
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonNoDataGridViewTextBoxColumn.Width = 95;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.adresDataGridViewTextBoxColumn.Width = 65;
            // 
            // ilçeDataGridViewTextBoxColumn
            // 
            this.ilçeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ilçeDataGridViewTextBoxColumn.DataPropertyName = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.HeaderText = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.Name = "ilçeDataGridViewTextBoxColumn";
            this.ilçeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ilçeDataGridViewTextBoxColumn.Width = 52;
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "İl";
            this.ilDataGridViewTextBoxColumn.HeaderText = "İl";
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            this.ilDataGridViewTextBoxColumn.ReadOnly = true;
            this.ilDataGridViewTextBoxColumn.Width = 40;
            // 
            // magazalarBindingSource
            // 
            this.magazalarBindingSource.DataMember = "\'Magazalar\'";
            this.magazalarBindingSource.DataSource = this.magazalarDataSet;
            // 
            // magazalarDataSet
            // 
            this.magazalarDataSet.DataSetName = "MagazalarDataSet";
            this.magazalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _Magazalar_TableAdapter
            // 
            this._Magazalar_TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.teknosalogo);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.kirkikilogo);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 48);
            this.panel1.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PcKasaPatchUygulaması.Properties.Resources.küçük_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // teknosalogo
            // 
            this.teknosalogo.BackColor = System.Drawing.Color.Transparent;
            this.teknosalogo.Image = ((System.Drawing.Image)(resources.GetObject("teknosalogo.Image")));
            this.teknosalogo.Location = new System.Drawing.Point(245, 6);
            this.teknosalogo.Name = "teknosalogo";
            this.teknosalogo.Size = new System.Drawing.Size(121, 37);
            this.teknosalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teknosalogo.TabIndex = 52;
            this.teknosalogo.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Kozuka Gothic Pro M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(749, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 41);
            this.button5.TabIndex = 53;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // kirkikilogo
            // 
            this.kirkikilogo.BackColor = System.Drawing.Color.Transparent;
            this.kirkikilogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kirkikilogo.Image = global::PcKasaPatchUygulaması.Properties.Resources._42bilisim;
            this.kirkikilogo.Location = new System.Drawing.Point(469, 3);
            this.kirkikilogo.Name = "kirkikilogo";
            this.kirkikilogo.Size = new System.Drawing.Size(98, 41);
            this.kirkikilogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kirkikilogo.TabIndex = 51;
            this.kirkikilogo.TabStop = false;
            // 
            // Shops_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shops_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shops_List";
            this.Load += new System.EventHandler(this.Shops_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazalarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknosalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirkikilogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazalarDataSet magazalarDataSet;
        private System.Windows.Forms.BindingSource magazalarBindingSource;
        private MagazalarDataSetTableAdapters._Magazalar_TableAdapter _Magazalar_TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox teknosalogo;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox kirkikilogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mağazaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mağazaİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
    }
}