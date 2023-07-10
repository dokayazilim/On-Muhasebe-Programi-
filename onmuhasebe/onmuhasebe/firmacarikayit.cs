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
    public partial class firmacarikayit : Form
    {
        public firmacarikayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
            this.Hide();
        }

        private void firmacarikayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet29.firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.onmuhasebesmartdataDataSet29.firma);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            yenicari frm2 = (yenicari)Application.OpenForms["yenicari"];
            frm2.adi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }
    }
}
