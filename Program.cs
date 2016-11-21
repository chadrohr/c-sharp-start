using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cat = "Garfield";
            cat = "Tom";
            cat = cat.ToUpper();

            for(var i = 0;i<11; i++)
            System.Console.WriteLine(i);
        }
    }
}
