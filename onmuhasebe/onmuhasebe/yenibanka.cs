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
    public partial class yenibanka : Form
    {
        public yenibanka()
        {
            InitializeComponent();
        }

        private void yenibanka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet19.bankaparayatirma' table. You can move, or remove it, as needed.
            this.bankaparayatirmaTableAdapter1.Fill(this.onmuhasebesmartdataDataSet19.bankaparayatirma);
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(tutaryatir.Text);
                tutaryatir.Text = sonuc.ToString("c");
                

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into bankaparayatirma(rumuz,bankadi,subeadi,hesapsahibi,hesapno,hesapbakiyesi,parabirimi,tarih,dekontno,tutar,aciklama) values ('" + rumuzyatir.Text + "','" + bankaadiyatir.Text + "','" + subeadiyatir.Text + "','" + hesapsahibiyatir.Text + "','" + hesapnoyatir.Text + "','" + bakiyeyatir.Text + "','" + "TL" + "','" + tarihyatir.Text + "','" + dekontnoyatir.Text + "','" + tutaryatir.Text + "','" + aciklamayatir.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    rumuzyatir.Text = "Demo";
                    bankaadiyatir.Clear();
                    subeadiyatir.Clear();
                    hesapsahibiyatir.Text = "Demo";
                    hesapnoyatir.Clear();
                    bakiyeyatir.Clear();
                    tarihyatir.Clear();
                    dekontnoyatir.Clear();
                    tutaryatir.Clear();
                    aciklamayatir.Clear();
                    



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from bankaparayatirma", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rumuzyatir.Clear();
            bankaadiyatir.Clear();
            subeadiyatir.Clear();
            hesapsahibiyatir.Clear();
            hesapnoyatir.Clear();
            bakiyeyatir.Clear();
            tarihyatir.Clear();
            dekontnoyatir.Clear();
            tutaryatir.Clear();
            aciklamayatir.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kaparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

                double sonuc = Convert.ToDouble(tutaryatir.Text);
                tutaryatir.Text = sonuc.ToString("c");


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into bankaparayatirma(rumuz,bankadi,subeadi,hesapsahibi,hesapno,hesapbakiyesi,parabirimi,tarih,dekontno,tutar,aciklama) values ('" + rumuzyatir.Text + "','" + bankaadiyatir.Text + "','" + subeadiyatir.Text + "','" + hesapsahibiyatir.Text + "','" + hesapnoyatir.Text + "','" + bakiyeyatir.Text + "','" + "TL" + "','" + tarihyatir.Text + "','" + dekontnoyatir.Text + "','" + tutaryatir.Text + "','" + aciklamayatir.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    rumuzyatir.Clear();
                    bankaadiyatir.Clear();
                    subeadiyatir.Clear();
                    hesapsahibiyatir.Clear();
                    hesapnoyatir.Clear();
                    bakiyeyatir.Clear();
                    tarihyatir.Clear();
                    dekontnoyatir.Clear();
                    tutaryatir.Clear();
                    aciklamayatir.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
          

                double sonuc = Convert.ToDouble(tutarcek.Text);
                tutarcek.Text = sonuc.ToString("c");


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into bankaparayatirma(rumuz,bankadi,subeadi,hesapsahibi,hesapno,hesapbakiyesi,parabirimi,tarih,dekontno,tutar,aciklama) values ('" + rumuzcek.Text + "','" + bankaadicek.Text + "','" + subeadicek.Text + "','" + hesapsahibicek.Text + "','" + hesapnocek.Text + "','" + bakiyecek.Text + "','" + "TL" + "','" + tarihcek.Text + "','" + dekontnocek.Text + "','" + tutarcek.Text + "','" + aciklamacek.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    rumuzcek.Text = "Demo";
                    bankaadicek.Clear();
                    subeadicek.Clear();
                    hesapsahibicek.Text = "Demo";
                    hesapnocek.Clear();
                    bakiyecek.Clear();
                    tarihcek.Clear();
                    dekontnocek.Clear();
                    tutarcek.Clear();
                    aciklamacek.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rumuzcek.Clear();
            bankaadicek.Clear();
            subeadicek.Clear();
            hesapsahibicek.Clear();
            hesapnocek.Clear();
            bakiyecek.Clear();
            tarihcek.Clear();
            dekontnocek.Clear();
            tutarcek.Clear();
            aciklamacek.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
          

                double sonuc = Convert.ToDouble(tutartransfer.Text);
                tutartransfer.Text = sonuc.ToString("c");


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into bankaparayatirma(rumuz,bankadi,subeadi,hesapsahibi,hesapno,hesapbakiyesi,parabirimi,tarih,dekontno,tutar,aciklama) values ('" + rumuzyatirilacak.Text + "','" + bankaadiyatirilacak.Text + "','" + subeadiyatirilacak.Text + "','" + hesapsahibiyatirilacak.Text + "','" + hesapnoyatirilacak.Text + "','" + bakiyeyatirilacak.Text + "','" + "TL" + "','" + tarihtransfer.Text + "','" + dekontnotransfer.Text + "','" + tutartransfer.Text + "','" + aciklamatransfer.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    OleDbCommand komut2 = new OleDbCommand("insert into bankaparayatirma(rumuz,bankadi,subeadi,hesapsahibi,hesapno,hesapbakiyesi,parabirimi,tarih,dekontno,tutar,aciklama) values ('" + rumuzcekilecek.Text + "','" + bankaadicekilecek.Text + "','" + subeadicekilecek.Text + "','" + hesapsahibicekilecek.Text + "','" + hesapnocekilecek.Text + "','" + bakiyecekilecek.Text + "','" + "TL" + "','" + tarihtransfer.Text + "','" + dekontnotransfer.Text + "','" + tutartransfer.Text + "','" + aciklamatransfer.Text + "')");
                    komut2.Connection = baglan;
                    komut2.ExecuteNonQuery();                   
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    rumuzcekilecek.Clear();
                    bankaadicekilecek.Clear();
                    subeadicekilecek.Clear();
                    hesapsahibicekilecek.Clear();
                    hesapnocekilecek.Clear();
                    bakiyecekilecek.Clear();
                    rumuzyatirilacak.Clear();
                    bankaadiyatirilacak.Clear();
                    subeadiyatirilacak.Clear();
                    hesapsahibiyatirilacak.Clear();
                    hesapnoyatirilacak.Clear();
                    bakiyeyatirilacak.Clear();
                    tarihtransfer.Clear();
                    dekontnotransfer.Clear();
                    tutartransfer.Clear();
                    aciklamatransfer.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "parayatirma";
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "paracekme";
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "cekilecekhesap";
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "yatirilacakhesap";
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rumuzcekilecek.Clear();
            bankaadicekilecek.Clear();
            subeadicekilecek.Clear();
            hesapsahibicekilecek.Clear();
            hesapnocekilecek.Clear();
            bakiyecekilecek.Clear();
            rumuzyatirilacak.Clear();
            bankaadiyatirilacak.Clear();
            subeadiyatirilacak.Clear();
            hesapsahibiyatirilacak.Clear();
            hesapnoyatirilacak.Clear();
            bakiyeyatirilacak.Clear();
            tarihtransfer.Clear();
            dekontnotransfer.Clear();
            tutartransfer.Clear();
            aciklamatransfer.Clear();
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
                    OleDbCommand komut = new OleDbCommand("delete from bankaparayatirma where tarih='" + tarihyatir.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    tarihyatir.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tarihyatir.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void hareketRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create string to draw.
            String drawString = "Rapor";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont2 = new Font("Arial", 8);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 50.0F;
            float y = 50.0F;
            float width = 700.0F;
            float height = 30.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            StringFormat drawFormat2 = new StringFormat();
            drawFormat2.Alignment = StringAlignment.Near;

            //yazı draw string...

            string col2, col3, col4, col5, col6, col7;

            col2 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // rumuz...
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // hesap sahibi...
            col4 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // tarih...
            col5 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // dekont no...
            col6 = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // tutar...
            col7 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...


            String drawyazi = "Rumuz : " + col2;
            String drawyazi2 = "Hesap Sahibi : " + col3;
            String drawyazi3 = "Tarih : " + col4;
            String drawyazi4 = "Dekont No : " + col5;
            String drawyazi5 = "Tutar : " + col6;
            String drawyazi6 = "Açıklama : " + col7;


            // Create font and brush.
            Font drawFon = new Font("Arial", 12);
            SolidBrush drawfirca = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(50.0F, 90.0F);
            PointF drawPoint2 = new PointF(50.0F, 120.0F);
            PointF drawPoint3 = new PointF(50.5F, 150.0F);
            PointF drawPoint4 = new PointF(590.0F, 90.0F);
            PointF drawPoint5 = new PointF(590.0F, 120.0F);
            PointF drawPoint6 = new PointF(590.0F, 150.0F);


            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
            e.Graphics.DrawString(drawyazi, drawFon, drawBrush, drawPoint, drawFormat2);
            e.Graphics.DrawString(drawyazi2, drawFon, drawBrush, drawPoint2, drawFormat2);
            e.Graphics.DrawString(drawyazi3, drawFon, drawBrush, drawPoint3, drawFormat2);
            e.Graphics.DrawString(drawyazi4, drawFon, drawBrush, drawPoint4, drawFormat2);
            e.Graphics.DrawString(drawyazi5, drawFon, drawBrush, drawPoint5, drawFormat2);
            e.Graphics.DrawString(drawyazi6, drawFon, drawBrush, drawPoint6, drawFormat2);
        }
    }
}
