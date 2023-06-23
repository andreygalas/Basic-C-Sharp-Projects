// See https://aka.ms/new-console-template for more information
using System;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the applicant's age
        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        // Ask if the applicant has ever had a DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool dui = bool.Parse(Console.ReadLine());

        // Ask how many speeding tickets the applicant has
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = int.Parse(Console.ReadLine());

        // Evaluate the qualification rules using boolean expressions
        bool isOver15 = age > 15;
        bool noDUI = !dui;
        bool noExcessiveSpeedingTickets = speedingTickets <= 3;

        // Determine if the applicant qualifies for car insurance
        bool qualified = isOver15 && noDUI && noExcessiveSpeedingTickets;

        // Print the result
        Console.WriteLine("Qualified? " + qualified);
    }
}

