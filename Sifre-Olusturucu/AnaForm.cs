using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifre_Olusturucu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public bool kucukHarf = false;
        public bool buyukHarf = false;
        public bool sayi = false;
        public bool specialChar = false;
        public int sifreUzunlugu = 1;

        public List<string> kHarfler = new List<string>();
        public List<string> bHarfler = new List<string>();
        public List<string> sayilar = new List<string>();
        public List<string> ozelKarakterler = new List<string>();
        public List<string> durumlar = new List<string>();

        public Random random = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPass.Items.Clear();
            KucukHarfEkle();
            BuyukHarfEkle();
            SayiEkle();
            OzelKarakterEkle();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // "0" = Küçük Harf
            // "1" = Büyük Harf
            // "2" = Sayı
            // "3" = Özel Karakter

            kucukHarf = cbKucuk.Checked;
            buyukHarf = cbBuyuk.Checked;
            sayi = cbSayi.Checked;
            specialChar = cbOzel.Checked;
            sifreUzunlugu = Convert.ToInt32(nupUzunluk.Value);

            if (!kucukHarf && !buyukHarf && !sayi && !specialChar)
            {
                MessageBox.Show("Lütfen en az 1 seçim yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (kucukHarf)
                {
                    durumlar.Add("0");
                }
                if (buyukHarf)
                {
                    durumlar.Add("1");
                }
                if (sayi)
                {
                    durumlar.Add("2");
                }
                if (specialChar)
                {
                    durumlar.Add("3");
                }

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < sifreUzunlugu; i++)
                {
                    int bu = random.Next(durumlar.Count);
                    if (durumlar[bu] == "0") // Küçük Harf ise
                    {
                        int kind = random.Next(kHarfler.Count);
                        stringBuilder.Append(kHarfler[kind]);
                    }
                    if (durumlar[bu] == "1") // Büyük Harf ise
                    {
                        int bind = random.Next(bHarfler.Count);
                        stringBuilder.Append(bHarfler[bind]);
                    }
                    if (durumlar[bu] == "2") // Sayı ise
                    {
                        int sind = random.Next(sayilar.Count);
                        stringBuilder.Append(sayilar[sind]);
                    }
                    if (durumlar[bu] == "3") // Özel Karakter ise ise
                    {
                        int oind = random.Next(ozelKarakterler.Count);
                        stringBuilder.Append(ozelKarakterler[oind]);
                    }
                }
                listPass.Items.Add(stringBuilder.ToString());
                listPass.SelectedIndex = listPass.Items.Count - 1;
                stringBuilder.Clear();
                durumlar.Clear();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listPass.Items.Clear();
        }

        private void KucukHarfEkle()
        {
            kHarfler.Add("a");
            kHarfler.Add("b");
            kHarfler.Add("c");
            kHarfler.Add("ç");
            kHarfler.Add("d");
            kHarfler.Add("e");
            kHarfler.Add("f");
            kHarfler.Add("g");
            kHarfler.Add("ğ");
            kHarfler.Add("h");
            kHarfler.Add("ı");
            kHarfler.Add("i");
            kHarfler.Add("j");
            kHarfler.Add("k");
            kHarfler.Add("l");
            kHarfler.Add("m");
            kHarfler.Add("n");
            kHarfler.Add("o");
            kHarfler.Add("ö");
            kHarfler.Add("p");
            kHarfler.Add("r");
            kHarfler.Add("s");
            kHarfler.Add("ş");
            kHarfler.Add("t");
            kHarfler.Add("u");
            kHarfler.Add("ü");
            kHarfler.Add("v");
            kHarfler.Add("y");
            kHarfler.Add("z");
            kHarfler.Add("x");
            kHarfler.Add("w");
            kHarfler.Add("q");
        }

        private void BuyukHarfEkle()
        {
            bHarfler.Add("A");
            bHarfler.Add("B");
            bHarfler.Add("C");
            bHarfler.Add("Ç");
            bHarfler.Add("D");
            bHarfler.Add("E");
            bHarfler.Add("F");
            bHarfler.Add("G");
            bHarfler.Add("Ğ");
            bHarfler.Add("H");
            bHarfler.Add("I");
            bHarfler.Add("İ");
            bHarfler.Add("J");
            bHarfler.Add("K");
            bHarfler.Add("L");
            bHarfler.Add("M");
            bHarfler.Add("N");
            bHarfler.Add("O");
            bHarfler.Add("Ö");
            bHarfler.Add("P");
            bHarfler.Add("R");
            bHarfler.Add("S");
            bHarfler.Add("Ş");
            bHarfler.Add("T");
            bHarfler.Add("U");
            bHarfler.Add("Ü");
            bHarfler.Add("V");
            bHarfler.Add("Y");
            bHarfler.Add("Z");
            bHarfler.Add("X");
            bHarfler.Add("W");
            bHarfler.Add("Q");
        }

        private void SayiEkle()
        {
            for (int i = 0; i < 10; i++)
            {
                string sayi = i.ToString();
                sayilar.Add(sayi);
            }
        }

        private void OzelKarakterEkle()
        {
            ozelKarakterler.Add("!");
            ozelKarakterler.Add("#");
            ozelKarakterler.Add("$");
            ozelKarakterler.Add("%");
            ozelKarakterler.Add("&");
            ozelKarakterler.Add("/");
            ozelKarakterler.Add("+");
            ozelKarakterler.Add("-");
            ozelKarakterler.Add("*");
            ozelKarakterler.Add("=");
            ozelKarakterler.Add("_");
            ozelKarakterler.Add("-");
            ozelKarakterler.Add("?");
            ozelKarakterler.Add("(");
            ozelKarakterler.Add(")");
            ozelKarakterler.Add("{");
            ozelKarakterler.Add("}");
            ozelKarakterler.Add("]");
            ozelKarakterler.Add("[");

        }

        private void btnPanoKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listPass.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Hiçbir şey seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
