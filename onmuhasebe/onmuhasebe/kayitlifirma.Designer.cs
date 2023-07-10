namespace onmuhasebe
{
    partial class kayitlifirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitlifirma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unvaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartdataDataSet26 = new onmuhasebe.onmuhasebesmartdataDataSet26();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onumuhasebefirmadataDataSet1 = new onmuhasebe.onumuhasebefirmadataDataSet1();
            this.isletmedefteriortakhesaplarDataSet3 = new onmuhasebe.isletmedefteriortakhesaplarDataSet3();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new onmuhasebe.isletmedefteriortakhesaplarDataSet3TableAdapters.firmaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.firmakayitTableAdapter = new onmuhasebe.onumuhasebefirmadataDataSet1TableAdapters.firmakayitTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.firmaTableAdapter1 = new onmuhasebe.onmuhasebesmartdataDataSet26TableAdapters.firmaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onumuhasebefirmadataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortakhesaplarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
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
            this.unvaniDataGridViewTextBoxColumn,
            this.adisoyadiDataGridViewTextBoxColumn,
            this.tckimliknoDataGridViewTextBoxColumn,
            this.vergidairesiDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.donemDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(746, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // unvaniDataGridViewTextBoxColumn
            // 
            this.unvaniDataGridViewTextBoxColumn.DataPropertyName = "unvani";
            this.unvaniDataGridViewTextBoxColumn.HeaderText = "Ünvanı";
            this.unvaniDataGridViewTextBoxColumn.Name = "unvaniDataGridViewTextBoxColumn";
            this.unvaniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adisoyadiDataGridViewTextBoxColumn
            // 
            this.adisoyadiDataGridViewTextBoxColumn.DataPropertyName = "adisoyadi";
            this.adisoyadiDataGridViewTextBoxColumn.HeaderText = "Adı - Soyadı";
            this.adisoyadiDataGridViewTextBoxColumn.Name = "adisoyadiDataGridViewTextBoxColumn";
            this.adisoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckimliknoDataGridViewTextBoxColumn
            // 
            this.tckimliknoDataGridViewTextBoxColumn.DataPropertyName = "tckimlikno";
            this.tckimliknoDataGridViewTextBoxColumn.HeaderText = "T.C. Kimlik No";
            this.tckimliknoDataGridViewTextBoxColumn.Name = "tckimliknoDataGridViewTextBoxColumn";
            this.tckimliknoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vergidairesiDataGridViewTextBoxColumn
            // 
            this.vergidairesiDataGridViewTextBoxColumn.DataPropertyName = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.HeaderText = "Vergi Dairesi";
            this.vergidairesiDataGridViewTextBoxColumn.Name = "vergidairesiDataGridViewTextBoxColumn";
            this.vergidairesiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donemDataGridViewTextBoxColumn
            // 
            this.donemDataGridViewTextBoxColumn.DataPropertyName = "donem";
            this.donemDataGridViewTextBoxColumn.HeaderText = "Dönem";
            this.donemDataGridViewTextBoxColumn.Name = "donemDataGridViewTextBoxColumn";
            this.donemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmaBindingSource1
            // 
            this.firmaBindingSource1.DataMember = "firma";
            this.firmaBindingSource1.DataSource = this.onmuhasebesmartdataDataSet26;
            // 
            // onmuhasebesmartdataDataSet26
            // 
            this.onmuhasebesmartdataDataSet26.DataSetName = "onmuhasebesmartdataDataSet26";
            this.onmuhasebesmartdataDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.onumuhasebefirmadataDataSet1;
            // 
            // onumuhasebefirmadataDataSet1
            // 
            this.onumuhasebefirmadataDataSet1.DataSetName = "onumuhasebefirmadataDataSet1";
            this.onumuhasebefirmadataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isletmedefteriortakhesaplarDataSet3
            // 
            this.isletmedefteriortakhesaplarDataSet3.DataSetName = "isletmedefteriortakhesaplarDataSet3";
            this.isletmedefteriortakhesaplarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "firma";
            this.firmaBindingSource.DataSource = this.isletmedefteriortakhesaplarDataSet3;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(511, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni Firma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(673, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(592, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // firmaTableAdapter1
            // 
            this.firmaTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.Visible = false;
            // 
            // kayitlifirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 368);
            this.Name = "kayitlifirma";
            this.Text = "Kayıtlı Firma/Kişi";
            this.Load += new System.EventHandler(this.kayitlifirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartdataDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onumuhasebefirmadataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortakhesaplarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private isletmedefteriortakhesaplarDataSet3 isletmedefteriortakhesaplarDataSet3;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private isletmedefteriortakhesaplarDataSet3TableAdapters.firmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private onumuhasebefirmadataDataSet1 onumuhasebefirmadataDataSet1;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private onumuhasebefirmadataDataSet1TableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private System.Windows.Forms.Button button3;
        private onmuhasebesmartdataDataSet26 onmuhasebesmartdataDataSet26;
        private System.Windows.Forms.BindingSource firmaBindingSource1;
        private onmuhasebesmartdataDataSet26TableAdapters.firmaTableAdapter firmaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}