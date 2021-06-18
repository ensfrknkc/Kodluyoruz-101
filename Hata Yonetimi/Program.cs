using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi : " + sayi);
            }
            catch (Exception ex)
            {
                // try ya hata varsa burada yakalnıyor.
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                // Hata alsın almasın kullanıcıya bu mesajı gösteriyoruz. finally bu işe yarıyor.Zorunlu değil finally scope
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch(ArgumentNullException ex)
            {
                //kullanıcı null yani boş değer girdiği zaman catch de onu yakalıyoruz.
                Console.WriteLine("Boş deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                // integer çevirilemeyen bir deger girildiginde, ornegin bir string deger girildiginde formata uygun olmadıgı icin bu sekilde hatayı yakalıyoruz. 
                Console.WriteLine("Veri tipip uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                //Veri tipinin alabilecegi deger fazlasi girildiginde alinan bir hata tipidir.
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarı ile tamamlandı.");
            }
        }
    }
}
