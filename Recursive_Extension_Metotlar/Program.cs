using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli
            //3^4 = 3*3*3*3 = 81

            int result =1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade = "Deniz Yenidoğan";
            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.removeWhiteSpaces());
            Console.WriteLine(ifade.makeUpperCase());
            Console.WriteLine(ifade.makeLowerCase());

            int[] dizi = {9,3,6,2,1,5,0};

            dizi.sortArray();
            dizi.ekranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.getFirstCharacter());

        }
    }

    public class Islemler
    {
        public int Expo (int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3*3;
        //Expo(3,1)*3*3*3;
        //*3*3*3*3 = 3^4;
    }

    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi); // "" arasına ne girersek onu ekler.
        }

        public static string makeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string makeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] sortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void ekranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
