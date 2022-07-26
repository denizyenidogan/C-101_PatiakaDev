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
                Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString());
                throw;
            }
            
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }

            try
            {
                int a = int.Parse(null);
                //int a = int.Parse("test"); //Format exception
                //int a = int.Parse("-2345678910"); //Overflow exception
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
                throw;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem başarı ile tamamlandı!");
            }
        }
    }
}
