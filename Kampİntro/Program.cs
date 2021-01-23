using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        { // type safety - tip güvenliği
            // deger tutucu -alias
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapildiMi = false;

            double dolarDun = 7.43;
            double dolarBugun = 7.43;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs oku");

            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artıs oku");
            }
            else
            {
                Console.WriteLine("degismedi");
            }


            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
