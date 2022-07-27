using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time < 11)
                Console.WriteLine("Good Morning Sir!");
            else if(time<= 18)
                Console.WriteLine("Good Day Sir!");
            else
                Console.WriteLine("Good Night Sir!");

            string sonuc = time<=18 ? "Good Day Sir!" : "Good Night Sir!";

            sonuc = time>= 6 && time <11 ? "Good Morning Sir!" : time <= 18 ? "Good Day Sir!" : "Good Night Sir!";
            Console.WriteLine(sonuc);
        }
    }
}
