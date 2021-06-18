using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;  // bellekte 1 byte yer kaplar, 0-255 ararsında deger alabilir
            sbyte c = 5; // bellekte 1 byte yer kaplar, -128 -- 127 arasında deger alabilir

            short s = 5;   //bellelte 2 byte yer kaplar, -32768 -- 32768 deger alabilir.
            ushort us = 5; //bellekte 2 byte yer kaplıyor, 0-65365 deger alabilir. pozitif deger alabiliyor.

            Int16 i16 = 2; //bellekte 2 byte yer kaplar, 
            int i = 2;     //bellekte 4 byte yer kaplar,
            Int32 i32 = 2; //bellekte 4 byte yer kaplar,
            Int64 i64 = 2; //bellekte 8 byte yer kaplar,

            uint ui = 2;  // bellekte 4 byte yer kaplıyor,
            long l = 4;   //bellekte 8 byte yer kaplıyor,
            ulong ul = 4; // bellekte 8 byte yer kaplıyor.

            float f = 5;     //bellekte 4 byte yer kaplıyor.
            double d = 5;    //bellekte 8 byte yer kaplıyor.
            decimal de = 5;  //bellekte 16 byte yer kaplar.

            char ch = '2';   //bellekte 2 byte yer kaplar.
            string str = "Mustafa"; // sınırsız


            bool b1 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';   // her veri türünü obje cinsinde yazabiliriz.
            object o3 = 3;
            object o4 = 4.3;


            //string ifadeler

            string str1 = string.Empty;
            str1 = "Mustafa Taşdemir";
            string ad = "Mustafa";
            string soyad = "Taşdemir";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);


            //integer tanımlama şekilleri

            int sayi1 = 5;
            int sayi2 = 3;
            int sayi3 = sayi1 * sayi2;


            //boolean

            bool bool1 = 10 < 2;
            Console.WriteLine(bool1);


            //degisken donusumleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);


            //DateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}
