using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kelimeler = { "türkiye", "barış", "hacı", "istihbarat", "üsteğmen", "pilot", "beyoğlu", "istanbul", "uçak", "muvafakatname", "adam", "tornavida", "bardak", "sürahi", "asker", "araba", "bisiklet", "galeri", "havalimanı", "şehzade", "lunapark", "hukuk", "makam", "çocuk", "televizyon", "samanyolu", "hazine", "girişim", "yatırım", "bayrak", "tarım", "ihracat", "ithalat", "reenkarne", "müslüman", "doğum", "papağan", "mavi", "gemi", "irtifa", "imsakiye", "uluslararası", "şeref", "kabak", "hürriyet", "kudret", "böbrek", "kumanda", "aşk", "bektaşi", "alevi", "bilgin", "hürmet", "asalet", "mareşal", "kuvvet", "fizik", "çikolata", "yavuz", "yazıcı", "lokanta", "garson", "lakayt", "laubali", "baron", "yıldız", "akıl", "şizofreni", "diyetisyen", "göz", "şuur", "bilinç", "gitar", "saz", "darbuka", "elektrik", "kelam", "bezelye", "fasulye", "tasdikname", "takdir", "teşekkür", "hayır", "irade", "milyar", "astigmat", "astronomi", "gastronomi", "dünya", "bakliyat"};
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            ip1.Visible = true;

            label5.Text = "Kalan Hakkınız: " + hak;
            label3.Text = "";
            kelimesec();
            cizgiler();
            timer1.Enabled = true;
            this.MaximizeBox = false;
        }

        string secilenkelime;
        string[] cizgi;
        ArrayList girilenharf = new ArrayList();
        int harfadet;
        int hak = 6;
        public void kelimesec()
        {
            int kelimedeger = rnd.Next(0, kelimeler.Length);
            secilenkelime = kelimeler[kelimedeger];
            label1.Text = secilenkelime;
        }
        
        private void cizgiler()
        {
            harfadet = secilenkelime.Length;
            cizgi = new string[harfadet];

            for (int i = 0; i < secilenkelime.Length; i++)
            {
                cizgi[i] = "_";
            }
            for (int i = 0; i < secilenkelime.Length; i++)
            {

                label3.Text += cizgi[i] + " ";
            }

        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Geçen süre: " + sure.ToString();
            sure++;
        }
        bool oyunBitti = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length > 1)
            {
                textBox1.Clear();
                MessageBox.Show("Sadece bir harf giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hak++;

            }
            else if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bir harf giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hak++;

            }

            else if (girilenharf.Contains(textBox1.Text))
            {
                MessageBox.Show("Bu harfi daha önce girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hak++;

            }

            
            bool sonuc = false;
            for (int i = 0; i < secilenkelime.Length; i++)
            {
                string harf = textBox1.Text.ToLower();
                if(harf == secilenkelime[i].ToString())
                {
                    cizgi[i] = harf;
                    label3.Text = "";
                    for (int j = 0; j  < cizgi.Length; j ++)
                    {
                        label3.Text += cizgi[j] + " ";
                    }
                    sonuc = true;
                }
            }
            if (label3.Text.Contains("_"))
            {
                oyunBitti = false;
            }
            else
            {
                oyunBitti = true;
            }
            if(sonuc == false)
            {
                
                hak--;
                label5.Text = "Kalan Hakkınız: " + hak;
            }
            girilenharf.Add(textBox1.Text);
            textBox1.Clear();
            adamCizim();
            if(oyunBitti == true)
            {
                timer1.Enabled = false;
                label3.ForeColor = Color.Yellow;
                MessageBox.Show("Tebrikler! Oyunu kazandınız. Aradığınız kelime olan " + secilenkelime.ToUpper() + " " + " kelimesini" + sure + "" + "saniyede buldunuz.", "Kazandınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bir kelime giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hak++;

            }

            else if (girilenharf.Contains(textBox2.Text))
            {
                MessageBox.Show("Bu kelimeyi daha önce girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hak++;

            }
            string tahmin = textBox2.Text.ToLower();
            if(tahmin == secilenkelime)
            {
                timer1.Enabled = false;
                label3.Text = "";
                for (int i = 0; i < secilenkelime.Length; i++)
                {
                    cizgi[i] = secilenkelime[i].ToString();
                    label3.Text += cizgi[i] + " ";

                }
                label3.ForeColor = Color.Yellow;
                MessageBox.Show("Tebrikler! Oyunu kazandınız. Aradığınız kelime olan " + secilenkelime.ToUpper() + " " + " kelimesini" + sure + "" + "saniyede buldunuz.", "Kazandınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;

            }
            else
            {
                hak--;
                label5.Text = "Kalan Hakkınız: " + hak;
                girilenharf.Add(tahmin);
            }
            textBox2.Clear();
            adamCizim();
        }
        private void adamCizim()
        {
            if (hak == 5)
            {
                ip1.Visible = false;
                ip2.Visible = true;
            }
            else if (hak == 4)
            {
                ip2.Visible = false;
                ip3.Visible = true;
            }
            else if (hak == 3)
            {
                ip3.Visible = false;
                ip4.Visible = true;
            }
            else if (hak == 2)
            {
                ip4.Visible = false;
                ip5.Visible = true;
            }
            else if (hak == 1)
            {

                ip5.Visible = false;
                ip6.Visible = true;


            }
            else if(hak == 0)
            {
                timer1.Enabled = false;
                ip6.Visible = false;
                ip7.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = secilenkelime;
                MessageBox.Show("Hakkınız kalmadı. Aradığınız kelime " + secilenkelime.ToUpper() + " " + "olacaktı. Bu oyunda toplam " + sure + " saniye geçirdiniz." , "Kaybettiniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni oyun başlatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

            if (result == DialogResult.Yes)
            {
                timer1.Enabled = false;
                this.Controls.Clear();
                this.InitializeComponent();
                sure = 0;
                hak = 6;
                ip1.Visible = true;
                label5.Text = "Kalan Hakkınız: " + hak;
                label3.Text = "";
                kelimesec();
                cizgiler();
                timer1.Enabled = true;
                girilenharf.Clear();
            }
            else
            {

            }


        }
    }
}
