using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıc temel kurs";

            // Array - dizi 
            string[] kurslar = new string[] { "Yazılım", "Kursları", "Programlamaya başlangıc temel kurs", "python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
