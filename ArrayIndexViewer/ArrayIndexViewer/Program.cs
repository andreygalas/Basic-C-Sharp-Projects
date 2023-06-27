using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexViewer
{
    class Program
    {
            static void Main(string[] args)
            {
                // One-dimensional array of strings
                string[] stringArray = { "Apple", "Banana", "Orange", "Mango" };

                Console.WriteLine("Select an index of the string array (0 - 3):");
                int stringIndex = Convert.ToInt32(Console.ReadLine());

                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    string selectedString = stringArray[stringIndex];
                    Console.WriteLine("Selected string: " + selectedString);
                }
                else
                {
                    Console.WriteLine("Invalid index. No string exists at the selected index.");
                }

                Console.WriteLine();

                // One-dimensional array of integers
                int[] intArray = { 10, 20, 30, 40, 50 };

                Console.WriteLine("Select an index of the integer array (0 - 4):");
                int intIndex = Convert.ToInt32(Console.ReadLine());

                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    int selectedInt = intArray[intIndex];
                    Console.WriteLine("Selected integer: " + selectedInt);
                }
                else
                {
                    Console.WriteLine("Invalid index. No integer exists at the selected index.");
                }

                Console.WriteLine();

                // List of strings
                List<string> stringList = new List<string>() { "Dog", "Cat", "Bird", "Fish" };

                Console.WriteLine("Select an index of the string list (0 - 3):");
                int listIndex = Convert.ToInt32(Console.ReadLine());

                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    string selectedString = stringList[listIndex];
                    Console.WriteLine("Selected string: " + selectedString);
                }
                else
                {
                    Console.WriteLine("Invalid index. No string exists at the selected index.");
                }

                Console.WriteLine();

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }

    }
