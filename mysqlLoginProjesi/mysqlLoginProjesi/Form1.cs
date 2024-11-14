using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //mysql ba�lant�s� i�in
using MySql.Data;
namespace mysqlLoginProjesi
        
{
    public partial class Form1 : Form
    {
        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=test_veritabani; Uid=root; Pwd=;");

        public static void veritabani_baglantisi() // Veritaban� ba�lant�s�n� a�mak i�in ayr� bir metot olu�turdum
        {
            try // Ba�lant�da sorun olu�mas� durumunda hatan�n ne oldu�unu ��renebilmek i�in try-catch kulland�m
            {
                baglanti.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); //Ba�lant�y� a�arken hata olu�ursa, ayr�nt�l� bir �ekilde bunu g�rebileyim
            }
        }

        bool giris_dogrulama(string kAdi, string sifre) //Giri�i do�rulamak i�in ayr� bir metot olu�turdum, geriye bool tipi de�er d�nd�recek
        {
            veritabani_baglantisi(); //veritabani_baglantisi metotunu �a��rarak veritaban�na ba�lant�y� a�t�m
            MySqlCommand cmd = new MySqlCommand(); //Veritaban�na g�nderece�im sorguyu tutabilmesi i�in nesne olu�turdum
            //NOT: MySqlCommand veritaban� �zerinde sorgulama, ekleme, g�ncelleme, silme i�lemlerini yapmak i�in kullan�l�r
            cmd.CommandText = "SELECT * FROM giris_bilgileri WHERE kullanici_adi=@kAdi AND sifre=@sifre"; //Nesnenin i�ine sorgumu yazd�m
            cmd.Parameters.AddWithValue("@kAdi", kAdi); //textboxlara girilen de�erleri, parametrelere aktard�m
            cmd.Parameters.AddWithValue("@sifre", sifre); //Not: Parametre kullanarak injection'a kar�� �nlem al�yorum
            cmd.Connection = baglanti; //Komutu veritaban�na yollad�m
            MySqlDataReader login = cmd.ExecuteReader(); //MySqlDataReader'�, yollad���m komuttan d�nen de�erleri sat�r sat�r okumas� i�in kulland�m
            if (login.Read()) //Read metodu geriye bool t�r�nde de�er d�nd�r�r
            {
                baglanti.Close();
                return true; //Okunacak sat�r var ise true de�er d�nd�r�r
            }
            else
            {
                baglanti.Close();
                return false; // Okunacak de�er yoksa da false de�eri d�nd�r�r
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e) //Giri� Yap butonuna t�klad���mda �al��acak kodlar� yazd�m
        {
            string kAdi = txtKullaniciAdi.Text; //textboxtaki de�erleri string de�i�kenlere atad�m
            string sifre = txtSifre.Text;
            if (kAdi == "" || sifre == "") //E�er textboxlardan biri bo�sa beni uyars�n ve i�lem yapmas�n
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun");
                return;
            }
            bool a = giris_dogrulama(kAdi, sifre); //giris_dogrulama metotuna giri� bilgilerini yollad�m ve bool tipinde bir de�er elde ettim
            if (a) //D�nen de�er true ise yani bilgiler veritaban�ndaki kay�tlarda mevcutsa if kod blo�u �al��s�n
            {
                MessageBox.Show("Giri� Do�ruland�.");
                //Not: Bu if blo�una giri� do�ruland���nda ger�ekle�misini istedi�iniz kodlar� yazabilirsiniz
            }
            else //D�nen de�er true de�ilse yani false ise bu kod blo�u �al��s�n
                MessageBox.Show("Hatal� Kullan�c� Ad� veya �ifre!");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblKaydol_Click_Click(object sender, EventArgs e)
        {

        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            this.Hide(); //Bu formu gizleyip, arkaplanda bekletsin
            Form2 f2 = new Form2(); //Form2'den bir kopya olu�tursun ve
            f2.Show(); //Bunu ekranda g�stersin, yani kaydolma ekran�na ge�i� yaps�n
        }
    }
}
