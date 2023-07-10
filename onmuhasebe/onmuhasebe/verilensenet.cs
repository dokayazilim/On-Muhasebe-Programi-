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
    public partial class verilensenet : Form
    {
        public verilensenet()
        {
            InitializeComponent();
        }

        private void verilensenet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet17.verilensenetler' table. You can move, or remove it, as needed.
            this.verilensenetlerTableAdapter1.Fill(this.onmuhasebesmartdataDataSet17.verilensenetler);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into verilensenetler(carikodu,unvani,yetkilisi,kayittarihi,senetno,vadetarihi,tutari,alacakliunvani,ihtilafmahkemesi,adsoyad,tckimlikno,adres,vergidairesino,adsoyadkefil,tckimliknokefil,adreskefil,vergidairesinokefil,aciklama,senetdurumu) values ('" + carikodu.Text + "','" + unvani.Text + "','" + yetkilisi.Text + "','" + kayittarihi.Text + "','" + senetno.Text + "','" + vadetarihi.Text + "','" + tutar.Text + "','" + alacakliunvani.Text + "','" + ihtilafmahkemesi.Text + "','" + adsoyad.Text + "','" + tckimlikno.Text + "','" + adres.Text + "','" + vergidairesino.Text + "','" + adsoyadkefil.Text + "','" + tckimliknokefil.Text + "','" + adreskefil.Text + "','" + vergidairesinokefil.Text + "','" + aciklama.Text + "','" + senetdurumu.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,alacak) values ('" + kayittarihi.Text + "','" + vadetarihi.Text + "','" + senetno.Text + "','" + "Peşin" + "','" + aciklama.Text + "','" + tutar.Text + "')");
                    komut2.Connection = baglanti;
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    carikodu.Clear();
                    unvani.Clear();
                    yetkilisi.Clear();
                    kayittarihi.Clear();
                    senetno.Clear();
                    vadetarihi.Clear();
                    tutar.Clear();
                    alacakliunvani.Clear();
                    ihtilafmahkemesi.SelectedIndex = -1;
                    adsoyad.Clear();
                    tckimlikno.Clear();
                    adres.Clear();
                    vergidairesino.Clear();
                    adsoyadkefil.Clear();
                    tckimliknokefil.Clear();
                    adreskefil.Clear();
                    vergidairesinokefil.Clear();
                    aciklama.Clear();
                    senetdurumu.Clear();
                   


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carikodu.Clear();
            unvani.Clear();
            yetkilisi.Clear();
            kayittarihi.Clear();
            senetno.Clear();
            vadetarihi.Clear();
            tutar.Clear();
            alacakliunvani.Clear();
            ihtilafmahkemesi.SelectedIndex = -1;
            adsoyad.Clear();
            tckimlikno.Clear();
            adres.Clear();
            vergidairesino.Clear();
            adsoyadkefil.Clear();
            tckimliknokefil.Clear();
            adreskefil.Clear();
            vergidairesinokefil.Clear();
            aciklama.Clear();
            senetdurumu.Clear();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carikodu.Clear();
            unvani.Clear();
            yetkilisi.Clear();
            kayittarihi.Clear();
            senetno.Clear();
            vadetarihi.Clear();
            tutar.Clear();
            alacakliunvani.Clear();
            ihtilafmahkemesi.SelectedIndex = -1;
            adsoyad.Clear();
            tckimlikno.Clear();
            adres.Clear();
            vergidairesino.Clear();
            adsoyadkefil.Clear();
            tckimliknokefil.Clear();
            adreskefil.Clear();
            vergidairesinokefil.Clear();
            aciklama.Clear();
            senetdurumu.Clear();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from verilensenetler", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into verilensenetler(carikodu,unvani,yetkilisi,kayittarihi,senetno,vadetarihi,tutari,alacakliunvani,ihtilafmahkemesi,adsoyad,tckimlikno,adres,vergidairesino,adsoyadkefil,tckimliknokefil,adreskefil,vergidairesinokefil,aciklama,senetdurumu) values ('" + carikodu.Text + "','" + unvani.Text + "','" + yetkilisi.Text + "','" + kayittarihi.Text + "','" + senetno.Text + "','" + vadetarihi.Text + "','" + tutar.Text + "','" + alacakliunvani.Text + "','" + ihtilafmahkemesi.Text + "','" + adsoyad.Text + "','" + tckimlikno.Text + "','" + adres.Text + "','" + vergidairesino.Text + "','" + adsoyadkefil.Text + "','" + tckimliknokefil.Text + "','" + adreskefil.Text + "','" + vergidairesinokefil.Text + "','" + aciklama.Text + "','" + senetdurumu.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,alacak) values ('" + kayittarihi.Text + "','" + vadetarihi.Text + "','" + senetno.Text + "','" + "Peşin" + "','" + aciklama.Text + "','" + tutar.Text + "')");
                    komut2.Connection = baglanti;
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    carikodu.Clear();
                    unvani.Clear();
                    yetkilisi.Clear();
                    kayittarihi.Clear();
                    senetno.Clear();
                    vadetarihi.Clear();
                    tutar.Clear();
                    alacakliunvani.Clear();
                    ihtilafmahkemesi.SelectedIndex = -1;
                    adsoyad.Clear();
                    tckimlikno.Clear();
                    adres.Clear();
                    vergidairesino.Clear();
                    adsoyadkefil.Clear();
                    tckimliknokefil.Clear();
                    adreskefil.Clear();
                    vergidairesinokefil.Clear();
                    aciklama.Clear();
                    senetdurumu.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
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
                    OleDbCommand komut = new OleDbCommand("delete from verilensenetler where senetno='" + senetno.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    senetno.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "verilensenet";
            a.Show();
        }
    }
}
