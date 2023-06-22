using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1Input = Console.ReadLine();
            double hourlyRate1 = double.Parse(hourlyRate1Input);

            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeek1Input = Console.ReadLine();
            double hoursWorkedPerWeek1 = double.Parse(hoursWorkedPerWeek1Input);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2Input = Console.ReadLine();
            double hourlyRate2 = double.Parse(hourlyRate2Input);

            Console.WriteLine("Hours worked per week?");
            string hoursWorkedPerWeek2Input = Console.ReadLine();
            double hoursWorkedPerWeek2 = double.Parse(hoursWorkedPerWeek2Input);

            double salary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            double salary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1.ToString("N0"));

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2.ToString("N0"));

            bool person1MakesMore = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1MakesMore);

            Console.ReadLine();
        }
    }
}
