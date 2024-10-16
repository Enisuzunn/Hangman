using Hangman.Properties;
using System.Globalization;
using System.Xml.Linq;
namespace Hangman
{
    public partial class Form1 : Form
     
    {
        private string tahminEdilecekKelime;
        private string kelimeEkranı;
        private List<char> tahminEdilenHarfler;
        private int tahminEdilenHatalıTahminler;
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
            kelimeEkranı = new string('_', tahminEdilecekKelime.Length);
            tahminEdilenHarfler = new List<char>();
            tahminEdilenHatalıTahminler = 0;
            label1Ekran.Text = kelimeEkranı;
            labelHata.Text = "Hatalı Tahmin: " + tahminEdilenHatalıTahminler;
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private string cityRandom()
        {
            string[] sehirler = {"adana", "adıyaman", "afyonkarahisar", "ağrı", "aksaray", "amasya", "ankara", "antalya", "Ardahan",
    "artvin", "aydın", "balıkesir", "bartın", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu",
    "burdur", "bursa", "çanakkale", "çankırı", "çorum", "denizli", "diyarbakır", "düzce", "edirne", "elazığ",
    "erzincan", "erzurum", "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ığdır",
    "ısparta", "istanbul", "izmir", "kahramanmaraş", "karabük", "karaman", "kars", "kastamonu", "kayseri",
    "kilis", "kırıkkale", "kırklareli", "kırşehir", "kocaeli", "konya", "kütahya", "malatya", "manisa",
    "mardin", "mersin", "muğla", "muş", "nevşehir", "niğde", "ordu", "osmaniye", "rize", "sakarya",
    "samsun", "siirt", "sinop", "sivas", "şanlıurfa", "şırnak", "tekirdağ", "tokat", "trabzon", "tunceli",
    "uşak", "van", "yalova", "yozgat", "zonguldak"};
            Random random = new Random();
            return sehirler[random.Next(sehirler.Length)];
            
        }

        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = textTahmin.Text;
           
            
            if(tahmin.Length > 1 ) {
                if(tahminEdilecekKelime.Equals(tahmin))
                {
                    label1Ekran.Text = tahminEdilecekKelime;
                    MessageBox.Show("Tebrikler! Şu kelimeyi doğru tahmin ettin: " + tahminEdilecekKelime);
                    Tekrar();
                }
                else 
                {
                    tahminEdilenHatalıTahminler++;
                    labelHata.Text = "Hatalı Tahmin: " + tahminEdilenHatalıTahminler;
                    if (tahminEdilenHatalıTahminler == 1)
                    {
                        pictureBox1.Image = Resources.realKafa;
                    }
                    if (tahminEdilenHatalıTahminler == 2)
                    {
                        pictureBox1.Image = Resources.realGovde;
                    }
                    if (tahminEdilenHatalıTahminler == 3)
                    {
                        pictureBox1.Image = Resources.realBacak1;
                    }
                    if (tahminEdilenHatalıTahminler == 4)
                    {
                        pictureBox1.Image = Resources.realBacak2;
                    }
                    if (tahminEdilenHatalıTahminler == 5)
                    {
                        pictureBox1.Image = Resources.realKol1;
                    }
                    if (tahminEdilenHatalıTahminler == 6)
                    {
                        pictureBox1.Image = Resources.realKol2;
                        MessageBox.Show("Hata yaptınız.");

                        Tekrar();

                    }
                }
            }
            if (tahmin.Length == 1 && char.IsLetter(tahmin[0]))
            {
                char tahminMesajı = tahmin[0];
            
                if (!tahminEdilenHarfler.Contains(tahminMesajı))
                {
                    tahminEdilenHarfler.Add(tahminMesajı);
                    if (tahminEdilecekKelime.Contains(tahminMesajı))
                    {
                        updateKelimeEkranı(tahminMesajı);
                    }
                    else
                    {
                        tahminEdilenHatalıTahminler++;
                        labelHata.Text = "Hatalı Tahmin: " + tahminEdilenHatalıTahminler;
                        if (tahminEdilenHatalıTahminler == 1) {
                            pictureBox1.Image = Resources.realKafa;
                        }
                        if (tahminEdilenHatalıTahminler == 2)
                        {
                            pictureBox1.Image = Resources.realGovde;
                        }
                        if (tahminEdilenHatalıTahminler == 3)
                        {
                            pictureBox1.Image = Resources.realBacak1;
                        }
                        if (tahminEdilenHatalıTahminler == 4)
                        {
                            pictureBox1.Image = Resources.realBacak2;
                        }
                        if (tahminEdilenHatalıTahminler == 5)
                        {
                            pictureBox1.Image = Resources.realKol1;
                        }
                        if (tahminEdilenHatalıTahminler == 6)
                        {
                            pictureBox1.Image = Resources.realKol2;
                            label1Ekran.Text = tahminEdilecekKelime;
                                MessageBox.Show("Oyun bitti! Kelime şuydu: " + tahminEdilecekKelime);
                                Tekrar();

                             

                        }

                    }
                    
                     if (kelimeEkranı == tahminEdilecekKelime)
                    {
                        MessageBox.Show("Tebrikler! Şu kelimeyi doğru tahmin ettin: " + tahminEdilecekKelime);
                        Tekrar();
                    }
                }
               
            }
            textTahmin.Text = "";
            textTahmin.Focus();
        }
        private void updateKelimeEkranı(char tahminMesajı)
        {
            char[] kelimeEkranDizisi = kelimeEkranı.ToCharArray();
            for (int i = 0; i < tahminEdilecekKelime.Length; i++)
            {
                if (tahminEdilecekKelime[i] == tahminMesajı)
                {
                    kelimeEkranDizisi[i] = tahminMesajı;
                }
            }
            kelimeEkranı = new string(kelimeEkranDizisi);
            label1Ekran.Text = kelimeEkranı;
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
