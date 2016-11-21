using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySinav
{
    public partial class SinavEkran : Form
    {
        public SinavEkran()
        {
            InitializeComponent();
        }

        int Kactayiz = 0;
        int SoruSayisi = 5;
        List<Soru> Sinav = new List<Soru>();
        // 0 1 2 3 4

        List<string> Cevaplar = new List<string>(); //kullanıcının verdiği cevaplar

        void SoruGoster(string islem) {
            Cevaplar[Kactayiz] = txt_cevap.Text;

            if (islem == "geri") Kactayiz--; else if (islem == "ileri") Kactayiz++;

            Soru s = Sinav[Kactayiz];
            lbl_Konu.Text = s.Konu;
            lbl_Soru.Text = s.SoruCumlesi;

            lbl_kactayiz.Text = (Kactayiz+1) + " / " + SoruSayisi;

            if (Kactayiz == 0) //ilk soru
                btn_geri.Enabled = false;
            else
                btn_geri.Enabled = true;

            if (Kactayiz == SoruSayisi - 1) //son soru
                btn_ileri.Enabled = false;
            else btn_ileri.Enabled = true;
        }

        private void SinavEkran_Load(object sender, EventArgs e)
        {

            SoruContext ctx = new SoruContext();
            Sinav = ctx.Sorular.Take(SoruSayisi).ToList(); //ilk 5 soru
            SoruSayisi = Sinav.Count;
            foreach (var item in Sinav)
                Cevaplar.Add("");
            SoruGoster("");
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            SoruGoster("ileri");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SoruGoster("geri");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cevaplar[Kactayiz] = txt_cevap.Text;
            SinavSonuc s = new SinavSonuc();
            s.yanitlar = Cevaplar;
            s.sorular = Sinav;
            s.Show();
            this.Hide();
        }
    }
}
