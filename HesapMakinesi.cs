namespace WinFormsApp1
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        string islem; // islem(str): string.Empty || "+","-","*","/"
        double sayi1, sayi2, sonuc; // sayisal degiskenler(double)

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub: selimsvc ", "Selim Eren Sürmeli"); // imza

            gecmis.Text = "0"; // gecmis varsayilan degeri
            ekran.Text = "0"; // ekran varsayilan degeri
            islem = string.Empty; // islemi secilmedi olarak ayarla
            sayi1 = 0; // ne oldugu belli
            sayi2 = 0; // '' '' ''
            sonuc = 0; // '' '' ''
        }

        private void sifirkontrol() // ekrana 01 yazilmasini onlemek icin 0 silici
        {
            if (ekran.Text == "0")
            {
                ekran.Text = string.Empty;
            }
        }

        private void sayi1_aktar()
        {
            sayi1 = Convert.ToDouble(ekran.Text) + 0; // ekrandaki yaziyi sayi1 degiskenine aktar
            gecmis.Text = sayi1.ToString() + " " + islem; // gecmise sayi1 ve islemi yazdir, örnek(str): "1" + islem = 1 +
            ekran.Text = "0"; // ekrani temizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button1.Text; // 1(str)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button2.Text; // 2(str)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button3.Text; // 3(str)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button4.Text; // 4(str)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button5.Text; // 5(str)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button6.Text; // 6(str)
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button7.Text; // 7(str)
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button8.Text; // 8(str)
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sifirkontrol();
            ekran.Text = ekran.Text + button9.Text; // 9(str)
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0")
            {
                ekran.Text = "0";
            }
            else
            {
                ekran.Text = ekran.Text + button10.Text; // 0(str)
            }
        }

        private void button11_Click(object sender, EventArgs e) // +
        {
            islem = "+"; // islemi toplama olarak ayarla
            sayi1_aktar();
        }

        private void button12_Click(object sender, EventArgs e) // -
        {
            islem = "-"; // islemi cikarma olarak ayarla
            sayi1_aktar();
        }

        private void button13_Click(object sender, EventArgs e) // *
        {
            islem = "*"; // islemi carpma olarak ayarla
            sayi1_aktar();
        }

        private void button14_Click(object sender, EventArgs e) // /
        {
            islem = "/"; // islemi bolme olarak ayarla
            sayi1_aktar();
        }

        private void button15_Click(object sender, EventArgs e) // =(sonucu hesapla)
        {
            sayi2 = Convert.ToDouble(ekran.Text) + 0; // son durumu sayi2 degiskenine aktar
            ekran.Text = string.Empty; // ekrani temizle
            switch (islem) // secilen islemi uygula
            {
                case "+":
                    sonuc = sayi1 + sayi2; // topla
                    break;
                case "-":
                    sonuc = sayi1 - sayi2; // cikar
                    break;
                case "*":
                    sonuc = sayi1 * sayi2; // carp
                    break;
                case "/":
                    if (sayi2 != 0) // bol(0 degilse)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        MessageBox.Show("Sıfıra bölünemez.", "Hata!"); // hata mesaji goster
                    }
                    break;
            }
            gecmis.Text = sayi1.ToString() + " " + islem + " " + sayi2.ToString(); // islemi tek kullanimlik gecmise kaydet
            ekran.Text = sonuc.ToString(); // sonucu ekrana yazdir
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ekran.Text = ekran.Text + ","; // "," / örnek(string): 0 + , + 1 = 0,1
        }

        private void button16_Click(object sender, EventArgs e) // temizle
        {
            gecmis.Text = "0"; // gecmisi temizle
            ekran.Text = "0"; // ekrani temizle
            islem = string.Empty; // islemi secili degil olarak ayarla
        }

        private void button18_Click(object sender, EventArgs e) // cikis
        {
            gecmis.Text = "0"; // gecmisi temizle
            ekran.Text = "0"; // ekrani temizle
            islem = string.Empty; // islemi secili degil olarak ayarla
            Application.Exit(); // uygulamadan cik
        }
    }
}