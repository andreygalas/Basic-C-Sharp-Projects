using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsttructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const int myConstVariable = 42;
            Console.WriteLine("The const variable value is: " + myConstVariable);

            //create a variable using the keyword 'var'
            var myVarVariable = "Hello, world!";
            Console.WriteLine("The var variable value is: " + myVarVariable);

            //chain two constructors together
            Book book1 = new Book();

            //Print the book details
            Console.WriteLine("Book 1: " + book1.Title + " by " + book1.Author);

            Console.ReadLine();
        }
    }
}

