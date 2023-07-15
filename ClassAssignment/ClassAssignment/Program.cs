using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Instantiate the class
            Method myOp = new Method();

            // Call the method in the class and display the output
            int result = myOp.DivideByTwo(userInput);
            Console.WriteLine("The result of dividing the number by 2 is: " + result);

            Console.ReadLine();
        }
    }

    class Method
    {
        // Method that divides the input by 2 and returns the result
        public int DivideByTwo(int number)
        {
            return number / 2;
        }

        // Method with output parameters
        public void MultiplyByTwo(int number, out int result)
        {
            result = number * 2;
        }

        // Overloaded method with different parameter types
        public void MultiplyByTwo(double number)
        {
            double result = number * 2;
            Console.WriteLine("The result of multiplying the number by 2 is: " + result);
        }
    }
}
