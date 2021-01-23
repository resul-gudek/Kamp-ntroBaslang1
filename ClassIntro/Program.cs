using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Resul";
            kurs1.KursAdi = "C# Dersi";
            kurs1.IzlenmeOrani = 93;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Mehmet";
            kurs2.KursAdi = "Python Dersi";
            kurs2.IzlenmeOrani = 102;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Lokman";
            kurs3.KursAdi = "Java Dersi";
            kurs3.IzlenmeOrani = 150;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }



}
