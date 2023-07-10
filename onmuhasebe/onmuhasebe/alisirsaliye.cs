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
    public partial class alisirsaliye : Form
    {
        public alisirsaliye()
        {
            InitializeComponent();
        }

        private void alisirsaliye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet5.alisirsaliyesi' table. You can move, or remove it, as needed.
            this.alisirsaliyesiTableAdapter1.Fill(this.onmuhasebesmartdataDataSet5.alisirsaliyesi);
         

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisirsaliyesi(irsaliyetarihi,irsaliyeno,carihesap,tutar,kdv,geneltoplam,faturano,durumu) values ('" + irsaliyetarihi.Text + "','" + irsaliyeno.Text + "','" + carihesap.Text + "','" + tutar.Text + "','" + kdv.Text + "','" + "fatura" + "','" + faturano.Text + "','" + kdv.Text + "')");
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
                    OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,borc) values ('" + irsaliyetarihi.Text + "','" + "Vade Yok" + "','" + faturano.Text + "','" + "Peşin" + "','" + durumu.Text + "','" + tutar.Text + "')");
                    komut2.Connection = baglanti;
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    irsaliyetarihi.Clear();
                    irsaliyeno.Clear();
                    carihesap.Clear();
                    tutar.Clear();
                    kdv.SelectedIndex = -1;
                    faturano.Clear();
                    durumu.Clear();
                    


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            irsaliyetarihi.Clear();
            irsaliyeno.Clear();
            carihesap.Clear();
            tutar.Clear();
            kdv.SelectedIndex = -1;
            faturano.Clear();
            durumu.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irsaliyetarihi.Clear();
            irsaliyeno.Clear();
            carihesap.Clear();
            tutar.Clear();
            kdv.SelectedIndex = -1;
            faturano.Clear();
            durumu.Clear();
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alisirsaliyesi", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(tutar.Text);
                tutar.Text = sonuc.ToString("c");


                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into alisirsaliyesi(irsaliyetarihi,irsaliyeno,carihesap,tutar,kdv,geneltoplam,faturano,durumu) values ('" + irsaliyetarihi.Text + "','" + irsaliyeno.Text + "','" + carihesap.Text + "','" + tutar.Text + "','" + kdv.Text + "','" + "fatura" + "','" + faturano.Text + "','" + kdv.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    irsaliyetarihi.Clear();
                    irsaliyeno.Clear();
                    carihesap.Clear();
                    tutar.Clear();
                    kdv.SelectedIndex = -1;
                    faturano.Clear();
                    durumu.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource sr2 = new BindingSource();
            sr2.DataSource = dataGridView1.DataSource;

            sr2.Filter = "irsaliyetarihi like '%" + ara.Text + "%'";
            dataGridView1.DataSource = sr2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ara.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carikayitlari a = new carikayitlari();
            a.label2.Text = "alisirsaliye";
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
                    OleDbCommand komut = new OleDbCommand("delete from alisirsaliyesi where irsaliyetarihi='" + irsaliyetarihi.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    irsaliyetarihi.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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

            col2 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // irsaliye tarihi...
            col3 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // irsaliye no...
            col4 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // cari hesap...
            col5 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // tutar...
            col6 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdv...
            col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fatura no..


            String drawyazi = "İrsaliye Tarihi : " + col2;
            String drawyazi2 = "İrsaliye No : " + col3;
            String drawyazi3 = "Cari Hesap : " + col4;
            String drawyazi4 = "Tutar : " + col5;
            String drawyazi5 = "KDV : " + col6;
            String drawyazi6 = "Fatura No : " + col7;


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
