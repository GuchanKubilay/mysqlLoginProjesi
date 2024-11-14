using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //mysql baðlantýsý için
using MySql.Data;
namespace mysqlLoginProjesi
        
{
    public partial class Form1 : Form
    {
        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=test_veritabani; Uid=root; Pwd=;");

        public static void veritabani_baglantisi() // Veritabaný baðlantýsýný açmak için ayrý bir metot oluþturdum
        {
            try // Baðlantýda sorun oluþmasý durumunda hatanýn ne olduðunu öðrenebilmek için try-catch kullandým
            {
                baglanti.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); //Baðlantýyý açarken hata oluþursa, ayrýntýlý bir þekilde bunu görebileyim
            }
        }

        bool giris_dogrulama(string kAdi, string sifre) //Giriþi doðrulamak için ayrý bir metot oluþturdum, geriye bool tipi deðer döndürecek
        {
            veritabani_baglantisi(); //veritabani_baglantisi metotunu çaðýrarak veritabanýna baðlantýyý açtým
            MySqlCommand cmd = new MySqlCommand(); //Veritabanýna göndereceðim sorguyu tutabilmesi için nesne oluþturdum
            //NOT: MySqlCommand veritabaný üzerinde sorgulama, ekleme, güncelleme, silme iþlemlerini yapmak için kullanýlýr
            cmd.CommandText = "SELECT * FROM giris_bilgileri WHERE kullanici_adi=@kAdi AND sifre=@sifre"; //Nesnenin içine sorgumu yazdým
            cmd.Parameters.AddWithValue("@kAdi", kAdi); //textboxlara girilen deðerleri, parametrelere aktardým
            cmd.Parameters.AddWithValue("@sifre", sifre); //Not: Parametre kullanarak injection'a karþý önlem alýyorum
            cmd.Connection = baglanti; //Komutu veritabanýna yolladým
            MySqlDataReader login = cmd.ExecuteReader(); //MySqlDataReader'ý, yolladýðým komuttan dönen deðerleri satýr satýr okumasý için kullandým
            if (login.Read()) //Read metodu geriye bool türünde deðer döndürür
            {
                baglanti.Close();
                return true; //Okunacak satýr var ise true deðer döndürür
            }
            else
            {
                baglanti.Close();
                return false; // Okunacak deðer yoksa da false deðeri döndürür
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e) //Giriþ Yap butonuna týkladýðýmda çalýþacak kodlarý yazdým
        {
            string kAdi = txtKullaniciAdi.Text; //textboxtaki deðerleri string deðiþkenlere atadým
            string sifre = txtSifre.Text;
            if (kAdi == "" || sifre == "") //Eðer textboxlardan biri boþsa beni uyarsýn ve iþlem yapmasýn
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun");
                return;
            }
            bool a = giris_dogrulama(kAdi, sifre); //giris_dogrulama metotuna giriþ bilgilerini yolladým ve bool tipinde bir deðer elde ettim
            if (a) //Dönen deðer true ise yani bilgiler veritabanýndaki kayýtlarda mevcutsa if kod bloðu çalýþsýn
            {
                MessageBox.Show("Giriþ Doðrulandý.");
                //Not: Bu if bloðuna giriþ doðrulandýðýnda gerçekleþmisini istediðiniz kodlarý yazabilirsiniz
            }
            else //Dönen deðer true deðilse yani false ise bu kod bloðu çalýþsýn
                MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre!");
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
            Form2 f2 = new Form2(); //Form2'den bir kopya oluþtursun ve
            f2.Show(); //Bunu ekranda göstersin, yani kaydolma ekranýna geçiþ yapsýn
        }
    }
}
