using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student natasha = new Student("Natasha", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + natasha.Name + " is a student!");
        }
    }
}
