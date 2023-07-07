using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathOperations
{
    // Method to perform addition on the received parameter
    public int Add(int number)
    {
        // Add 5 to the received number
        int result = number + 5;
        return result;
    }

    // Method to perform multiplication on the received parameter
    public int Multiply(int number)
    {
        // Multiply the received number by 10
        int result = number * 10;
        return result;
    }

    // Method to perform subtraction on the received parameter
    public int Subtract(int number)
    {
        // Subtract 3 from the received number
        int result = number - 3;
        return result;
    }
}