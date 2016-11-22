using System.Collections.Generic;

namespace ConsoleApplication.Models
{


    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public bool Alive { get; set; }

        private Pet Pet { get; set; }

        public List<Car> Cars = new List<Car>();

        public List<Family> Familys = new List<Family>();
        public Person(string name, int age, bool alive = true)
        {
            Name = name;
            Age = age;
            Alive = alive;
        }
        public void Birthday()
        {
            Age++;
        }
        public void AddPet(Pet pet)
        {
            Pet = pet;
        }
        public Pet GetPet()
        {
            return Pet;
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void AddFamily(Family family)
        {
            Familys.Add(family);
        }

    }
}