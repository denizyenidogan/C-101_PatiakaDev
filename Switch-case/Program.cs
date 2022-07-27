using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            Console.WriteLine(month);

            switch (month) // Expresion
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız!");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girdiniz!"); // Veri girişi yapılan yapılarda kullanılması daha anlamlı olacaktır.
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mesimindesiniz");
                    break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz");
                    break;

                default:
                    Console.WriteLine("Bahar Mevsimindesiniz");
                break;
            }
        }
    }
}
