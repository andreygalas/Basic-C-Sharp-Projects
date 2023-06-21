using System;

namespace UserInputOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user
            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();

            // Parses the user input to a double
            double number = double.Parse(userInput);

            // Multiplies the input by 50 and prints the result
            double multipliedResult = number * 50;
            Console.WriteLine("Multiplied Result: " + multipliedResult);

            // Adds 25 to the input and prints the result
            double addedResult = number + 25;
            Console.WriteLine("Added Result: " + addedResult);

            // Divides the input by 12.5 and prints the result
            double dividedResult = number / 12.5;
            Console.WriteLine("Divided Result: " + dividedResult);

            // Checks if the input is greater than 50 and prints the true/false result
            bool isGreaterThan50 = number > 50;
            Console.WriteLine("Is Greater Than 50: " + isGreaterThan50);

            // Divides the input by 7 and prints the remainder
            double remainder = number % 7;
            Console.WriteLine("Remainder: " + remainder);

            // Wait for user input to exit the program
            Console.ReadLine();
        }
    }
}

