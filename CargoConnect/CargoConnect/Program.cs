using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = double.Parse(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt for package dimensions
            Console.WriteLine("Please enter the package width:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = double.Parse(Console.ReadLine());

            // Calculate total dimensions
            double dimensionsTotal = width + height + length;

            // Check if dimensions total is greater than 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
    