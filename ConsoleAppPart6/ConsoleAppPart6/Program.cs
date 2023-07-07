using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings with at least two identical strings
            List<string> stringsList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Iterate through the list using foreach loop
            foreach (string item in stringsList)
            {
                int count = 0;

                // Check the count of the item in the list
                foreach (string listItem in stringsList)
                {
                    if (item == listItem)
                    {
                        count++;
                    }
                }

                // Display a message indicating whether the item is unique or a duplicate
                if (count > 1)
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            Console.ReadLine();
        }
    }
}