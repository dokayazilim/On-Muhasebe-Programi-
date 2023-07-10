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
    public partial class yeniurun : Form
    {
        public yeniurun()
        {
            InitializeComponent();
        }

        private void yeniurun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet25.urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter1.Fill(this.onmuhasebesmartdataDataSet25.urun);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
                if (alisfiyatibir.Text != "")
                {
                    double kdvsonuc = Convert.ToDouble(aliskdvbir.Text);
                    double sonuc = Convert.ToDouble(alisfiyatibir.Text);
                    alisfiyatibir.Text = (sonuc + (sonuc * kdvsonuc) / 100).ToString("c");
                }
                else { }

                if (alisfiyatiiki.Text != "")
                {
                    double kdvsonuciki = Convert.ToDouble(aliskdviki.Text);
                    double sonuc2 = Convert.ToDouble(alisfiyatiiki.Text);
                    alisfiyatiiki.Text = (sonuc2 + (sonuc2 * kdvsonuciki) / 100).ToString("c");
                }
                else { }

                if (alisfiyatiuc.Text != "")
                {
                    double kdvsonucuc = Convert.ToDouble(aliskdvuc.Text);
                    double sonuc3 = Convert.ToDouble(alisfiyatiuc.Text);
                    alisfiyatiuc.Text = (sonuc3 + (sonuc3 * kdvsonucuc) / 100).ToString("c");
                }
                else { }
                if (satisfiyatibir.Text != "")
                {
                    double kdvsonucdort = Convert.ToDouble(satiskdvbir.Text);
                    double sonuc4 = Convert.ToDouble(satisfiyatibir.Text);
                    satisfiyatibir.Text = (sonuc4 + (sonuc4 * kdvsonucdort) / 100).ToString("c");
                }
                else { }
                if (satisfiyatiiki.Text != "")
                {
                    double kdvsonucbes = Convert.ToDouble(satiskdviki.Text);
                    double sonuc5 = Convert.ToDouble(satisfiyatiiki.Text);
                    satisfiyatiiki.Text = (sonuc5 + (sonuc5 * kdvsonucbes) / 100).ToString("c");
                }
                else { }
                if (satisfiyatiuc.Text != "")
                {
                    double kdvsonucalti = Convert.ToDouble(satiskdvuc.Text);
                    double sonuc6 = Convert.ToDouble(satisfiyatiuc.Text);
                    satisfiyatiuc.Text = (sonuc6 + (sonuc6 * kdvsonucalti) / 100).ToString("c");
                }
                else { }         
               
                
                
                
                

                

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into urun(urunkodu,urunadi,bolumadi,barkod,olcubirimi,kritikdeger,durumu,tartilirurun,kdv,vade,stokdevir,depo,aciklama,alisfiyatibir,alisfiyatiiki,alisfiyatiuc,satisfiyatibir,satisfiyatiiki,satisfiyatiuc) values ('" + urunkodu.Text + "','" + urunadi.Text + "','" + bolumadi.Text + "','" + barkod.Text + "','" + olcubirimi.Text + "','" + kritikdeger.Text + "','" + durumu.Text + "','" + tartilirurun.Text + "','" + kdv.Text + "','" + vade.Text + "','" + stokdevir.Text + "','" + depo.Text + "','" + aciklama.Text + "','" + alisfiyatibir.Text + "','" + alisfiyatiiki.Text + "','" + alisfiyatiuc.Text + "','" + satisfiyatibir.Text + "','" + satisfiyatiiki.Text + "','" + satisfiyatiuc.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    urunkodu.Clear();
                    urunadi.Clear();
                    bolumadi.Clear();
                    barkod.Clear();
                    olcubirimi.Clear();
                    kritikdeger.Clear();
                    durumu.SelectedIndex = -1;
                    tartilirurun.SelectedIndex = -1;
                    kdv.SelectedIndex = -1;
                    vade.Clear();
                    stokdevir.Clear();
                    depo.Text = "MERKEZ";
                    aciklama.Clear();
                    alisfiyatibir.Clear();
                    alisfiyatiiki.Clear();
                    alisfiyatiuc.Clear();
                    satisfiyatibir.Clear();
                    satisfiyatiiki.Clear();
                    satisfiyatiuc.Clear();
                    aliskdvbir.SelectedIndex = -1;
                    aliskdviki.SelectedIndex = -1;
                    aliskdvuc.SelectedIndex = -1;
                    satiskdvbir.SelectedIndex = -1;
                    satiskdviki.SelectedIndex = -2;
                    satiskdvuc.SelectedIndex = -3;
                  



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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from urun", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunkodu.Clear();
            urunadi.Clear();
            bolumadi.Clear();
            barkod.Clear();
            olcubirimi.Clear();
            kritikdeger.Clear();
            durumu.SelectedIndex = -1;
            tartilirurun.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
            vade.Clear();
            stokdevir.Clear();
            depo.Text = "MERKEZ";
            aciklama.Clear();
            alisfiyatibir.Clear();
            alisfiyatiiki.Clear();
            alisfiyatiuc.Clear();
            satisfiyatibir.Clear();
            satisfiyatiiki.Clear();
            satisfiyatiuc.Clear();
            aliskdvbir.SelectedIndex = -1;
            aliskdviki.SelectedIndex = -1;
            aliskdvuc.SelectedIndex = -1;
            satiskdvbir.SelectedIndex = -1;
            satiskdviki.SelectedIndex = -2;
            satiskdvuc.SelectedIndex = -3;

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

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunkodu.Clear();
            urunadi.Clear();
            bolumadi.Clear();
            barkod.Clear();
            olcubirimi.Clear();
            kritikdeger.Clear();
            durumu.SelectedIndex = -1;
            tartilirurun.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
            vade.Clear();
            stokdevir.Clear();
            depo.Text = "MERKEZ";
            aciklama.Clear();
            alisfiyatibir.Clear();
            alisfiyatiiki.Clear();
            alisfiyatiuc.Clear();
            satisfiyatibir.Clear();
            satisfiyatiiki.Clear();
            satisfiyatiuc.Clear();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into urun(urunkodu,urunadi,bolumadi,barkod,olcubirimi,kritikdeger,durumu,tartilirurun,kdv,vade,stokdevir,depo,aciklama,alisfiyatibir,alisfiyatiiki,alisfiyatiuc,satisfiyatibir,satisfiyatiiki,satisfiyatiuc) values ('" + urunkodu.Text + "','" + urunadi.Text + "','" + bolumadi.Text + "','" + barkod.Text + "','" + olcubirimi.Text + "','" + kritikdeger.Text + "','" + durumu.Text + "','" + tartilirurun.Text + "','" + kdv.Text + "','" + vade.Text + "','" + stokdevir.Text + "','" + depo.Text + "','" + aciklama.Text + "','" + alisfiyatibir.Text + "','" + alisfiyatiiki.Text + "','" + alisfiyatiuc.Text + "','" + satisfiyatibir.Text + "','" + satisfiyatiiki.Text + "','" + satisfiyatiuc.Text + "')");
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
            

        }

        private void hesapMakinesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void alisfiyatibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           



        }

        private void aliskdviki_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void aliskdvuc_CheckedChanged(object sender, EventArgs e)
        {
            
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
                    OleDbCommand komut = new OleDbCommand("delete from urun where urunkodu='" + urunkodu.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    urunkodu.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
