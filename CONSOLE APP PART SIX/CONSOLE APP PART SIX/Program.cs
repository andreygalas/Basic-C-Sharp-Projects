using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_PART_SIX
{
    class Program
    {
        static void Main(string[] args)

        {
         
            {
                List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };
                List<string> uniqueStrings = new List<string>();

                foreach (string str in stringList)
                {
                    if (uniqueStrings.Contains(str))
                    {
                        Console.WriteLine($"{str} - this item is a duplicate");
                    }
                    else
                    {
                        uniqueStrings.Add(str);
                        Console.WriteLine($"{str} - this item is unique");
                    }
                }

                Console.ReadLine();
            }
        }

    }
}
