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
    public partial class alisislemi : Form
    {
        public alisislemi()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void alisislemi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet7.alisislemipesin' table. You can move, or remove it, as needed.
            this.alisislemipesinTableAdapter1.Fill(this.onmuhasebesmartdataDataSet7.alisislemipesin);
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet6.alisislemiveresiye' table. You can move, or remove it, as needed.
            this.alisislemiveresiyeTableAdapter1.Fill(this.onmuhasebesmartdataDataSet6.alisislemiveresiye);
            stokadetlabel.Visible = false;
            // TODO: This line of code loads data into the 'onmuhasebealissatisDataSet3.alisislemipesin' table. You can move, or remove it, as needed.
            this.alisislemipesinTableAdapter.Fill(this.onmuhasebealissatisDataSet3.alisislemipesin);
            // TODO: This line of code loads data into the 'onmuhasebealissatisDataSet2.alisislemitaksit' table. You can move, or remove it, as needed.
            this.alisislemitaksitTableAdapter.Fill(this.onmuhasebealissatisDataSet2.alisislemitaksit);
            // TODO: This line of code loads data into the 'onmuhasebealissatisDataSet1.alisislemiveresiye' table. You can move, or remove it, as needed.
            this.alisislemiveresiyeTableAdapter.Fill(this.onmuhasebealissatisDataSet1.alisislemiveresiye);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
                if (belgeno.Text == "")
                {
                    MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
                }
                else
                {


                    double sonuc = Convert.ToDouble(veresiyefiyat.Text);
                    int kdv = int.Parse(kdvveresiye.Text);
                    double carpim;
                    carpim = (kdv * sonuc)/100 + (sonuc);
                    veresiyefiyat.Text = carpim.ToString("c");

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alisislemiveresiye(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat) values ('" + carikoduveresiye.Text + "','" + unvanipesin.Text + "','" + islemtarihi.Text + "','" + vadetarihi.Text + "','" + belgeno.Text + "','" + odemesekli.Text + "','" + aciklama.Text + "','" + faturano.Text + "','" + faturatarihi.Text + "','" + faturatipi.Text + "','" + irsaliyeno.Text + "','" + irsaliyetarihi.Text + "','" + sevktarihi.Text + "','" + veresiyefiyat.Text + "')");
                        komut.Connection = baglan;
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        listele();
                        MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                        carikoduveresiye.Clear();
                        unvanipesin.Clear();
                        islemtarihi.Clear();
                        vadetarihi.Clear();
                        belgeno.Clear();
                        odemesekli.SelectedIndex = -1;
                        aciklama.Clear();
                        faturano.Clear();
                        faturatarihi.Clear();
                        faturatipi.SelectedIndex = -1;
                        irsaliyeno.Clear();
                        irsaliyetarihi.Clear();
                        sevktarihi.Clear();
                        veresiyefiyat.Clear();
                        kdvveresiye.SelectedIndex = -1;


                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    int stokadet = int.Parse(stokadetlabel.Text);
                    int tplstokadet = int.Parse(stokadettext.Text);
                    int toplamstok;
                    toplamstok = stokadet + tplstokadet;
                    try
                    {
                        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglanti.Open();
                        OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvani.Text + "', karorani='" + toplamstok + "' Where stokadi='"+unvani.Text+"'");
                        con.Connection = baglanti;
                        con.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
                if (belgenotaksit.Text == "")
                {
                    MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
                }
                else
                {

                    double sonuc = Convert.ToDouble(fiyattaksit.Text);
                    int kdv = int.Parse(kdvtaksit.Text);
                    double carpim;
                    carpim = (kdv * sonuc) / 100 + (sonuc);
                    fiyattaksit.Text = carpim.ToString("c");
                    double taksitSayisi = Convert.ToDouble(taksit.Text);
                    double tutar = carpim / taksitSayisi;

                    for (int i = 1; i <= taksitSayisi; i++)
                    {
                        DateTime taksitTarihi = DateTime.Now.AddMonths(i);
                        //Hafta Sonuna Denk Gelmesin:
                        switch (taksitTarihi.DayOfWeek)
                        {
                            case DayOfWeek.Saturday:
                                taksitTarihi = taksitTarihi.AddDays(2);
                                break;
                            case DayOfWeek.Sunday:
                                taksitTarihi = taksitTarihi.AddDays(1);
                                break;
                        }
                    }

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebealissatis.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alisislemitaksit(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat,taksit) values ('" + carikodutaksitli.Text + "','" + unvanitaksit.Text + "','" + islemtarihitaksit.Text + "','" + vadetarihitaksit.Text + "','" + belgenotaksit.Text + "','" + odemeseklitaksit.Text + "','" + aciklamataksit.Text + "','" + faturanotaksit.Text + "','" + faturatarihitaksit.Text + "','" + faturatipitaksit.Text + "','" + irsaliyenotaksit.Text + "','" + irsaliyetarihitaksit.Text + "','" + sevktarihitaksit.Text + "','" + fiyattaksit.Text + "','" + tutar.ToString("C2") + "(" + taksit.Text + " Taksit" + ")" +   "')");
                        komut.Connection = baglan;
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        listele3();
                        MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                        carikodutaksitli.Clear();
                        unvanitaksit.Clear();
                        islemtarihitaksit.Clear();
                        vadetarihitaksit.Clear();
                        belgenotaksit.Clear();
                        odemeseklitaksit.SelectedIndex = -1;
                        aciklamataksit.Clear();
                        faturanotaksit.Clear();
                        faturatarihitaksit.Clear();
                        faturatipitaksit.SelectedIndex = -1;
                        irsaliyenotaksit.Clear();
                        irsaliyetarihitaksit.Clear();
                        sevktarihitaksit.Clear();
                        fiyattaksit.Clear();
                        kdvtaksit.SelectedIndex = -1;
                        taksit.SelectedIndex = -1;

                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                int stokadet = int.Parse(stokadetlabel.Text);
                int tplstokadet = int.Parse(stokadettaksitli.Text);
                int toplamstok;
                toplamstok = stokadet + tplstokadet;
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvanitaksit.Text + "', karorani='" + toplamstok + "' Where stokadi='" + unvanitaksit.Text + "'");
                    con.Connection = baglanti;
                    con.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }
        public void listele()
        {
            

            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alisislemiveresiye", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button12_Click(object sender, EventArgs e)
        {
          
                if (belgenopesin.Text == "")
                {
                    MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
                }
                else
                {

                    double sonuc = Convert.ToDouble(fiyatpesin.Text);
                    int kdv = int.Parse(kdvpesin.Text);
                    double carpim;
                    carpim = (kdv * sonuc) / 100 + (sonuc);
                    fiyatpesin.Text = carpim.ToString("c");

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alisislemipesin(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat) values ('" + carikodupesin.Text + "','" + unvanipesin.Text + "','" + islemtarihipesin.Text + "','" + vadetarihipesin.Text + "','" + belgenopesin.Text + "','" + odemeseklipesin.Text + "','" + aciklamapesin.Text + "','" + faturanopesin.Text + "','" + faturatarihipesin.Text + "','" + faturatipipesin.Text + "','" + irsaliyenopesin.Text + "','" + irsaliyetarihipesin.Text + "','" + sevktarihipesin.Text + "','" + fiyatpesin.Text + "')");
                        komut.Connection = baglan;
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        listele2();
                        MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                        carikodupesin.Clear();
                        unvanipesin.Clear();
                        islemtarihipesin.Clear();
                        vadetarihipesin.Clear();
                        belgenopesin.Clear();
                        odemeseklipesin.SelectedIndex = -1;
                        aciklamapesin.Clear();
                        faturanopesin.Clear();
                        faturatarihipesin.Clear();
                        faturatipipesin.SelectedIndex = -1;
                        irsaliyenopesin.Clear();
                        irsaliyetarihipesin.Clear();
                        sevktarihipesin.Clear();
                        fiyatpesin.Clear();
                        kdvpesin.SelectedIndex = -1;


                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                int stokadet = int.Parse(stokadetlabel.Text);
                int tplstokadet = int.Parse(stokadetpesin.Text);
                int toplamstok;
                toplamstok = stokadet + tplstokadet;
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvanipesin.Text + "', karorani='" + toplamstok + "' Where stokadi='" + unvanipesin.Text + "'");
                    con.Connection = baglanti;
                    con.ExecuteNonQuery();
                    baglanti.Close();
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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alisislemipesin", con);
            adpt.Fill(dt);
            dataGridView3.DataSource = dt;

        }
        public void listele3()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebealissatis.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alisislemitaksit", con);
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            carikoduveresiye.Clear();
            unvanipesin.Clear();
            islemtarihi.Clear();
            vadetarihi.Clear();
            belgeno.Clear();
            odemesekli.SelectedIndex = -1;
            aciklama.Clear();
            faturano.Clear();
            faturatarihi.Clear();
            faturatipi.SelectedIndex = -1;
            irsaliyeno.Clear();
            irsaliyetarihi.Clear();
            sevktarihi.Clear();
            veresiyefiyat.Clear();
            kdvveresiye.SelectedIndex = -1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            carikodutaksitli.Clear();
            unvanitaksit.Clear();
            islemtarihitaksit.Clear();
            vadetarihitaksit.Clear();
            belgenotaksit.Clear();
            odemeseklitaksit.SelectedIndex = -1;
            aciklamataksit.Clear();
            faturanotaksit.Clear();
            faturatarihitaksit.Clear();
            faturatipitaksit.SelectedIndex = -1;
            irsaliyenotaksit.Clear();
            irsaliyetarihitaksit.Clear();
            sevktarihitaksit.Clear();
            fiyattaksit.Clear();
            kdvtaksit.SelectedIndex = -1;
            taksit.SelectedIndex = -1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            carikodupesin.Clear();
            unvanipesin.Clear();
            islemtarihipesin.Clear();
            vadetarihipesin.Clear();
            belgenopesin.Clear();
            odemeseklipesin.SelectedIndex = -1;
            aciklamapesin.Clear();
            faturanopesin.Clear();
            faturatarihipesin.Clear();
            faturatipipesin.SelectedIndex = -1;
            irsaliyenopesin.Clear();
            irsaliyetarihipesin.Clear();
            sevktarihipesin.Clear();
            fiyatpesin.Clear();
            kdvpesin.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
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

        private void button13_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alisislemiveresiye";
            a.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            stokalis a = new stokalis();
            a.label2.Text = "alisislemi";
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            stokalis a = new stokalis();
            a.label2.Text = "alisislemitaksit";
            a.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            stokalis a = new stokalis();
            a.label2.Text = "alisislemipesin";
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alisislemitaksit";
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alisislemipesin";
            a.Show();
        }

        private void taksitliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (belgenotaksit.Text == "")
            {
                MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
            }
            else
            {

                double sonuc = Convert.ToDouble(fiyattaksit.Text);
                int kdv = int.Parse(kdvtaksit.Text);
                double carpim;
                carpim = (kdv * sonuc) / 100 + (sonuc);
                fiyattaksit.Text = carpim.ToString("c");
                double taksitSayisi = Convert.ToDouble(taksit.Text);
                double tutar = carpim / taksitSayisi;

                for (int i = 1; i <= taksitSayisi; i++)
                {
                    DateTime taksitTarihi = DateTime.Now.AddMonths(i);
                    //Hafta Sonuna Denk Gelmesin:
                    switch (taksitTarihi.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                            taksitTarihi = taksitTarihi.AddDays(2);
                            break;
                        case DayOfWeek.Sunday:
                            taksitTarihi = taksitTarihi.AddDays(1);
                            break;
                    }
                }

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebealissatis.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisislemitaksit(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat,taksit) values ('" + carikodutaksitli.Text + "','" + unvanitaksit.Text + "','" + islemtarihitaksit.Text + "','" + vadetarihitaksit.Text + "','" + belgenotaksit.Text + "','" + odemeseklitaksit.Text + "','" + aciklamataksit.Text + "','" + faturanotaksit.Text + "','" + faturatarihitaksit.Text + "','" + faturatipitaksit.Text + "','" + irsaliyenotaksit.Text + "','" + irsaliyetarihitaksit.Text + "','" + sevktarihitaksit.Text + "','" + fiyattaksit.Text + "','" + tutar.ToString("C2") + "(" + taksit.Text + " Taksit" + ")" + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele3();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    carikodutaksitli.Clear();
                    unvanitaksit.Clear();
                    islemtarihitaksit.Clear();
                    vadetarihitaksit.Clear();
                    belgenotaksit.Clear();
                    odemeseklitaksit.SelectedIndex = -1;
                    aciklamataksit.Clear();
                    faturanotaksit.Clear();
                    faturatarihitaksit.Clear();
                    faturatipitaksit.SelectedIndex = -1;
                    irsaliyenotaksit.Clear();
                    irsaliyetarihitaksit.Clear();
                    sevktarihitaksit.Clear();
                    fiyattaksit.Clear();
                    kdvtaksit.SelectedIndex = -1;
                    taksit.SelectedIndex = -1;

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            int stokadet = int.Parse(stokadetlabel.Text);
            int tplstokadet = int.Parse(stokadettaksitli.Text);
            int toplamstok;
            toplamstok = stokadet + tplstokadet;
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglanti.Open();
                OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvanitaksit.Text + "', karorani='" + toplamstok + "' Where stokadi='" + unvanitaksit.Text + "'");
                con.Connection = baglanti;
                con.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void veresiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (belgeno.Text == "")
            {
                MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
            }
            else
            {


                double sonuc = Convert.ToDouble(veresiyefiyat.Text);
                int kdv = int.Parse(kdvveresiye.Text);
                double carpim;
                carpim = (kdv * sonuc) / 100 + (sonuc);
                veresiyefiyat.Text = carpim.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisislemiveresiye(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat) values ('" + carikoduveresiye.Text + "','" + unvanipesin.Text + "','" + islemtarihi.Text + "','" + vadetarihi.Text + "','" + belgeno.Text + "','" + odemesekli.Text + "','" + aciklama.Text + "','" + faturano.Text + "','" + faturatarihi.Text + "','" + faturatipi.Text + "','" + irsaliyeno.Text + "','" + irsaliyetarihi.Text + "','" + sevktarihi.Text + "','" + veresiyefiyat.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    carikoduveresiye.Clear();
                    unvanipesin.Clear();
                    islemtarihi.Clear();
                    vadetarihi.Clear();
                    belgeno.Clear();
                    odemesekli.SelectedIndex = -1;
                    aciklama.Clear();
                    faturano.Clear();
                    faturatarihi.Clear();
                    faturatipi.SelectedIndex = -1;
                    irsaliyeno.Clear();
                    irsaliyetarihi.Clear();
                    sevktarihi.Clear();
                    veresiyefiyat.Clear();
                    kdvveresiye.SelectedIndex = -1;


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                int stokadet = int.Parse(stokadetlabel.Text);
                int tplstokadet = int.Parse(stokadettext.Text);
                int toplamstok;
                toplamstok = stokadet + tplstokadet;
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglanti.Open();
                    OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvani.Text + "', karorani='" + toplamstok + "' Where stokadi='" + unvani.Text + "'");
                    con.Connection = baglanti;
                    con.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void peşinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (belgenopesin.Text == "")
            {
                MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
            }
            else
            {

                double sonuc = Convert.ToDouble(fiyatpesin.Text);
                int kdv = int.Parse(kdvpesin.Text);
                double carpim;
                carpim = (kdv * sonuc) / 100 + (sonuc);
                fiyatpesin.Text = carpim.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisislemipesin(carikodu,unvani,islemtarihi,vadetarihi,belgeno,odemesekli,aciklama,faturano,faturatarihi,faturatipi,irsaliyeno,irsaliyetarihi,sevktarihi,fiyat) values ('" + carikodupesin.Text + "','" + unvanipesin.Text + "','" + islemtarihipesin.Text + "','" + vadetarihipesin.Text + "','" + belgenopesin.Text + "','" + odemeseklipesin.Text + "','" + aciklamapesin.Text + "','" + faturanopesin.Text + "','" + faturatarihipesin.Text + "','" + faturatipipesin.Text + "','" + irsaliyenopesin.Text + "','" + irsaliyetarihipesin.Text + "','" + sevktarihipesin.Text + "','" + fiyatpesin.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele2();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    carikodupesin.Clear();
                    unvanipesin.Clear();
                    islemtarihipesin.Clear();
                    vadetarihipesin.Clear();
                    belgenopesin.Clear();
                    odemeseklipesin.SelectedIndex = -1;
                    aciklamapesin.Clear();
                    faturanopesin.Clear();
                    faturatarihipesin.Clear();
                    faturatipipesin.SelectedIndex = -1;
                    irsaliyenopesin.Clear();
                    irsaliyetarihipesin.Clear();
                    sevktarihipesin.Clear();
                    fiyatpesin.Clear();
                    kdvpesin.SelectedIndex = -1;


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            int stokadet = int.Parse(stokadetlabel.Text);
            int tplstokadet = int.Parse(stokadetpesin.Text);
            int toplamstok;
            toplamstok = stokadet + tplstokadet;
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglanti.Open();
                OleDbCommand con = new OleDbCommand("Update yenistok set stokadi='" + unvanipesin.Text + "', karorani='" + toplamstok + "' Where stokadi='" + unvanipesin.Text + "'");
                con.Connection = baglanti;
                con.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgeno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgenotaksit.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgenopesin.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from alisislemi where belgeno='" + belgenopesin.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    belgenopesin.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from alisislemi where belgeno='" + belgenotaksit.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    belgenotaksit.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from alisislemi where belgeno='" + belgeno.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    belgeno.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
