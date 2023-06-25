using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace LoopComparisonDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Boolean comparison using a while loop
                Console.WriteLine("Boolean comparison using a while loop:");

                int i = 1; // Initialize a counter variable

                while (i <= 5) // Perform the loop while the condition is true
                {
                    Console.WriteLine("Current value of i: " + i); // Output the current value of i

                    i++; // Increment the counter by 1
                }

                Console.WriteLine();

                // Boolean comparison using a do-while loop
                Console.WriteLine("Boolean comparison using a do-while loop:");

                int j = 1; // Initialize a counter variable

                do
                {
                    Console.WriteLine("Current value of j: " + j); // Output the current value of j

                    j++; // Increment the counter by 1

                } while (j <= 5); // Perform the loop while the condition is true

                Console.WriteLine();

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
