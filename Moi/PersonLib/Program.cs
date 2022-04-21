using PersonLib;

namespace PersonProgram;

public class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person(1,"Denis", DateOnly.Parse("2000-05-25"));
        Person person2 = new Person(2,"Alice", DateOnly.Parse("1996-02-29"));
        Person person3 = new Person(2,"Alice", DateOnly.Parse("1997-02-28"));

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        person3.Name = "++";
        Console.WriteLine(person3);
        Console.WriteLine(person1 == person2);
        Console.WriteLine(person1.Equals(person2));
        Console.WriteLine(person3 == person2);
        Console.WriteLine(person3.Equals(person2));

        Console.WriteLine(person1.Age);
            
        /*// person3.Name = null;
        // person3.Id = 4;
        // int y = 3;
        // int x = y > 5 ? 7 : 8;
        // if (y > 5)
        // {
        //     x = 7;
        // }
        // else
        // {
        //     x = 8;
        // }*/

        int[] number1 = new int[5];
        int[] number2 = {4, 1, 8, 5, 9};
        
        Person[] people = new Person[4];
        people[2] = new Person(4, "Jerome", DateOnly.Parse("1994-10-14"));
        people[0] = person1;
        Console.WriteLine(people[2]);

        foreach (Person person in people)
        {
           Console.WriteLine(person);
        }

        List<Person> personlist = new List<Person>();

        personlist.Add(new Person(5, "Billy Bob", DateOnly.Parse("1988-04-05")));
        personlist.Add(person3);
        personlist.Insert(0, person1);
        foreach (Person person in personlist)
        {
            Console.WriteLine(person);
        }

		static int IndexOf(Person[] data, Person target)
		{
            for (int i = 0; i < data.Length; i++)
            {
                if (target.Equals(data[i]))
                {
                    return i;
                }
            }
            return -1;
		}
    }
}