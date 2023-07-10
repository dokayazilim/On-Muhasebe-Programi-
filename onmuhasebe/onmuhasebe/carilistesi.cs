using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace onmuhasebe
{
    public partial class carilistesi : Form
    {
        public carilistesi()
        {
            InitializeComponent();
        }

        private void carilistesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet8.carirapor' table. You can move, or remove it, as needed.
            this.cariraporTableAdapter1.Fill(this.onmuhasebesmartdataDataSet8.carirapor);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (evrakno.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "evrakno like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            if (odemesekli.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "odemesekli like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ara.Clear();
            evrakno.Checked = false;
            odemesekli.Checked = false;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara.Clear();
            evrakno.Checked = false;
            odemesekli.Checked = false;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
