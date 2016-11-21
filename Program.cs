using System;
using ConsoleApplication.Models;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var chad = new Person("Chad", 46);
            var x = new Pet("Obi");
            chad.Birthday();
            Console.WriteLine($"{chad.Name} is {chad.Age}");
        }
    }

}

