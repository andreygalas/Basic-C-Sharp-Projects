using PolymorphismAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using polymorphism
            IQuittable quittable = new Employee();

            // Call the Quit()
            quittable.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
