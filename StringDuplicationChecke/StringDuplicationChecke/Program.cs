using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDuplicationChecke
{

    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Part 1: Create a list of strings that has at least two identical strings in the list
            List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };

            // Part 2: Create a foreach loop that evaluates each item in the list
            foreach (string str in stringList)
            {
                // Part 3: Display a message showing the string
                Console.WriteLine(str);
            }

            // Part 4: Check for duplicates in the list
            List<string> uniqueStrings = new List<string>();
            foreach (string str in stringList)
            {
                if (uniqueStrings.Contains(str))
                {
                    // Part 5: Display a message if the string is a duplicate
                    Console.WriteLine($"{str} - this item is a duplicate");
                }
                else
                {
                    uniqueStrings.Add(str);
                }
            }

            // Part 6: Display a message if the string is unique
            foreach (string str in stringList)
            {
                if (!uniqueStrings.Contains(str))
                {
                    Console.WriteLine($"{str} - this item is unique");
                }
            }

            Console.ReadLine();
        }
    }
}