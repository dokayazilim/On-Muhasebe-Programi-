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
    public partial class alinansenet : Form
    {
        public alinansenet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alinansenet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet2.alinansenetler' table. You can move, or remove it, as needed.
            this.alinansenetlerTableAdapter1.Fill(this.onmuhasebesmartdataDataSet2.alinansenetler);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (senetno.Text == "")
                {
                    MessageBox.Show("Senet No alanı boş geçilemez!", "Uyarı");
                }
                else
                {

                    double sonuc = Convert.ToDouble(tutar.Text);
                    tutar.Text = sonuc.ToString("c");

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alinansenetler(carikodu,unvani,yetkilisi,kayittarihi,senetno,vadetarihi,tutari,alacakliunvani,ihtilafmahkemesi,adsoyad,tckimlikno,adres,vergidairesino,adsoyadkefil,tckimliknokefil,adreskefil,vergidairesinokefil,aciklama,senetdurumu) values ('" + carikodu.Text + "','" + unvani.Text + "','" + yetkilisi.Text + "','" + kayittarihi.Text + "','" + senetno.Text + "','" + vadetarihi.Text + "','" + tutar.Text + "','" + alacakliunvani.Text + "','" + ihtilafmahkemesi.Text + "','" + adsoyad.Text + "','" + tckimlikno.Text + "','" + adres.Text + "','" + vergidairesino.Text + "','" + adsoyadkefil.Text + "','" + tckimliknokefil.Text + "','" + adreskefil.Text + "','" + vergidairesinokefil.Text + "','" + aciklama.Text + "','" + senetdurumu.Text + "')");
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
                        OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,borc) values ('" + kayittarihi.Text + "','" + vadetarihi.Text + "','" + senetno.Text + "','" + "Peşin" + "','" + aciklama.Text + "','" + tutar.Text + "')");
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
            }

            public void listele()
        {
            

            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alinansenetler", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

            private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (dataGridView1.RowCount >= 10)
                {
                    MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
                }
                else
                {

                    double sonuc = Convert.ToDouble(tutar.Text);
                    tutar.Text = sonuc.ToString("c");

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alinansenetler(carikodu,unvani,yetkilisi,kayittarihi,senetno,vadetarihi,tutari,alacakliunvani,ihtilafmahkemesi,adsoyad,tckimlikno,adres,vergidairesino,adsoyadkefil,tckimliknokefil,adreskefil,vergidairesinokefil,aciklama,senetdurumu) values ('" + carikodu.Text + "','" + unvani.Text + "','" + yetkilisi.Text + "','" + kayittarihi.Text + "','" + senetno.Text + "','" + vadetarihi.Text + "','" + tutar.Text + "','" + alacakliunvani.Text + "','" + ihtilafmahkemesi.Text + "','" + adsoyad.Text + "','" + tckimlikno.Text + "','" + adres.Text + "','" + vergidairesino.Text + "','" + adsoyadkefil.Text + "','" + tckimliknokefil.Text + "','" + adreskefil.Text + "','" + vergidairesinokefil.Text + "','" + aciklama.Text + "','" + senetdurumu.Text + "')");
                        komut.Connection = baglan;
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        listele();
                        MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
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

            private void button3_Click(object sender, EventArgs e)
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
                        OleDbCommand komut = new OleDbCommand("delete from alinansenetler where senetno='" + senetno.Text + "'");
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

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                senetno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                carilistesi a = new carilistesi();
                a.Show();
            }

            private void button4_Click_1(object sender, EventArgs e)
            {
                carikayitlari a = new carikayitlari();
                a.label2.Text = "alinansenet";
                a.Show();
            }

        }
    }

