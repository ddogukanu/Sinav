using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySinav
{
    public partial class SoruYonet : Form
    {
        public SoruYonet()
        {
            InitializeComponent();
        }

        private void SoruYonet_Load(object sender, EventArgs e)
        {
            Yenile();
        }
        public void Yenile() {
            SoruContext ctx = new SoruContext();
            //  listBox1.DataSource = ctx.Sorular.ToList();
            listBox1.DataSource = (from x in ctx.Sorular select x).ToList();
            listBox1.ValueMember = "SoruID";
            listBox1.DisplayMember = "SoruCumlesi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoruContext ctx = new SoruContext();

            if (button1.Text == "Ekle")
            {
                Soru s = new Soru();
                s.Konu = textBox1.Text;
                s.SoruCumlesi = richTextBox1.Text;
                s.Cevap = textBox2.Text;
                //using System.Data.Entity.Validation;
                DbEntityValidationResult d = ctx.Entry(s).GetValidationResult();
                if (d.IsValid) { //geçerliyse
                    ctx.Sorular.Add(s);
                    MessageBox.Show("Başarıyla eklendi");
                    EskiHali();
                }
                else
                {
                    string hata = "";
                    foreach (var item in d.ValidationErrors)
                        hata += item.ErrorMessage + " \n";
                    MessageBox.Show(hata);
                } 
                ctx.SaveChanges();
            }
            else { //düzenle
                //Soru duzenlenecek = (from x in ctx.Sorular where x.SoruID == (int)listBox1.SelectedValue select x).FirstOrDefault();
                Soru duzenlenecek = ctx.Sorular.Find(listBox1.SelectedValue);
                //Find metodu verilen id deki elemanı getirir
                duzenlenecek.Konu = textBox1.Text;
                duzenlenecek.Cevap = textBox2.Text;
                duzenlenecek.SoruCumlesi = richTextBox1.Text;

               DbEntityValidationResult d = ctx.Entry(duzenlenecek).GetValidationResult(); //modele uygun mu, varsa hatalar bu değişkende

                if (d.IsValid) //model geçerliyse hata yoksa
                {
                    ctx.Entry(duzenlenecek).State = System.Data.Entity.EntityState.Modified; //kayıtta değişiklik yapıldı
                    ctx.SaveChanges();
                    MessageBox.Show("Kaydedildi");
                }
                else
                    MessageBox.Show("Bir hata oluştu");

                EskiHali();

            }
            Yenile();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                int i =listBox1.IndexFromPoint(e.Location);
                listBox1.SelectedIndex = i;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Emin misiniz?", "Soru sil", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) {
                SoruContext ctx = new SoruContext();
               Soru silinecek= ctx.Sorular.Find(listBox1.SelectedValue);
                ctx.Sorular.Remove(silinecek);
                ctx.SaveChanges();
                Yenile();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Düzenle";
            groupBox1.Text = "Soru Düzenle";

            SoruContext ctx = new SoruContext();
            Soru soru = ctx.Sorular.Find(listBox1.SelectedValue);
            textBox1.Text = soru.Konu;
            textBox2.Text = soru.Cevap;
            richTextBox1.Text = soru.SoruCumlesi;
        }

        public void EskiHali() {
            button1.Text = "Ekle";
            groupBox1.Text = "Yeni Soru";
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
