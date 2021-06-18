using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While

            //1den baslayarak kullanicidan alinan sayiya kadar ortalama hesaplama
            Console.Write("Sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            int i = 1;
            int toplam = 0;
            int ort = 0;
            while (i <= sayac)
            {
                toplam += i;
                i++;
            }
            ort = toplam / sayac;
            Console.WriteLine("Ortalama: " + ort);


            //a'dan z'ye kadar tüm harfleri yazdır
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }


            //    Foreach

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
