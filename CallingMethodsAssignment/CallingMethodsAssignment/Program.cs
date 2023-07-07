using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Ask the user for a number to perform the math operations on
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());

        // Create an instance of the MathOperations class
        MathOperations math = new MathOperations();

        // Call each method in turn, passing the user input, and display the returned integers
        int result1 = math.Add(userInput);
        Console.WriteLine($"Result of addition: {result1}");

        int result2 = math.Multiply(userInput);
        Console.WriteLine($"Result of multiplication: {result2}");

        int result3 = math.Subtract(userInput);
        Console.WriteLine($"Result of subtraction: {result3}");

        Console.ReadLine();
    }
}
