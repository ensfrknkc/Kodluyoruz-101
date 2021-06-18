using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama

            //string[] renkler = new string[5];
            //string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            //int[] dizi;
            //dizi = new int[5];

            ////Dizilere Deger Atama
            //renkler[0] = "Mavi";
            
            //dizi[3] = 10;

            //Console.WriteLine(dizi[3]);
            //Console.WriteLine(hayvanlar[1]);
            //Console.WriteLine(renkler[1]);

            // Donguler Dizi
            //Klavyeden girilen n tane tam sayının ortalamasını hesaplama
            Console.WriteLine("Lutfen dizinin eleman sayisini giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. sayısı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama:" + toplam / diziUzunlugu);
        }
    }
}
