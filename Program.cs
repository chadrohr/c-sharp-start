using System;
using ConsoleApplication.Models;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello how are you today?");

            Console.WriteLine("What is your Name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name} its nice to meet you.");
            Console.WriteLine("How old are you?");
            
            var x = new Pet("Obi");
            

            var chad = new Person("Chad", 46);
            int a = 0;
            var age = Console.ReadLine();
            while (!int.TryParse(age, out a))
            {
                Console.WriteLine($"Sorry that is not a good type");
                age = Console.ReadLine();
            }
            Console.WriteLine($"Your {age} years old!!");

            var person = new Person(name, a);

            var dog = new Pet("Fido");

            person.AddPet(dog);

            var truck = new Car("Chevy", "Nova");

            person.AddCar(truck);

            Console.WriteLine(person.GetPet().Name);

            Console.ReadKey();


        }
    }

}

