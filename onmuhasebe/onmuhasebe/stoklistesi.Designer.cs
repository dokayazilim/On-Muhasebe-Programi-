namespace onmuhasebe
{
    partial class stoklistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stoklistesi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyatitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvoranialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karoraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvoranisatisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yenistokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebedataDataSet2 = new onmuhasebe.onmuhasebedataDataSet2();
            this.yenistokTableAdapter = new onmuhasebe.onmuhasebedataDataSet2TableAdapters.yenistokTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemkerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemkerToolStripMenuItem
            // 
            this.işlemkerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemkerToolStripMenuItem.Name = "işlemkerToolStripMenuItem";
            this.işlemkerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemkerToolStripMenuItem.Text = "İşlemler";
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
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
            this.tabControl1.Size = new System.Drawing.Size(227, 395);
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
            this.tabPage1.Size = new System.Drawing.Size(219, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(9, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(9, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Birimi";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stok Adı";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Stok Kodu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arama :";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.yenistokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(237, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(720, 375);
            this.dataGridView1.TabIndex = 2;
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
            // yenistokBindingSource
            // 
            this.yenistokBindingSource.DataMember = "yenistok";
            this.yenistokBindingSource.DataSource = this.onmuhasebedataDataSet2;
            // 
            // onmuhasebedataDataSet2
            // 
            this.onmuhasebedataDataSet2.DataSetName = "onmuhasebedataDataSet2";
            this.onmuhasebedataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yenistokTableAdapter
            // 
            this.yenistokTableAdapter.ClearBeforeFill = true;
            // 
            // stoklistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(978, 463);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(978, 463);
            this.Name = "stoklistesi";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.stoklistesi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenistokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private onmuhasebedataDataSet2 onmuhasebedataDataSet2;
        private System.Windows.Forms.BindingSource yenistokBindingSource;
        private onmuhasebedataDataSet2TableAdapters.yenistokTableAdapter yenistokTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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