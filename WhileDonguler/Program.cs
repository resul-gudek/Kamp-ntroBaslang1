using System;

namespace WhileDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int say = 0;
           int toplam = 0;

            while (say<5)
            {
                toplam += say;
                say++;
            }
            Console.WriteLine(toplam);
        }
    }
}
