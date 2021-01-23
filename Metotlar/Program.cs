using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Çilek";
            urun1.Fiyati = 14;
            urun1.Aciklama = "Yerli Çilek";


            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbekir karpuzu";

            Product urun3 = new Product();
            urun3.Adi = "Armut";
            urun3.Fiyati = 30;
            urun3.Aciklama = "Kastamonu armutu";

            Product[] urunler = new Product[] {urun1, urun2, urun3};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");


            }
            Console.WriteLine("-------------------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
        }
    }
}
