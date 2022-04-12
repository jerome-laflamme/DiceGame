using PersonLib;

namespace PersonProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Denis", DateOnly.Parse("2000-05-25"));
            Person person2 = new Person(2,"Alice", DateOnly.Parse("2000-04-29"));
            Person person3 = new Person(3,"Alice", DateOnly.Parse("2000-02-28"));

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            // person3.Name = "";
            Console.WriteLine(person3);
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person3 == person2);
            Console.WriteLine(person3.Equals(person2));

            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person3.Age);
        }
    }
}