using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            String degisken = " ";

            byte b = 5; // byte 0 ile 255 arasında değer alabilir - Bellekte 1 byte yer kaplar.
            sbyte sb = 5; // sbyte -128 ile 127 arasında değer alabilir - Bellekte 1 byte yer kaplar.

            short s = 5; // short -32768 ile 32768 arasında değer alabilir - Bellekte 2 byte yer kaplar.
            ushort us =5; // ushort 0 ile 65356 arasında değer alabilir - Bellekte 2 byte yer kaplar.

            Int16 i16 = 2; // Bellekte 2 byte yer kaplar.
            int i = 2; // Bellekte 4 byte yer kaplar.
            int i32 = 2; // Bellekte 4 byte yer kaplar.
            int i64 = 2; // Bellekte 8 byte yer kaplar.

            uint ui = 2; // Bellekte 4 byte yer kaplar.
            long l = 4; // Bellekte 8 byte yer kaplar.
            ulong ul = 4; // Bellekte 8 byte yer kaplar.

            //Reel sayılar
            float f = 5; // Bellekte 4 byte yer kaplar.
            double d = 5; // Bellekte 8 byte yer kaplar.
            decimal de = 5; // Bellekte 16 byte yer kaplar.

            char c = 'a'; // Bellekte 2 byte yer kaplar.
            string str ="Deniz"; //Bellekte sınırsız yer kaplar

            bool bl = true;
            bool bl2 = false;

            DateTime dt = DateTime.Now; // Bu haliyle anlık tarih ve saat bilgisi vermektedir.
            
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3; //object her türlü veriyi tutabilir. 

            //String ifadeler

            string str1 = ""; // string.Empty ile  aynı il yapılabilir.
            str1 = "Deniz Yenidoğan";
            String name = "Deniz";
            String surname = "Yenidoğan";
            String fullname = name + " " + surname;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bnum = 10<2; // false atama yapacaktır.

            // Değişken Dönüşümleri;

            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();
            Console.WriteLine(newValue);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            //dateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // "dd.MM.yyyy" bu ksımı değiştirilerek istenen formatta alınabilir.
            Console.WriteLine(datetime);

        }
    }
}
