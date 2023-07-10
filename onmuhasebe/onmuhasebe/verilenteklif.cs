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
    public partial class verilenteklif : Form
    {
        public verilenteklif()
        {
            InitializeComponent();
        }

        private void verilenteklif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet18.verilenteklifler' table. You can move, or remove it, as needed.
            this.verilentekliflerTableAdapter1.Fill(this.onmuhasebesmartdataDataSet18.verilenteklifler);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
          


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into verilenteklifler(tekliftarihi,teklifno,teklifdurumu,gecerliliktarihi,teslimatsuresi,konu,dipnot,carikodu,unvani,yetkilikisi,vergidairesi,vergino) values ('" + tekliftarihi.Text + "','" + teklifno.Text + "','" + teklifdurumu.Text + "','" + gecerliliktarihi.Text + "','" + teslimatsuresi.Text + "','" + konu.Text + "','" + dipnot.Text + "','" + carikodu.Text + "','" + unvani.Text + "','" + yetkilikisi.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "')");
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

        public void listele2()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from verilenteklifler", con);
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;

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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
          



                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into verilenteklifler(tekliftarihi,teklifno,teklifdurumu,gecerliliktarihi,teslimatsuresi,konu,dipnot,carikodu,unvani,yetkilikisi,vergidairesi,vergino) values ('" + tekliftarihi.Text + "','" + teklifno.Text + "','" + teklifdurumu.Text + "','" + gecerliliktarihi.Text + "','" + teslimatsuresi.Text + "','" + konu.Text + "','" + dipnot.Text + "','" + carikodu.Text + "','" + unvani.Text + "','" + yetkilikisi.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "')");
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

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void teklifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "verilenteklif";
            a.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from verilenteklifler where tekliftarihi='" + tekliftarihi.Text + "'");
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
