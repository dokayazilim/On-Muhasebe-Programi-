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
    public partial class yenicari : Form
    {
        public yenicari()
        {
            InitializeComponent();
        }

        private void yenicari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet20.carihesap' table. You can move, or remove it, as needed.
            this.carihesapTableAdapter1.Fill(this.onmuhasebesmartdataDataSet20.carihesap);
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adi.Text == "")
            {
                MessageBox.Show("Lütfen öncelikle bir şirket seçiniz!", "Uyarı");
            }
            else
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into carihesap(adi,soyadi,tckimlikno,vergidairesi,vergino,il,ilce,semt,mahalle,cadde,sokak,aptadi,aptno,postakodu,telefon,fax,cep,web,eposta) values ('" + adi.Text + "','" + soyadi.Text + "','" + tckimlikno.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "','" + il.Text + "','" + ilce.Text + "','" + semt.Text + "','" + mahalle.Text + "','" + cadde.Text + "','" + sokak.Text + "','" + aptadi.Text + "','" + aptno.Text + "','" + postakodu.Text + "','" + telefon.Text + "','" + fax.Text + "','" + cep.Text + "','" + web.Text + "','" + eposta.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");

                    adi.Clear();
                    soyadi.Clear();
                    tckimlikno.Clear();
                    vergidairesi.Clear();
                    vergino.Clear();
                    il.Clear();
                    ilce.Clear();
                    semt.Clear();
                    mahalle.Clear();
                    cadde.Clear();
                    sokak.Clear();
                    aptadi.Clear();
                    aptno.Clear();
                    postakodu.Clear();
                    telefon.Clear();
                    fax.Clear();
                    cep.Clear();
                    web.Clear();
                    eposta.Clear();




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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from carihesap", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adi.Clear();
            soyadi.Clear();
            tckimlikno.Clear();
            vergidairesi.Clear();
            vergino.Clear();
            il.Clear();
            ilce.Clear();
            semt.Clear();
            mahalle.Clear();
            cadde.Clear();
            sokak.Clear();
            aptadi.Clear();
            aptno.Clear();
            postakodu.Clear();
            telefon.Clear();
            fax.Clear();
            cep.Clear();
            web.Clear();
            eposta.Clear();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
          


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into carihesap(adi,soyadi,tckimlikno,vergidairesi,vergino,il,ilce,semt,mahalle,cadde,sokak,aptadi,aptno,postakodu,telefon,fax,cep,web,eposta) values ('" + adi.Text + "','" + soyadi.Text + "','" + tckimlikno.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "','" + il.Text + "','" + ilce.Text + "','" + semt.Text + "','" + mahalle.Text + "','" + cadde.Text + "','" + sokak.Text + "','" + aptadi.Text + "','" + aptno.Text + "','" + postakodu.Text + "','" + telefon.Text + "','" + fax.Text + "','" + cep.Text + "','" + web.Text + "','" + eposta.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");

                    adi.Clear();
                    soyadi.Clear();
                    tckimlikno.Clear();
                    vergidairesi.Clear();
                    vergino.Clear();
                    il.Clear();
                    ilce.Clear();
                    semt.Clear();
                    mahalle.Clear();
                    cadde.Clear();
                    sokak.Clear();
                    aptadi.Clear();
                    aptno.Clear();
                    postakodu.Clear();
                    telefon.Clear();
                    fax.Clear();
                    cep.Clear();
                    web.Clear();
                    eposta.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adi.Clear();
            soyadi.Clear();
            tckimlikno.Clear();
            vergidairesi.Clear();
            vergino.Clear();
            il.Clear();
            ilce.Clear();
            semt.Clear();
            mahalle.Clear();
            cadde.Clear();
            sokak.Clear();
            aptadi.Clear();
            aptno.Clear();
            postakodu.Clear();
            telefon.Clear();
            fax.Clear();
            cep.Clear();
            web.Clear();
            eposta.Clear();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            
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
                    OleDbCommand komut = new OleDbCommand("delete from carihesap where adi='" + adi.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    adi.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firmacarikayit a = new firmacarikayit();
            a.Show();
        }
    }
}
