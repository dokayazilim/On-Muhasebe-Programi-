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
    public partial class kayitlifirma : Form
    {
        public kayitlifirma()
        {
            InitializeComponent();
        }

        private void kayitlifirma_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet26.firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter1.Fill(this.onmuhasebesmartdataDataSet26.firma);
          

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (label1.Text != "")
            {
                yenicari b = new yenicari();
                alinansenet c = new alinansenet();
                alisfatura d = new alisfatura();
                alisirsaliye f = new alisirsaliye();
                alisislemi g = new alisislemi();
                satisfatura h = new satisfatura();
                satisirsaliye i = new satisirsaliye();
                satisislemi j = new satisislemi();
                verilensenet k = new verilensenet();
                verilenteklif l = new verilenteklif();
                alinanteklif m = new alinanteklif();
                yenibanka n = new yenibanka();
                //////yeni cari...
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = b.dataGridView1.DataSource;

                sr2.Filter = "adi like '%" + label1.Text + "%'";
                b.dataGridView1.DataSource = sr2;
                //////////alınan senetler...
                BindingSource sr3 = new BindingSource();
                sr3.DataSource = c.dataGridView1.DataSource;

                sr3.Filter = "carikodu like '%" + label1.Text + "%'";
                c.dataGridView1.DataSource = sr3;
                ///////alış faturası...
                BindingSource sr4 = new BindingSource();
                sr4.DataSource = d.dataGridView1.DataSource;

                sr4.Filter = "cariadi like '%" + label1.Text + "%'";
                d.dataGridView1.DataSource = sr4;
                ///////alış irsaliyesi
                BindingSource sr5 = new BindingSource();
                sr5.DataSource = f.dataGridView1.DataSource;

                sr5.Filter = "carihesap like '%" + label1.Text + "%'";
                f.dataGridView1.DataSource = sr5;
                ///////alış işlemi veresiye...
                BindingSource sr6 = new BindingSource();
                sr6.DataSource = g.dataGridView1.DataSource;

                sr6.Filter = "carikodu like '%" + label1.Text + "%'";
                g.dataGridView1.DataSource = sr6;
                ///////alış işlemi taksit...
                BindingSource sr7 = new BindingSource();
                sr7.DataSource = g.dataGridView2.DataSource;

                sr7.Filter = "carikodu like '%" + label1.Text + "%'";
                g.dataGridView2.DataSource = sr7;
                ///////alış işlemi peşin..
                BindingSource sr8 = new BindingSource();
                sr8.DataSource = g.dataGridView3.DataSource;

                sr8.Filter = "carikodu like '%" + label1.Text + "%'";
                g.dataGridView3.DataSource = sr8;
                ///////satış fatura..
                BindingSource sr9 = new BindingSource();
                sr9.DataSource = h.dataGridView1.DataSource;

                sr9.Filter = "cariadi like '%" + label1.Text + "%'";
                h.dataGridView1.DataSource = sr9;
                ///////satış irsaliye.
                BindingSource sr10 = new BindingSource();
                sr10.DataSource = i.dataGridView1.DataSource;

                sr10.Filter = "carihesap like '%" + label1.Text + "%'";
                i.dataGridView1.DataSource = sr10;

                ///////satış işlemi veresiye...
                BindingSource sr11 = new BindingSource();
                sr11.DataSource = j.dataGridView1.DataSource;

                sr11.Filter = "carikodu like '%" + label1.Text + "%'";
                j.dataGridView1.DataSource = sr11;
                ///////satış işlemi taksit...
                BindingSource sr12 = new BindingSource();
                sr12.DataSource = j.dataGridView2.DataSource;

                sr12.Filter = "carikodu like '%" + label1.Text + "%'";
                j.dataGridView2.DataSource = sr12;
                ///////satış işlemi peşin..
                BindingSource sr13 = new BindingSource();
                sr13.DataSource = j.dataGridView3.DataSource;

                sr13.Filter = "carikodu like '%" + label1.Text + "%'";
                j.dataGridView3.DataSource = sr13;
                //////////verilen senetler...
                BindingSource sr14 = new BindingSource();
                sr14.DataSource = k.dataGridView1.DataSource;

                sr14.Filter = "carikodu like '%" + label1.Text + "%'";
                k.dataGridView1.DataSource = sr14;

                //////////verilen teklifler...
                BindingSource sr15 = new BindingSource();
                sr15.DataSource = l.dataGridView2.DataSource;

                sr15.Filter = "carikodu like '%" + label1.Text + "%'";
                l.dataGridView2.DataSource = sr15;

                //////////alınan teklifler...
                BindingSource sr16 = new BindingSource();
                sr16.DataSource = m.dataGridView2.DataSource;

                sr16.Filter = "carikodu like '%" + label1.Text + "%'";
                m.dataGridView2.DataSource = sr16;

                //////////banka...
                BindingSource sr17 = new BindingSource();
                sr17.DataSource = n.dataGridView1.DataSource;

                sr17.Filter = "rumuz like '%" + label1.Text + "%'";
                n.dataGridView1.DataSource = sr17;


                anamenu a = new anamenu();
                a.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Lütfen firma seçimi yapınız. Eğer herhangi bir firma yoksa 'Yeni Firma' butonuyla firma kaydı yapabilirsiniz!", "Uyarı");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
            this.Hide();
        }
    }
}
