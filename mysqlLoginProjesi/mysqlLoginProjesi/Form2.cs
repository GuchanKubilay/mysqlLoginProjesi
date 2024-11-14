using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace mysqlLoginProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            string yeniKullanici = txtYeniKullanici.Text;
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;
            bool od = on_dogrulama(yeniKullanici, sifre, sifreTekrar); //ön doğrulamamı gerçekleştirdim ve değerini od değişkenine atadım
            if (od) //eğer od true ise kayıt işlemini gerçekleştirsin
            {
                Form1.veritabani_baglantisi();// Form1'de oluşturduğum metodu kullanarak bağlantımı açtım
                MySqlCommand cmd = new MySqlCommand(); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
                cmd.CommandText = "INSERT INTO giris_bilgileri(kullanici_adi, sifre) values(@ykullanici, @sifre)"; //Nesnenin içine sorgumu yazdım
                cmd.Parameters.AddWithValue("@ykullanici", yeniKullanici);
                cmd.Parameters.AddWithValue("@sifre", sifre); //textboxlara girilen değerleri, parametrelere aktardım
                cmd.Connection = Form1.baglanti; //Form1'deki public static tanımladığım ve tekrar yazmak zorunda kalmadığım veritabanı bağlantımı kullanarak sorgumu yolladım
                int etki = cmd.ExecuteNonQuery(); //Etkilenen kayıt sayısını "etki" değişkenine atadım
                if (etki != 0) //Eğer kayıt eklendiyse, degisken sıfırdan farklı olacaktır ki o halde kayıt başarılıdır
                {
                    MessageBox.Show("Kayıt başarılı!");
                }
                else
                    MessageBox.Show("Kayıt başarısız!");
                Form1.baglanti.Close(); //En son kullanmadığım için bağlantımı kapadım
            }

            bool on_dogrulama(string yk, string s, string st) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
            {
                if (yk == "" || s == "" || st == "") //Eğer herhangi bir textbox boşsa false değeri döndürsün
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun");
                    return false;
                }
                if (s != st) //şifre ve tekrarı aynı değilse false değeri döndürsün
                {
                    MessageBox.Show("Girdiğiniz şifre ve tekrarı birbiriyle uyuşmuyor!");
                    return false;
                }
                else //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                    return true;
            }



        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            /*Eğer giriş yapma ekranına bu şekilde dönmek isterseniz, döndüğünüz ve gizlediğiniz(hide ile) o pencere eski pencere
             * olmayacaktır. Bunu textboxlar içine değer girdikten sonra, geçiş yaparak deneyebilirsiniz. Mutlaka o yazdıklarınız silinmiş
             * olacaktır.*/
            this.Hide(); //Formu arkaplanda çalışması için gizledim
            Form1 f1 = new Form1(); //Form1'in kopyasını oluşturup
            f1.Show(); //Ekranda göster dedim
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Aynı şekilde diğer formdaki gibi bu formunda kapanma olayına uygulumadan çıkış metotunu ekledim
        }
    
    }
}
