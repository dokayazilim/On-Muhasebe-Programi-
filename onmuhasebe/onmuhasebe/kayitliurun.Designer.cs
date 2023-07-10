namespace onmuhasebe
{
    partial class kayitliurun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitliurun));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olcubirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kritikdegerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartilirurunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokdevirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyatibirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyatiikiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyatiucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatibirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatiikiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatiucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebedataDataSet3 = new onmuhasebe.onmuhasebedataDataSet3();
            this.urunTableAdapter = new onmuhasebe.onmuhasebedataDataSet3TableAdapters.urunTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrekeToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // filtrekeToolStripMenuItem
            // 
            this.filtrekeToolStripMenuItem.Name = "filtrekeToolStripMenuItem";
            this.filtrekeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtrekeToolStripMenuItem.Text = "Filtrele";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(227, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(219, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(9, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(9, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Barkod";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ürün Adı";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ürün Kodu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.bolumadiDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.olcubirimiDataGridViewTextBoxColumn,
            this.kritikdegerDataGridViewTextBoxColumn,
            this.durumuDataGridViewTextBoxColumn,
            this.tartilirurunDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.vadeDataGridViewTextBoxColumn,
            this.stokdevirDataGridViewTextBoxColumn,
            this.depoDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.alisfiyatibirDataGridViewTextBoxColumn,
            this.alisfiyatiikiDataGridViewTextBoxColumn,
            this.alisfiyatiucDataGridViewTextBoxColumn,
            this.satisfiyatibirDataGridViewTextBoxColumn,
            this.satisfiyatiikiDataGridViewTextBoxColumn,
            this.satisfiyatiucDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(234, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(739, 385);
            this.dataGridView1.TabIndex = 2;
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            // 
            // bolumadiDataGridViewTextBoxColumn
            // 
            this.bolumadiDataGridViewTextBoxColumn.DataPropertyName = "bolumadi";
            this.bolumadiDataGridViewTextBoxColumn.HeaderText = "Bölüm Adı";
            this.bolumadiDataGridViewTextBoxColumn.Name = "bolumadiDataGridViewTextBoxColumn";
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // olcubirimiDataGridViewTextBoxColumn
            // 
            this.olcubirimiDataGridViewTextBoxColumn.DataPropertyName = "olcubirimi";
            this.olcubirimiDataGridViewTextBoxColumn.HeaderText = "Ölçü Birimi";
            this.olcubirimiDataGridViewTextBoxColumn.Name = "olcubirimiDataGridViewTextBoxColumn";
            // 
            // kritikdegerDataGridViewTextBoxColumn
            // 
            this.kritikdegerDataGridViewTextBoxColumn.DataPropertyName = "kritikdeger";
            this.kritikdegerDataGridViewTextBoxColumn.HeaderText = "Kritik Değer";
            this.kritikdegerDataGridViewTextBoxColumn.Name = "kritikdegerDataGridViewTextBoxColumn";
            // 
            // durumuDataGridViewTextBoxColumn
            // 
            this.durumuDataGridViewTextBoxColumn.DataPropertyName = "durumu";
            this.durumuDataGridViewTextBoxColumn.HeaderText = "Durumu";
            this.durumuDataGridViewTextBoxColumn.Name = "durumuDataGridViewTextBoxColumn";
            // 
            // tartilirurunDataGridViewTextBoxColumn
            // 
            this.tartilirurunDataGridViewTextBoxColumn.DataPropertyName = "tartilirurun";
            this.tartilirurunDataGridViewTextBoxColumn.HeaderText = "Tartılı Ürün";
            this.tartilirurunDataGridViewTextBoxColumn.Name = "tartilirurunDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "KDV";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            // 
            // vadeDataGridViewTextBoxColumn
            // 
            this.vadeDataGridViewTextBoxColumn.DataPropertyName = "vade";
            this.vadeDataGridViewTextBoxColumn.HeaderText = "Vade";
            this.vadeDataGridViewTextBoxColumn.Name = "vadeDataGridViewTextBoxColumn";
            // 
            // stokdevirDataGridViewTextBoxColumn
            // 
            this.stokdevirDataGridViewTextBoxColumn.DataPropertyName = "stokdevir";
            this.stokdevirDataGridViewTextBoxColumn.HeaderText = "Stok Devir";
            this.stokdevirDataGridViewTextBoxColumn.Name = "stokdevirDataGridViewTextBoxColumn";
            // 
            // depoDataGridViewTextBoxColumn
            // 
            this.depoDataGridViewTextBoxColumn.DataPropertyName = "depo";
            this.depoDataGridViewTextBoxColumn.HeaderText = "Depo";
            this.depoDataGridViewTextBoxColumn.Name = "depoDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // alisfiyatibirDataGridViewTextBoxColumn
            // 
            this.alisfiyatibirDataGridViewTextBoxColumn.DataPropertyName = "alisfiyatibir";
            this.alisfiyatibirDataGridViewTextBoxColumn.HeaderText = "Alış Fiyatı (1)";
            this.alisfiyatibirDataGridViewTextBoxColumn.Name = "alisfiyatibirDataGridViewTextBoxColumn";
            // 
            // alisfiyatiikiDataGridViewTextBoxColumn
            // 
            this.alisfiyatiikiDataGridViewTextBoxColumn.DataPropertyName = "alisfiyatiiki";
            this.alisfiyatiikiDataGridViewTextBoxColumn.HeaderText = "Alış Fiyatı (2)";
            this.alisfiyatiikiDataGridViewTextBoxColumn.Name = "alisfiyatiikiDataGridViewTextBoxColumn";
            // 
            // alisfiyatiucDataGridViewTextBoxColumn
            // 
            this.alisfiyatiucDataGridViewTextBoxColumn.DataPropertyName = "alisfiyatiuc";
            this.alisfiyatiucDataGridViewTextBoxColumn.HeaderText = "Alış Fiyatı (3)";
            this.alisfiyatiucDataGridViewTextBoxColumn.Name = "alisfiyatiucDataGridViewTextBoxColumn";
            // 
            // satisfiyatibirDataGridViewTextBoxColumn
            // 
            this.satisfiyatibirDataGridViewTextBoxColumn.DataPropertyName = "satisfiyatibir";
            this.satisfiyatibirDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı (1)";
            this.satisfiyatibirDataGridViewTextBoxColumn.Name = "satisfiyatibirDataGridViewTextBoxColumn";
            // 
            // satisfiyatiikiDataGridViewTextBoxColumn
            // 
            this.satisfiyatiikiDataGridViewTextBoxColumn.DataPropertyName = "satisfiyatiiki";
            this.satisfiyatiikiDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı (2)";
            this.satisfiyatiikiDataGridViewTextBoxColumn.Name = "satisfiyatiikiDataGridViewTextBoxColumn";
            // 
            // satisfiyatiucDataGridViewTextBoxColumn
            // 
            this.satisfiyatiucDataGridViewTextBoxColumn.DataPropertyName = "satisfiyatiuc";
            this.satisfiyatiucDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı (3)";
            this.satisfiyatiucDataGridViewTextBoxColumn.Name = "satisfiyatiucDataGridViewTextBoxColumn";
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.onmuhasebedataDataSet3;
            // 
            // onmuhasebedataDataSet3
            // 
            this.onmuhasebedataDataSet3.DataSetName = "onmuhasebedataDataSet3";
            this.onmuhasebedataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // kayitliurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(993, 473);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(993, 473);
            this.Name = "kayitliurun";
            this.Text = "Kayıtlı Ürünler";
            this.Load += new System.EventHandler(this.kayitliurun_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private onmuhasebedataDataSet3 onmuhasebedataDataSet3;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private onmuhasebedataDataSet3TableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olcubirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kritikdegerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartilirurunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokdevirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyatibirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyatiikiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyatiucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatibirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatiikiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatiucDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}