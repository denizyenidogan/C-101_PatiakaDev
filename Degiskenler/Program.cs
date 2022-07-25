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

            DateTime dt = DateTime.Now; // Bu haliyle anlık tarih ve saat bilgisi veriyor.
            
            Console.WriteLine(dt);
            Console.ReadLine();

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3; //object her türlü veriyi tutabilir. 

            //String ifadeler
            
        }
    }
}
