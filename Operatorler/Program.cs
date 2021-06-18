using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve Islemli Atama
            int x = 3;
            int y = 3;
            y += 2;
            Console.WriteLine(y);

            //Mantıksal Operatorler ( ||, &&, !)

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }


            // Ilıskısel Operatorler ( <,>,<=,>=, ==, !=)

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);


            //Aritmetik Operatorler ( /, *, +, -)

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 % sayi2;
            Console.WriteLine(sonuc1);


        }
    }
}
