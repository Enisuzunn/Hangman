using Hangman.Properties;
using System.Globalization;
using System.Xml.Linq;
namespace Hangman
{
    public partial class Form1 : Form
        //merhaba
    {
        private string tahminEdilecekKelime;
        private string kelimeEkraný;
        private List<char> tahminEdilenHarfler;
        private int tahminEdilenHatalýTahminler;
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
            kelimeEkraný = new string('_', tahminEdilecekKelime.Length);
            tahminEdilenHarfler = new List<char>();
            tahminEdilenHatalýTahminler = 0;
            label1Ekran.Text = kelimeEkraný;
            labelHata.Text = "Hatalý Tahmin: " + tahminEdilenHatalýTahminler;
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private string cityRandom()
        {
            string[] sehirler = {"adana", "adýyaman", "afyonkarahisar", "aðrý", "aksaray", "amasya", "ankara", "antalya", "Ardahan",
    "artvin", "aydýn", "balýkesir", "bartýn", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu",
    "burdur", "bursa", "çanakkale", "çankýrý", "çorum", "denizli", "diyarbakýr", "düzce", "edirne", "elazýð",
    "erzincan", "erzurum", "eskiþehir", "gaziantep", "giresun", "gümüþhane", "hakkari", "hatay", "ýðdýr",
    "ýsparta", "istanbul", "izmir", "kahramanmaraþ", "karabük", "karaman", "kars", "kastamonu", "kayseri",
    "kilis", "kýrýkkale", "kýrklareli", "kýrþehir", "kocaeli", "konya", "kütahya", "malatya", "manisa",
    "mardin", "mersin", "muðla", "muþ", "nevþehir", "niðde", "ordu", "osmaniye", "rize", "sakarya",
    "samsun", "siirt", "sinop", "sivas", "þanlýurfa", "þýrnak", "tekirdað", "tokat", "trabzon", "tunceli",
    "uþak", "van", "yalova", "yozgat", "zonguldak"};
            Random random = new Random();
            return sehirler[random.Next(sehirler.Length)];
            
        }

        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = textTahmin.Text;
           
            

            if (tahmin.Length == 1 && char.IsLetter(tahmin[0]))
            {
                char tahminMesajý = tahmin[0];
                if (!tahminEdilenHarfler.Contains(tahminMesajý))
                {
                    tahminEdilenHarfler.Add(tahminMesajý);
                    if (tahminEdilecekKelime.Contains(tahminMesajý))
                    {
                        updateKelimeEkraný(tahminMesajý);
                    }
                    else
                    {
                        tahminEdilenHatalýTahminler++;
                        labelHata.Text = "Hatalý Tahmin: " + tahminEdilenHatalýTahminler;
                        if (tahminEdilenHatalýTahminler == 1) {
                            pictureBox1.Image = Resources.realKafa;
                        }
                        if (tahminEdilenHatalýTahminler == 2)
                        {
                            pictureBox1.Image = Resources.realGovde;
                        }
                        if (tahminEdilenHatalýTahminler == 3)
                        {
                            pictureBox1.Image = Resources.realBacak1;
                        }
                        if (tahminEdilenHatalýTahminler == 4)
                        {
                            pictureBox1.Image = Resources.realBacak2;
                        }
                        if (tahminEdilenHatalýTahminler == 5)
                        {
                            pictureBox1.Image = Resources.realKol1;
                        }
                        if (tahminEdilenHatalýTahminler == 6)
                        {
                            pictureBox1.Image = Resources.realKol2;
                            MessageBox.Show("Hata yaptýnýz.");

                            Tekrar();

                        }

                    }
                    if (tahminEdilenHatalýTahminler >= 80)
                    {
                        MessageBox.Show("Oyun bitti! Kelime þuydu: " + tahminEdilecekKelime);
                        Tekrar();
                    }
                    else if (kelimeEkraný == tahminEdilecekKelime)
                    {
                        MessageBox.Show("Tebrikler! Þu kelimeyi doðru tahmin ettin: " + tahminEdilecekKelime);
                        Tekrar();
                    }
                }
               
            }
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private void updateKelimeEkraný(char tahminMesajý)
        {
            char[] kelimeEkranDizisi = kelimeEkraný.ToCharArray();
            for (int i = 0; i < tahminEdilecekKelime.Length; i++)
            {
                if (tahminEdilecekKelime[i] == tahminMesajý)
                {
                    kelimeEkranDizisi[i] = tahminMesajý;
                }
            }
            kelimeEkraný = new string(kelimeEkranDizisi);
            label1Ekran.Text = kelimeEkraný;
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
