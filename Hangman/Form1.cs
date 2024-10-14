using Hangman.Properties;
using System.Globalization;
using System.Xml.Linq;
namespace Hangman
{
    public partial class Form1 : Form
        //merhaba
    {
        private string tahminEdilecekKelime;
        private string kelimeEkran�;
        private List<char> tahminEdilenHarfler;
        private int tahminEdilenHatal�Tahminler;
        public Form1()
        {
            InitializeComponent();
            Tekrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Tekrar()
        {
            pictureBox1.Image = Resources.realBos;
            tahminEdilecekKelime = cityRandom();
            kelimeEkran� = new string('_', tahminEdilecekKelime.Length);
            tahminEdilenHarfler = new List<char>();
            tahminEdilenHatal�Tahminler = 0;
            label1Ekran.Text = kelimeEkran�;
            labelHata.Text = "Hatal� Tahmin: " + tahminEdilenHatal�Tahminler;
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private string cityRandom()
        {
            string[] sehirler = {"adana", "ad�yaman", "afyonkarahisar", "a�r�", "aksaray", "amasya", "ankara", "antalya", "Ardahan",
    "artvin", "ayd�n", "bal�kesir", "bart�n", "batman", "bayburt", "bilecik", "bing�l", "bitlis", "bolu",
    "burdur", "bursa", "�anakkale", "�ank�r�", "�orum", "denizli", "diyarbak�r", "d�zce", "edirne", "elaz��",
    "erzincan", "erzurum", "eski�ehir", "gaziantep", "giresun", "g�m��hane", "hakkari", "hatay", "��d�r",
    "�sparta", "istanbul", "izmir", "kahramanmara�", "karab�k", "karaman", "kars", "kastamonu", "kayseri",
    "kilis", "k�r�kkale", "k�rklareli", "k�r�ehir", "kocaeli", "konya", "k�tahya", "malatya", "manisa",
    "mardin", "mersin", "mu�la", "mu�", "nev�ehir", "ni�de", "ordu", "osmaniye", "rize", "sakarya",
    "samsun", "siirt", "sinop", "sivas", "�anl�urfa", "��rnak", "tekirda�", "tokat", "trabzon", "tunceli",
    "u�ak", "van", "yalova", "yozgat", "zonguldak"};
            Random random = new Random();
            return sehirler[random.Next(sehirler.Length)];
            
        }

        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = textTahmin.Text;
           
            

            if (tahmin.Length == 1 && char.IsLetter(tahmin[0]))
            {
                char tahminMesaj� = tahmin[0];
                if (!tahminEdilenHarfler.Contains(tahminMesaj�))
                {
                    tahminEdilenHarfler.Add(tahminMesaj�);
                    if (tahminEdilecekKelime.Contains(tahminMesaj�))
                    {
                        updateKelimeEkran�(tahminMesaj�);
                    }
                    else
                    {
                        tahminEdilenHatal�Tahminler++;
                        labelHata.Text = "Hatal� Tahmin: " + tahminEdilenHatal�Tahminler;
                        if (tahminEdilenHatal�Tahminler == 1) {
                            pictureBox1.Image = Resources.realKafa;
                        }
                        if (tahminEdilenHatal�Tahminler == 2)
                        {
                            pictureBox1.Image = Resources.realGovde;
                        }
                        if (tahminEdilenHatal�Tahminler == 3)
                        {
                            pictureBox1.Image = Resources.realBacak1;
                        }
                        if (tahminEdilenHatal�Tahminler == 4)
                        {
                            pictureBox1.Image = Resources.realBacak2;
                        }
                        if (tahminEdilenHatal�Tahminler == 5)
                        {
                            pictureBox1.Image = Resources.realKol1;
                        }
                        if (tahminEdilenHatal�Tahminler == 6)
                        {
                            pictureBox1.Image = Resources.realKol2;
                            MessageBox.Show("Hata yapt�n�z.");

                            Tekrar();

                        }

                    }
                    if (tahminEdilenHatal�Tahminler >= 80)
                    {
                        MessageBox.Show("Oyun bitti! Kelime �uydu: " + tahminEdilecekKelime);
                        Tekrar();
                    }
                    else if (kelimeEkran� == tahminEdilecekKelime)
                    {
                        MessageBox.Show("Tebrikler! �u kelimeyi do�ru tahmin ettin: " + tahminEdilecekKelime);
                        Tekrar();
                    }
                }
               
            }
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private void updateKelimeEkran�(char tahminMesaj�)
        {
            char[] kelimeEkranDizisi = kelimeEkran�.ToCharArray();
            for (int i = 0; i < tahminEdilecekKelime.Length; i++)
            {
                if (tahminEdilecekKelime[i] == tahminMesaj�)
                {
                    kelimeEkranDizisi[i] = tahminMesaj�;
                }
            }
            kelimeEkran� = new string(kelimeEkranDizisi);
            label1Ekran.Text = kelimeEkran�;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTekrar_Click(object sender, EventArgs e)
        {
            Tekrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
