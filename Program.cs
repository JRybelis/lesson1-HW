using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your forename:");
            string forename = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"It is nice to meet you, {forename} {surname}!");

            Console.WriteLine();
            Console.WriteLine("May we have your date of birth, please? Supply it as YYYY/MM/DD.");
            Console.WriteLine("Year:");
            int yearBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int monthBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Day:");
            int dayBorn = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            DateTime dateOfBirth = new DateTime(yearBorn, monthBorn, dayBorn);
            DateTime today = DateTime.Today;
            int age = Convert.ToInt32(today.Year) - Convert.ToInt32(dateOfBirth.Year);
           

            Console.WriteLine($"Excellent, it follows that you are currently {age} years old.");
        }

    }
}
