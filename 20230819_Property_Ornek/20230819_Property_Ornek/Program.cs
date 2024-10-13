using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_Property_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici k= new Kullanici();
            k.kullaniciAdi = "admin";
            k.ParolaTanimla = "123";

            k.GirisYap("admin","123");

            Console.ReadKey();
        }
    }
}
