namespace ConsoleApplication.Models
{
    public interface ISpeakable
    {
        string Speak();
    }
    public class Dog : Pet
    {
         public Dog(string name)
         {
             Name = name;
         }
    }
    public class Pet : ISpeakable
    {

        public string Name { get; set; }

        public Pet(string name)
        {
            Name = name;
        }
        public string Speak(){
            return "meow";
        }
    }
}