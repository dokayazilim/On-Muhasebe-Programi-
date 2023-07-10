using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace onmuhasebe
{
    public partial class alinanteklif : Form
    {
        public alinanteklif()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void alinanteklif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet3.alinanteklifler' table. You can move, or remove it, as needed.
            this.alinantekliflerTableAdapter1.Fill(this.onmuhasebesmartdataDataSet3.alinanteklifler);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into alinanteklifler(tekliftarihi,teklifno,teklifdurumu,gecerliliktarihi,teslimatsuresi,konu,dipnot,carikodu,unvani,yetkilikisi,vergidairesi,vergino) values ('" + tekliftarihi.Text + "','" + teklifno.Text + "','" + teklifdurumu.Text + "','" + gecerliliktarihi.Text + "','" + teslimatsuresi.Text + "','" + konu.Text + "','" + dipnot.Text + "','" + carikodu.Text + "','" + unvani.Text + "','" + yetkilikisi.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "')");
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();
                listele2();
                MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                tekliftarihi.Clear();
                teklifno.Clear();
                teklifdurumu.SelectedIndex = -1;
                gecerliliktarihi.Clear();
                teslimatsuresi.SelectedIndex = -1;
                konu.Clear();
                dipnot.Clear();
                carikodu.Clear();
                unvani.Clear();
                yetkilikisi.Clear();
                vergidairesi.Clear();
                vergino.Clear();



            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
              
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tekliftarihi.Clear();
            teklifno.Clear();
            teklifdurumu.SelectedIndex = -1;
            gecerliliktarihi.Clear();
            teslimatsuresi.SelectedIndex = -1;
            konu.Clear();
            dipnot.Clear();
            carikodu.Clear();
            unvani.Clear();
            yetkilikisi.Clear();
            vergidairesi.Clear();
            vergino.Clear();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekliftarihi.Clear();
            teklifno.Clear();
            teklifdurumu.SelectedIndex = -1;
            gecerliliktarihi.Clear();
            teslimatsuresi.SelectedIndex = -1;
            konu.Clear();
            dipnot.Clear();
            carikodu.Clear();
            unvani.Clear();
            yetkilikisi.Clear();
            vergidairesi.Clear();
            vergino.Clear();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into alinanteklifler(tekliftarihi,teklifno,teklifdurumu,gecerliliktarihi,teslimatsuresi,konu,dipnot,carikodu,unvani,yetkilikisi,vergidairesi,vergino) values ('" + tekliftarihi.Text + "','" + teklifno.Text + "','" + teklifdurumu.Text + "','" + gecerliliktarihi.Text + "','" + teslimatsuresi.Text + "','" + konu.Text + "','" + dipnot.Text + "','" + carikodu.Text + "','" + unvani.Text + "','" + yetkilikisi.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "')");
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();
                listele2();
                MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                tekliftarihi.Clear();
                teklifno.Clear();
                teklifdurumu.SelectedIndex = -1;
                gecerliliktarihi.Clear();
                teslimatsuresi.SelectedIndex = -1;
                konu.Clear();
                dipnot.Clear();
                carikodu.Clear();
                unvani.Clear();
                yetkilikisi.Clear();
                vergidairesi.Clear();
                vergino.Clear();



            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
        public void listele2()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebedata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alinanteklifler", con);
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void teklifToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tekliftarihi.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alinanteklif";
            a.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebedata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from alinanteklifler where tekliftarihi='" + tekliftarihi.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele2();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    tekliftarihi.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
