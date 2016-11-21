namespace ConsoleApplication.Models
{


    public class Person
    {
       
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Alive { get; set; }
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
    }
}