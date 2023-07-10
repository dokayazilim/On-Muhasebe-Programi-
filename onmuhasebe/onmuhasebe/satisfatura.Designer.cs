namespace onmuhasebe
{
    partial class satisfatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisfatura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvtutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfaturalariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartdataDataSet9 = new onmuhasebe.onmuhasebesmartdataDataSet9();
            this.satisfaturalariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebedataDataSet13 = new onmuhasebe.onmuhasebedataDataSet13();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satisfaturalariTableAdapter = new onmuhasebe.onmuhasebedataDataSet13TableAdapters.satisfaturalariTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kdvorani = new System.Windows.Forms.ComboBox();
            this.tutar = new System.Windows.Forms.TextBox();
            this.cariadi = new System.Windows.Forms.TextBox();
            this.islemturu = new System.Windows.Forms.TextBox();
            this.belgeno = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.satisfaturalariTableAdapter1 = new onmuhasebe.onmuhasebesmartdataDataSet9TableAdapters.satisfaturalariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfaturalariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfaturalariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet13)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.belgenoDataGridViewTextBoxColumn,
            this.islemturuDataGridViewTextBoxColumn,
            this.cariadiDataGridViewTextBoxColumn,
            this.bruttutarDataGridViewTextBoxColumn,
            this.kdvtutariDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisfaturalariBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(268, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(660, 363);
            this.dataGridView1.TabIndex = 5;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // belgenoDataGridViewTextBoxColumn
            // 
            this.belgenoDataGridViewTextBoxColumn.DataPropertyName = "belgeno";
            this.belgenoDataGridViewTextBoxColumn.HeaderText = "Belge No";
            this.belgenoDataGridViewTextBoxColumn.Name = "belgenoDataGridViewTextBoxColumn";
            // 
            // islemturuDataGridViewTextBoxColumn
            // 
            this.islemturuDataGridViewTextBoxColumn.DataPropertyName = "islemturu";
            this.islemturuDataGridViewTextBoxColumn.HeaderText = "İşlem Türü";
            this.islemturuDataGridViewTextBoxColumn.Name = "islemturuDataGridViewTextBoxColumn";
            // 
            // cariadiDataGridViewTextBoxColumn
            // 
            this.cariadiDataGridViewTextBoxColumn.DataPropertyName = "cariadi";
            this.cariadiDataGridViewTextBoxColumn.HeaderText = "Cari Adı";
            this.cariadiDataGridViewTextBoxColumn.Name = "cariadiDataGridViewTextBoxColumn";
            // 
            // bruttutarDataGridViewTextBoxColumn
            // 
            this.bruttutarDataGridViewTextBoxColumn.DataPropertyName = "bruttutar";
            this.bruttutarDataGridViewTextBoxColumn.HeaderText = "Brüt Tutar";
            this.bruttutarDataGridViewTextBoxColumn.Name = "bruttutarDataGridViewTextBoxColumn";
            // 
            // kdvtutariDataGridViewTextBoxColumn
            // 
            this.kdvtutariDataGridViewTextBoxColumn.DataPropertyName = "kdvtutari";
            this.kdvtutariDataGridViewTextBoxColumn.HeaderText = "KDV Tutarı";
            this.kdvtutariDataGridViewTextBoxColumn.Name = "kdvtutariDataGridViewTextBoxColumn";
            // 
            // toplamtutarDataGridViewTextBoxColumn
            // 
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplamtutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "Toplam Tutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
            // 
            // satisfaturalariBindingSource1
            // 
            this.satisfaturalariBindingSource1.DataMember = "satisfaturalari";
            this.satisfaturalariBindingSource1.DataSource = this.onmuhasebesmartdataDataSet9;
            // 
            // onmuhasebesmartdataDataSet9
            // 
            this.onmuhasebesmartdataDataSet9.DataSetName = "onmuhasebesmartdataDataSet9";
            this.onmuhasebesmartdataDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisfaturalariBindingSource
            // 
            this.satisfaturalariBindingSource.DataMember = "satisfaturalari";
            this.satisfaturalariBindingSource.DataSource = this.onmuhasebedataDataSet13;
            // 
            // onmuhasebedataDataSet13
            // 
            this.onmuhasebedataDataSet13.DataSetName = "onmuhasebedataDataSet13";
            this.onmuhasebedataDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.temizleToolStripMenuItem.Text = "Yeni Kayıt";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.filtreleToolStripMenuItem.Text = "Kaydet";
            this.filtreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.silToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // satisfaturalariTableAdapter
            // 
            this.satisfaturalariTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 383);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.kdvorani);
            this.tabPage2.Controls.Add(this.tutar);
            this.tabPage2.Controls.Add(this.cariadi);
            this.tabPage2.Controls.Add(this.islemturu);
            this.tabPage2.Controls.Add(this.belgeno);
            this.tabPage2.Controls.Add(this.tarih);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(255, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kayıt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(216, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageKey = "close.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(84, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 39);
            this.button6.TabIndex = 3;
            this.button6.Text = "Kapat";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "close.png");
            this.ımageList1.Images.SetKeyName(1, "datakaydet.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "refresh.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(84, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 39);
            this.button5.TabIndex = 3;
            this.button5.Text = "Yeni Kayıt";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "datakaydet.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(84, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kdvorani
            // 
            this.kdvorani.FormattingEnabled = true;
            this.kdvorani.Items.AddRange(new object[] {
            "1",
            "8",
            "18"});
            this.kdvorani.Location = new System.Drawing.Point(84, 129);
            this.kdvorani.Name = "kdvorani";
            this.kdvorani.Size = new System.Drawing.Size(157, 21);
            this.kdvorani.TabIndex = 3;
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(84, 107);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(157, 20);
            this.tutar.TabIndex = 3;
            // 
            // cariadi
            // 
            this.cariadi.Location = new System.Drawing.Point(84, 84);
            this.cariadi.Name = "cariadi";
            this.cariadi.Size = new System.Drawing.Size(126, 20);
            this.cariadi.TabIndex = 3;
            this.cariadi.Click += new System.EventHandler(this.cariadi_Click);
            this.cariadi.TextChanged += new System.EventHandler(this.cariadi_TextChanged);
            // 
            // islemturu
            // 
            this.islemturu.Location = new System.Drawing.Point(84, 61);
            this.islemturu.Name = "islemturu";
            this.islemturu.Size = new System.Drawing.Size(157, 20);
            this.islemturu.TabIndex = 3;
            this.islemturu.Text = "Satış Faturası";
            // 
            // belgeno
            // 
            this.belgeno.Location = new System.Drawing.Point(84, 38);
            this.belgeno.Name = "belgeno";
            this.belgeno.Size = new System.Drawing.Size(157, 20);
            this.belgeno.TabIndex = 3;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(84, 14);
            this.tarih.Mask = "00/00/0000";
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(157, 20);
            this.tarih.TabIndex = 3;
            this.tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "KDV Oranı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Brüt Tutar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cari Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "İşlem Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Belge No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ara);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(255, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(60, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(60, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(60, 16);
            this.ara.Mask = "00/00/0000";
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(188, 20);
            this.ara.TabIndex = 3;
            this.ara.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // satisfaturalariTableAdapter1
            // 
            this.satisfaturalariTableAdapter1.ClearBeforeFill = true;
            // 
            // satisfatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(948, 449);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(948, 449);
            this.Name = "satisfatura";
            this.Text = "Satış Faturası";
            this.Load += new System.EventHandler(this.satisfatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfaturalariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfaturalariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebedataDataSet13)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private onmuhasebedataDataSet13 onmuhasebedataDataSet13;
        private System.Windows.Forms.BindingSource satisfaturalariBindingSource;
        private onmuhasebedataDataSet13TableAdapters.satisfaturalariTableAdapter satisfaturalariTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox kdvorani;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.TextBox islemturu;
        private System.Windows.Forms.TextBox belgeno;
        private System.Windows.Forms.MaskedTextBox tarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private onmuhasebesmartdataDataSet9 onmuhasebesmartdataDataSet9;
        private System.Windows.Forms.BindingSource satisfaturalariBindingSource1;
        private onmuhasebesmartdataDataSet9TableAdapters.satisfaturalariTableAdapter satisfaturalariTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvtutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox cariadi;
    }
}