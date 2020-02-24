using System;

namespace WeedenAssignment4Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.Display();

            Iteration people = new Iteration();

            people.AddFullTime("John", 1);
            people.AddFullTime("Cindy", 2);
            people.AddFullTime("Laurie", 3);
            people.AddFullTime("Gonzo", 4);
            people.AddFullTime("Franko", 5);
            people.AddPartTime("Juan", 6);
            people.AddPartTime("Lizzy", 7);
            people.AddPartTime("Bob", 8);
            people.AddPartTime("Gordon", 9);
            people.AddPartTime("Rich", 10);

            Console.WriteLine("\n\nNames of all employees:\t");
            foreach (string name in people)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("\n\nNames of all full-time employees:\t");
            foreach (string name in people.FullTime)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("\n\nNames of all part-time employees:\t");
            foreach (string name in people.PartTime)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("\n\nNames of all even numbered ID employees:\t");
            foreach (string name in people.EvenNumbers)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
