using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace almanca_oyunu_arches
{
    public partial class Form1 : Form
    {
        ArrayList kelimeler = new ArrayList();
        ArrayList anlamlar = new ArrayList();
        string secilenkelime;
        int indexno;
        string secilenanlam;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeekle();

            indexno = r.Next(kelimeler.Count);
            secilenkelime = kelimeler[indexno].ToString();
            kelime_LBL.Text = secilenkelime;
            secilenanlam = anlamlar[indexno].ToString();

        }
        private void oyunsifirla()
        {
            kelimeler.Clear();
            anlamlar.Clear();
            kelimeekle();

            indexno = r.Next(kelimeler.Count);
            secilenkelime = kelimeler[indexno].ToString();
            kelime_LBL.Text = secilenkelime;
            secilenanlam = anlamlar[indexno].ToString();
        }
        private void kelimeekle()
        {
            kelimeler.Add("Hallo");
            anlamlar.Add("merhaba");

            kelimeler.Add("auf widersehen");
            anlamlar.Add("görüşmek üzere");

            kelimeler.Add("guten morgen");
            anlamlar.Add("günaydın");

            kelimeler.Add("Heute");
            anlamlar.Add("bugün");

            kelimeler.Add("Heute morgen");
            anlamlar.Add("bu sabah");

            kelimeler.Add("Gestern");
            anlamlar.Add("dün");

            kelimeler.Add("Am Mittag");
            anlamlar.Add("öğlen");

            kelimeler.Add("Nachmittag");
            anlamlar.Add("öğleden sonra");

            kelimeler.Add("Herr");
            anlamlar.Add("bay");


            kelimeler.Add("Frau");
            anlamlar.Add("bayan");

            kelimeler.Add("ja");
            anlamlar.Add("evet");

            kelimeler.Add("nein");
            anlamlar.Add("hayır");

            kelimeler.Add("Bitte schön");
            anlamlar.Add("rica ederim");

            kelimeler.Add("Lange");
            anlamlar.Add("uzun");

            kelimeler.Add("Mittel");
            anlamlar.Add("orta");

            kelimeler.Add("der Aschenbecher");
            anlamlar.Add("küllük");

            kelimeler.Add("die kugel");
            anlamlar.Add("top");

            kelimeler.Add("der Luftballon");
            anlamlar.Add("balon");

            kelimeler.Add("das buch");
            anlamlar.Add("kitap");

            kelimeler.Add("die flage");
            anlamlar.Add("bayrak");

            kelimeler.Add("das Feuerzeug");
            anlamlar.Add("çakmak");

        }
       
        private void reset() {
            this.Controls.Clear();
            this.InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                string userInput = textBox1.Text;

                if (userInput == secilenanlam)
                {
                    MessageBox.Show("doğru tahmin");
                    reset();
                    oyunsifirla();
                
                }
                else
                {
                    dogu_yanlis_LBL.Text = "tekrar deneyin";
                    textBox1.Text = null;
                }
                
            }
            catch(Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cevap_LBL.Text = anlamlar[indexno].ToString();
        }
    }
}
