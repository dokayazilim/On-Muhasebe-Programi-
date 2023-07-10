namespace onmuhasebe
{
    partial class carilistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carilistesi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evraknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemesekliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariraporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartdataDataSet8 = new onmuhasebe.onmuhasebesmartdataDataSet8();
            this.cariraporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmedefteriortakhesaplarDataSet4 = new onmuhasebe.isletmedefteriortakhesaplarDataSet4();
            this.carihesapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebedataDataSet1 = new onmuhasebe.onmuhasebedataDataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odemesekli = new System.Windows.Forms.RadioButton();
            this.evrakno = new System.Windows.Forms.RadioButton();
            this.ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carihesapTableAdapter = new onmuhasebe.onmuhasebedataDataSet1TableAdapters.carihesapTableAdapter();
            this.cariraporTableAdapter = new onmuhasebe.isletmedefteriortakhesaplarDataSet4TableAdapters.cariraporTableAdapter();
            this.cariraporTableAdapter1 = new onmuhasebe.onmuhasebesmartdataDataSet8TableAdapters.cariraporTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariraporBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariraporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortakhesaplarDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carihesapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.vadeDataGridViewTextBoxColumn,
            this.evraknoDataGridViewTextBoxColumn,
            this.odemesekliDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.borcDataGridViewTextBoxColumn,
            this.alacakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cariraporBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(239, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(725, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // vadeDataGridViewTextBoxColumn
            // 
            this.vadeDataGridViewTextBoxColumn.DataPropertyName = "vade";
            this.vadeDataGridViewTextBoxColumn.HeaderText = "Vade";
            this.vadeDataGridViewTextBoxColumn.Name = "vadeDataGridViewTextBoxColumn";
            // 
            // evraknoDataGridViewTextBoxColumn
            // 
            this.evraknoDataGridViewTextBoxColumn.DataPropertyName = "evrakno";
            this.evraknoDataGridViewTextBoxColumn.HeaderText = "Evrak No";
            this.evraknoDataGridViewTextBoxColumn.Name = "evraknoDataGridViewTextBoxColumn";
            // 
            // odemesekliDataGridViewTextBoxColumn
            // 
            this.odemesekliDataGridViewTextBoxColumn.DataPropertyName = "odemesekli";
            this.odemesekliDataGridViewTextBoxColumn.HeaderText = "Ödeme Şekli";
            this.odemesekliDataGridViewTextBoxColumn.Name = "odemesekliDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // borcDataGridViewTextBoxColumn
            // 
            this.borcDataGridViewTextBoxColumn.DataPropertyName = "borc";
            this.borcDataGridViewTextBoxColumn.HeaderText = "Borç";
            this.borcDataGridViewTextBoxColumn.Name = "borcDataGridViewTextBoxColumn";
            // 
            // alacakDataGridViewTextBoxColumn
            // 
            this.alacakDataGridViewTextBoxColumn.DataPropertyName = "alacak";
            this.alacakDataGridViewTextBoxColumn.HeaderText = "Alacak";
            this.alacakDataGridViewTextBoxColumn.Name = "alacakDataGridViewTextBoxColumn";
            // 
            // cariraporBindingSource1
            // 
            this.cariraporBindingSource1.DataMember = "carirapor";
            this.cariraporBindingSource1.DataSource = this.onmuhasebesmartdataDataSet8;
            // 
            // onmuhasebesmartdataDataSet8
            // 
            this.onmuhasebesmartdataDataSet8.DataSetName = "onmuhasebesmartdataDataSet8";
            this.onmuhasebesmartdataDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cariraporBindingSource
            // 
            this.cariraporBindingSource.DataMember = "carirapor";
            this.cariraporBindingSource.DataSource = this.isletmedefteriortakhesaplarDataSet4;
            // 
            // isletmedefteriortakhesaplarDataSet4
            // 
            this.isletmedefteriortakhesaplarDataSet4.DataSetName = "isletmedefteriortakhesaplarDataSet4";
            this.isletmedefteriortakhesaplarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carihesapBindingSource
            // 
            this.carihesapBindingSource.DataMember = "carihesap";
            this.carihesapBindingSource.DataSource = this.onmuhasebedataDataSet1;
            // 
            // onmuhasebedataDataSet1
            // 
            this.onmuhasebedataDataSet1.DataSetName = "onmuhasebedataDataSet1";
            this.onmuhasebedataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 389);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ara);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(224, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odemesekli);
            this.groupBox1.Controls.Add(this.evrakno);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // odemesekli
            // 
            this.odemesekli.AutoSize = true;
            this.odemesekli.Location = new System.Drawing.Point(18, 43);
            this.odemesekli.Name = "odemesekli";
            this.odemesekli.Size = new System.Drawing.Size(85, 17);
            this.odemesekli.TabIndex = 3;
            this.odemesekli.TabStop = true;
            this.odemesekli.Text = "Ödeme Şekli";
            this.odemesekli.UseVisualStyleBackColor = true;
            // 
            // evrakno
            // 
            this.evrakno.AutoSize = true;
            this.evrakno.Location = new System.Drawing.Point(18, 20);
            this.evrakno.Name = "evrakno";
            this.evrakno.Size = new System.Drawing.Size(70, 17);
            this.evrakno.TabIndex = 3;
            this.evrakno.TabStop = true;
            this.evrakno.Text = "Evrak No";
            this.evrakno.UseVisualStyleBackColor = true;
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(58, 15);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(145, 20);
            this.ara.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arama :";
            // 
            // carihesapTableAdapter
            // 
            this.carihesapTableAdapter.ClearBeforeFill = true;
            // 
            // cariraporTableAdapter
            // 
            this.cariraporTableAdapter.ClearBeforeFill = true;
            // 
            // cariraporTableAdapter1
            // 
            this.cariraporTableAdapter1.ClearBeforeFill = true;
            // 
            // carilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 418);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(985, 456);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(985, 456);
            this.Name = "carilistesi";
            this.Text = "Cari Hareketleri";
            this.Load += new System.EventHandler(this.carilistesi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariraporBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariraporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortakhesaplarDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carihesapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ara;
        private onmuhasebedataDataSet1 onmuhasebedataDataSet1;
        private System.Windows.Forms.BindingSource carihesapBindingSource;
        private onmuhasebedataDataSet1TableAdapters.carihesapTableAdapter carihesapTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton evrakno;
        private System.Windows.Forms.RadioButton odemesekli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private isletmedefteriortakhesaplarDataSet4 isletmedefteriortakhesaplarDataSet4;
        private System.Windows.Forms.BindingSource cariraporBindingSource;
        private isletmedefteriortakhesaplarDataSet4TableAdapters.cariraporTableAdapter cariraporTableAdapter;
        private onmuhasebesmartdataDataSet8 onmuhasebesmartdataDataSet8;
        private System.Windows.Forms.BindingSource cariraporBindingSource1;
        private onmuhasebesmartdataDataSet8TableAdapters.cariraporTableAdapter cariraporTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evraknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemesekliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alacakDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}