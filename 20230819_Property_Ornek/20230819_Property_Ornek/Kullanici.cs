using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_Property_Ornek
{
    internal class Kullanici
    {
        public string kullaniciAdi;
        private string _parola;

        public string ParolaTanimla
        {
            set
            {
                _parola = value;
            }
        }

        public void GirisYap(string kAdi,string sifre)
        {
            if (kAdi==kullaniciAdi && sifre==_parola)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
    }
}
