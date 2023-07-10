using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace onmuhasebe
{
    public partial class alisfatura : Form
    {
        public alisfatura()
        {
            InitializeComponent();
        }

        private void alisfatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet4.alisfaturalari' table. You can move, or remove it, as needed.
            this.alisfaturalariTableAdapter1.Fill(this.onmuhasebesmartdataDataSet4.alisfaturalari);
          

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");

                double kdvsi = Convert.ToDouble(kdvorani.Text);
                
                double toplamkdv,toplamtutar;
                toplamkdv = (sonuc * kdvsi) / 100;
                toplamtutar = toplamkdv + sonuc;



                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisfaturalari(tarih,belgeno,islemturu,cariadi,bruttutar,kdvtutari,toplamtutar) values ('" + tarih.Text + "','" + belgeno.Text + "','" + islemturu.Text + "','" + cariadi.Text + "','" + tutar.Text + "','" + toplamkdv + "','" + toplamtutar + "')");
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
                    OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,borc) values ('" + tarih.Text + "','" + "Vade Yok" + "','" + belgeno.Text + "','" + "Peşin" + "','" + "Açıklama Yok" + "','" + tutar.Text + "')");
                    komut2.Connection = baglanti;
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    tarih.Clear();
                    belgeno.Clear();
                    islemturu.Text = "Alış Faturası";
                    cariadi.Clear();
                    tutar.Clear();
                    kdvorani.SelectedIndex = -1;


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alisfaturalari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tarih.Clear();
            belgeno.Clear();
            islemturu.Text = "Alış Faturası";
            cariadi.Clear();
            tutar.Clear();
            kdvorani.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");

                double kdvsi = Convert.ToDouble(kdvorani.Text);

                double toplamkdv, toplamtutar;
                toplamkdv = (sonuc * kdvsi) / 100;
                toplamtutar = toplamkdv + sonuc;



                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisfaturalari(tarih,belgeno,islemturu,cariadi,bruttutar,kdvtutari,toplamtutar) values ('" + tarih.Text + "','" + belgeno.Text + "','" + islemturu.Text + "','" + cariadi.Text + "','" + tutar.Text + "','" + toplamkdv + "','" + toplamtutar + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");

                    tarih.Clear();
                    belgeno.Clear();
                    islemturu.Text = "Alış Faturası";
                    cariadi.Clear();
                    tutar.Clear();
                    kdvorani.SelectedIndex = -1;



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarih.Clear();
            belgeno.Clear();
            islemturu.Text = "Alış Faturası";
            cariadi.Clear();
            tutar.Clear();
            kdvorani.SelectedIndex = -1;
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

        private void button1_Click(object sender, EventArgs e)
        {
           
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "tarih like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ara.Clear();

        }

        private void cariadi_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alisfatura";
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
                    OleDbCommand komut = new OleDbCommand("delete from alisfaturalari where tarih='" + tarih.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    tarih.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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

            col2 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // tarih...
            col3 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // belge no...
            col4 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // vade..
            col5 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // şube...
            col6 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // tutar...
            col7 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...


            String drawyazi = "Tarih : " + col2;
            String drawyazi2 = "Belge No : " + col3;
            String drawyazi3 = "İşlem Türü : " + col4;
            String drawyazi4 = "Cari Adı : " + col5;
            String drawyazi5 = "Brüt Tutar : " + col6;
            String drawyazi6 = "KDV Oranı : " + col7;


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

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }
    }
}
