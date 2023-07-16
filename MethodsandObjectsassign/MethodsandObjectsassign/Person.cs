using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsassign
{
    public class Person
    {
        //Person name definition 
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Method to display persons first and last name 
        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}