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
    public partial class carikayitlari : Form
    {
        public carikayitlari()
        {
            InitializeComponent();
        }

        private void carikayitlari_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet28.carihesap' table. You can move, or remove it, as needed.
            this.carihesapTableAdapter.Fill(this.onmuhasebesmartdataDataSet28.carihesap);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ara.Clear();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "adi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
           
            else if (radioButton2.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "soyadi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            else if (radioButton3.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "tckimlikno like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            else 
            {
                MessageBox.Show("Lütfen seçeneklerden herhangi birini seçiniz!","Uyarı");
            }

        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filtreleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "adi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }

            else if (radioButton2.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "soyadi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            else if (radioButton3.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "tckimlikno like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            else
            {
                MessageBox.Show("Lütfen seçeneklerden herhangi birini seçiniz!", "Uyarı");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label2.Text == "alinansenet")
            {
                alinansenet frm2 = (alinansenet)Application.OpenForms["alinansenet"];
                frm2.carikodu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.yetkilisi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Hide();
            }

            if (label2.Text == "alinanteklif")
            {
                alinanteklif frm2 = (alinanteklif)Application.OpenForms["alinanteklif"];
                frm2.carikodu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.yetkilikisi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.vergino.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }

            if (label2.Text == "alisfatura")
            {
                alisfatura frm2 = (alisfatura)Application.OpenForms["alisfatura"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();              

                this.Hide();
            }

            if (label2.Text == "alisirsaliye")
            {
                alisirsaliye frm2 = (alisirsaliye)Application.OpenForms["alisirsaliye"];
                frm2.carihesap.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();                

                this.Hide();
            }

            if (label2.Text == "alisislemiveresiye")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.carikoduveresiye.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                

                this.Hide();
            }

            if (label2.Text == "alisislemitaksit")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.carikodutaksitli.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "alisislemipesin")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.carikodupesin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisfatura")
            {
                satisfatura frm2 = (satisfatura)Application.OpenForms["satisfatura"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisirsaliye")
            {
                satisirsaliye frm2 = (satisirsaliye)Application.OpenForms["satisirsaliye"];
                frm2.carihesap.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisislemiveresiye")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.carikoduveresiye.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisislemitaksit")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.carikodutaksitli.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisislemipesin")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.carikodupesin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "verilensenet")
            {
                verilensenet frm2 = (verilensenet)Application.OpenForms["verilensenet"];
                frm2.carikodu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.yetkilisi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Hide();
            }
            if (label2.Text == "verilenteklif")
            {
                verilenteklif frm2 = (verilenteklif)Application.OpenForms["verilenteklif"];
                frm2.carikodu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.yetkilikisi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.vergino.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }
            if (label2.Text == "parayatirma")
            {
                yenibanka frm2 = (yenibanka)Application.OpenForms["yenibanka"];
                frm2.rumuzyatir.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                this.Hide();
            }
            if (label2.Text == "paracekme")
            {
                yenibanka frm2 = (yenibanka)Application.OpenForms["yenibanka"];
                frm2.rumuzcek.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                this.Hide();
            }
            if (label2.Text == "cekilecekhesap")
            {
                yenibanka frm2 = (yenibanka)Application.OpenForms["yenibanka"];
                frm2.rumuzcekilecek.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                this.Hide();
            }
            if (label2.Text == "yatirilacakhesap")
            {
                yenibanka frm2 = (yenibanka)Application.OpenForms["yenibanka"];
                frm2.rumuzyatirilacak.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                this.Hide();
            }
        }
    }
}
