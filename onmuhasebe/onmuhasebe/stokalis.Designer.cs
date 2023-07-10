namespace onmuhasebe
{
    partial class stokalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokalis));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stokadi = new System.Windows.Forms.RadioButton();
            this.stokkodu = new System.Windows.Forms.RadioButton();
            this.ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yenistokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebedataDataSet25 = new onmuhasebe.onmuhasebedataDataSet25();
            this.yenistokTableAdapter = new onmuhasebe.onmuhasebedataDataSet25TableAdapters.yenistokTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.onmuhasebesmartdataDataSet14 = new onmuhasebe.onmuhasebesmartdataDataSet14();
            this.yenistokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yenistokTableAdapter1 = new onmuhasebe.onmuhasebesmartdataDataSet14TableAdapters.yenistokTableAdapter();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyatitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvoranialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karoraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvoranisatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(190, 273);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(182, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(9, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(9, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stokadi);
            this.groupBox1.Controls.Add(this.stokkodu);
            this.groupBox1.Location = new System.Drawing.Point(9, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenek";
            // 
            // stokadi
            // 
            this.stokadi.AutoSize = true;
            this.stokadi.Location = new System.Drawing.Point(21, 42);
            this.stokadi.Name = "stokadi";
            this.stokadi.Size = new System.Drawing.Size(65, 17);
            this.stokadi.TabIndex = 2;
            this.stokadi.TabStop = true;
            this.stokadi.Text = "Stok Adı";
            this.stokadi.UseVisualStyleBackColor = true;
            // 
            // stokkodu
            // 
            this.stokkodu.AutoSize = true;
            this.stokkodu.Location = new System.Drawing.Point(21, 19);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(75, 17);
            this.stokkodu.TabIndex = 2;
            this.stokkodu.TabStop = true;
            this.stokkodu.Text = "Stok Kodu";
            this.stokkodu.UseVisualStyleBackColor = true;
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(41, 16);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(135, 20);
            this.ara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
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
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadiDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.alisfiyatitlDataGridViewTextBoxColumn,
            this.kdvoranialisDataGridViewTextBoxColumn,
            this.karoraniDataGridViewTextBoxColumn,
            this.satisfiyatitlDataGridViewTextBoxColumn,
            this.kdvoranisatisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yenistokBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(196, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(622, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yenistokBindingSource
            // 
            this.yenistokBindingSource.DataMember = "yenistok";
            this.yenistokBindingSource.DataSource = this.onmuhasebedataDataSet25;
            // 
            // onmuhasebedataDataSet25
            // 
            this.onmuhasebedataDataSet25.DataSetName = "onmuhasebedataDataSet25";
            this.onmuhasebedataDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yenistokTableAdapter
            // 
            this.yenistokTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // onmuhasebesmartdataDataSet14
            // 
            this.onmuhasebesmartdataDataSet14.DataSetName = "onmuhasebesmartdataDataSet14";
            this.onmuhasebesmartdataDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yenistokBindingSource1
            // 
            this.yenistokBindingSource1.DataMember = "yenistok";
            this.yenistokBindingSource1.DataSource = this.onmuhasebesmartdataDataSet14;
            // 
            // yenistokTableAdapter1
            // 
            this.yenistokTableAdapter1.ClearBeforeFill = true;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stokkodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "Stok Kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stokadi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "Stok Adı";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            // 
            // alisfiyatitlDataGridViewTextBoxColumn
            // 
            this.alisfiyatitlDataGridViewTextBoxColumn.DataPropertyName = "alisfiyatitl";
            this.alisfiyatitlDataGridViewTextBoxColumn.HeaderText = "Alış Fiyatı (TL)";
            this.alisfiyatitlDataGridViewTextBoxColumn.Name = "alisfiyatitlDataGridViewTextBoxColumn";
            // 
            // kdvoranialisDataGridViewTextBoxColumn
            // 
            this.kdvoranialisDataGridViewTextBoxColumn.DataPropertyName = "kdvoranialis";
            this.kdvoranialisDataGridViewTextBoxColumn.HeaderText = "KDV Oranı (Alış)";
            this.kdvoranialisDataGridViewTextBoxColumn.Name = "kdvoranialisDataGridViewTextBoxColumn";
            // 
            // karoraniDataGridViewTextBoxColumn
            // 
            this.karoraniDataGridViewTextBoxColumn.DataPropertyName = "karorani";
            this.karoraniDataGridViewTextBoxColumn.HeaderText = "Kâr Oranı";
            this.karoraniDataGridViewTextBoxColumn.Name = "karoraniDataGridViewTextBoxColumn";
            // 
            // satisfiyatitlDataGridViewTextBoxColumn
            // 
            this.satisfiyatitlDataGridViewTextBoxColumn.DataPropertyName = "satisfiyatitl";
            this.satisfiyatitlDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı (TL)";
            this.satisfiyatitlDataGridViewTextBoxColumn.Name = "satisfiyatitlDataGridViewTextBoxColumn";
            // 
            // kdvoranisatisDataGridViewTextBoxColumn
            // 
            this.kdvoranisatisDataGridViewTextBoxColumn.DataPropertyName = "kdvoranisatis";
            this.kdvoranisatisDataGridViewTextBoxColumn.HeaderText = "KDV Oranı (Satış)";
            this.kdvoranisatisDataGridViewTextBoxColumn.Name = "kdvoranisatisDataGridViewTextBoxColumn";
            // 
            // stokalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 339);
            this.Name = "stokalis";
            this.Text = "Stok Kayıtları";
            this.Load += new System.EventHandler(this.stokalis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.RadioButton stokadi;
        private System.Windows.Forms.RadioButton stokkodu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private onmuhasebedataDataSet25 onmuhasebedataDataSet25;
        private System.Windows.Forms.BindingSource yenistokBindingSource;
        private onmuhasebedataDataSet25TableAdapters.yenistokTableAdapter yenistokTableAdapter;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private onmuhasebesmartdataDataSet14 onmuhasebesmartdataDataSet14;
        private System.Windows.Forms.BindingSource yenistokBindingSource1;
        private onmuhasebesmartdataDataSet14TableAdapters.yenistokTableAdapter yenistokTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyatitlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvoranialisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karoraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatitlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvoranisatisDataGridViewTextBoxColumn;
    }
}