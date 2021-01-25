using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 12;
            musteri1.CustomerNumber = "123456";
            musteri1.Adi = "Resul";
            musteri1.SoyAdi = "Güdek";
            musteri1.TcNo = "23243434535";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 23;
            musteri2.CustomerNumber = "12124";
            musteri2.SirketAdi = "Hatem";
            musteri2.VergiNo = "25369789354";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
        }
    }
}
