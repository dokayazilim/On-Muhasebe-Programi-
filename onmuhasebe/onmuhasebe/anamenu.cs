using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace onmuhasebe
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void yeniCariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenicari a = new yenicari();
            a.Show();
        }

        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniurun a = new yeniurun();
            a.Show();
        }

        private void yeniKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenikasa a = new yenikasa();
            a.Show();
        }

        private void alınanÇeklerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alinancekler a = new alinancekler();
            a.Show();
        }

        private void verilenÇeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilencekler a = new verilencekler();
            a.Show();
        }

        private void yeniBankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alınanSenetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinansenet a = new alinansenet();
            a.Show();
        }

        private void verilenSenetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilensenet a = new verilensenet();
            a.Show();
        }

        private void alınanTekliflerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinanteklif a = new alinanteklif();
            a.Show();
        }

        private void verilenTekliflerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilenteklif a = new verilenteklif();
            a.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisfatura a = new alisfatura();
            a.Show();
        }

        private void satışFaturalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisfatura a = new satisfatura();
            a.Show();
        }

        private void yeniDefterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidefter a = new yenidefter();
            a.Show();
        }

        private void alışİrsaliyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisirsaliye a = new alisirsaliye();
            a.Show();
        }

        private void satışİrsaliyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisirsaliye a = new satisirsaliye();
            a.Show();
        }

        private void cariListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carilistesi a = new carilistesi();
            a.Show();
        }

        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoklistesi a = new stoklistesi();
            a.Show();
        }

        private void kayıtlıÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitliurun a = new kayitliurun();
            a.Show();
        }

        private void tümTekliflerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumteklif a = new tumteklif();
            a.Show();
        }

        private void tümÇeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumcekler a = new tumcekler();
            a.Show();
        }

        private void tümSenetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumsenet a = new tumsenet();
            a.Show();
        }

        private void bilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelecek güncellemelerde aktif olacaktır.","Uyarı");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void senkronizeEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anamenu_Load(object sender, EventArgs e)
        {

        }

        private void alınanSenetlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alinansenet a = new alinansenet();
            a.Show();
        }

        private void verilenSenetlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verilensenet a = new verilensenet();
            a.Show();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenipersonel a = new yenipersonel();
            a.Show();
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelecek güncellemelerde aktif olacaktır.", "Uyarı");
        }

        private void versiyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs a = new vs();
            a.Show();
        }

        private void yeniFirmaLişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
        }

        private void yetkiliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kayıtlıFirmaKişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitlifirmadiger a = new kayitlifirmadiger();
            a.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dokasoft.com/onmuhasebesmart");
        }

        private void uzaktanDestekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("yardim.exe");
        }

        private void yeniStokEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            stokkaydi a = new stokkaydi();
            a.Show();
        }

        private void yeniBankaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            yenibanka a = new yenibanka();
            a.Show();
        }

        private void alışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisislemi a = new alisislemi();
            a.Show();
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisislemi a = new satisislemi();
            a.Show();
        }

        private void yedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yedekalpc a = new yedekalpc();
            a.Show();
        }
    }
}
