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
    public partial class yenifirma : Form
    {
        public yenifirma()
        {
            InitializeComponent();
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
            adi.Clear();
            soyadi.Clear();
            tckimlik.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            ceptelefon.Clear();
            donem1.Clear();
            donem2.Clear();
            adres.Clear();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adi.Clear();
            soyadi.Clear();
            tckimlik.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            ceptelefon.Clear();
            donem1.Clear();
            donem2.Clear();
            adres.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into firma(unvani,adisoyadi,tckimlikno,vergidairesi,telefon,cep,donem,adres) values ('" + adi.Text + "','" + soyadi.Text + "','" + tckimlik.Text + "','" + vergidairesi.Text + "','" + telefon.Text + "','" + ceptelefon.Text + "','" + donem1.Text + "-" + donem2.Text + "','" + adres.Text + "')");
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();
                
                MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                adi.Clear();
                soyadi.Clear();
                tckimlik.Clear();
                vergidairesi.Clear();
                telefon.Clear();
                ceptelefon.Clear();
                donem1.Clear();
                donem2.Clear();
                adres.Clear();

                kayitlifirma a = new kayitlifirma();
                a.Show();
                this.Hide();




            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void kayderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde sadece 'Demo' adlı firmayı kullanabilirsiniz!", "Deneme Sürümü");
        }

        private void yenifirma_Load(object sender, EventArgs e)
        {

        }

       
    }
}
