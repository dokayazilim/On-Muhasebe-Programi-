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
    public partial class alinancekler : Form
    {
        public alinancekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                if (belgeno.Text == "")
                {
                    MessageBox.Show("Belge No alanı boş geçilemez!", "Uyarı");
                }
                else
                {

                    double sonuc = Convert.ToDouble(tutar.Text);
                    tutar.Text = sonuc.ToString("c");

                    try
                    {
                        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglan.Open();
                        OleDbCommand komut = new OleDbCommand("insert into alinancekler(evrakno,belgeno,islemtarihi,vade,tutar,banka,sube,hesapno,evrakdurumu,evraktipi,aciklama) values ('" + evrakno.Text + "','" + belgeno.Text + "','" + islemtarihi.Text + "','" + vade.Text + "','" + tutar.Text + "','" + banka.Text + "','" + sube.Text + "','" + hesapno.Text + "','" + evrakdurumu.Text + "','" + evraktipi.Text + "','" + aciklama.Text + "')");
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
                        OleDbCommand komut2 = new OleDbCommand("insert into carirapor(tarih,vade,evrakno,odemesekli,aciklama,borc) values ('" + islemtarihi.Text + "','" + vade.Text + "','" + evrakno.Text + "','" + "Peşin" + "','" + aciklama.Text + "','" + tutar.Text + "')");
                        komut2.Connection = baglanti;
                        komut2.ExecuteNonQuery();
                        baglanti.Close();

                        evrakno.Clear();
                        belgeno.Clear();
                        islemtarihi.Clear();
                        vade.Clear();
                        tutar.Clear();
                        banka.Clear();
                        sube.Clear();
                        hesapno.Clear();
                        evrakdurumu.SelectedIndex = -1;
                        evraktipi.SelectedIndex = -1;

                        aciklama.Clear();


                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }

        private void tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutar_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            evrakno.Clear();
            belgeno.Clear();
            islemtarihi.Clear();
            vade.Clear();
            tutar.Clear();
            banka.Clear();
            sube.Clear();
            hesapno.Clear();
            evrakdurumu.SelectedIndex = -1;
            evraktipi.SelectedIndex = -1;
            
            aciklama.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evrakno.Clear();
            belgeno.Clear();
            islemtarihi.Clear();
            vade.Clear();
            tutar.Clear();
            banka.Clear();
            sube.Clear();
            hesapno.Clear();
            evrakdurumu.SelectedIndex = -1;
            evraktipi.SelectedIndex = -1;
            
            aciklama.Clear();
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
                    OleDbCommand komut = new OleDbCommand("insert into alinancekler(evrakno,belgeno,islemtarihi,vade,tutar,banka,sube,hesapno,evrakdurumu,evraktipi,aciklama) values ('" + evrakno.Text + "','" + belgeno.Text + "','" + islemtarihi.Text + "','" + vade.Text + "','" + tutar.Text + "','" + banka.Text + "','" + sube.Text + "','" + hesapno.Text + "','" + evrakdurumu.Text + "','" + evraktipi.Text + "','" + aciklama.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    evrakno.Clear();
                    belgeno.Clear();
                    islemtarihi.Clear();
                    vade.Clear();
                    tutar.Clear();
                    banka.Clear();
                    sube.Clear();
                    hesapno.Clear();
                    evrakdurumu.SelectedIndex = -1;
                    evraktipi.SelectedIndex = -1;
                   
                    aciklama.Clear();


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alinancekler", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void alinancekler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet1.alinancekler' table. You can move, or remove it, as needed.
            this.alinanceklerTableAdapter1.Fill(this.onmuhasebesmartdataDataSet1.alinancekler);
            

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
                    OleDbCommand komut = new OleDbCommand("delete from alinancekler where belgeno='"+belgeno.Text+"'");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgeno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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

            col2 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // evrak no...
            col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem tarihi...
            col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // vade..
            col5 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // şube...
            col6 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // tutar...
            col7 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...


            String drawyazi = "Evrak No : " + col2;
            String drawyazi2 = "İşlem Tarihi : " + col3;
            String drawyazi3 = "Vade : " + col4;
            String drawyazi4 = "Şube : " + col5;
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

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }
    }
}
