using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate new Employee object and setting name 
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //Call inherited employee method to display the employee name 
            employee.sayName();
            Console.ReadLine();
        }
    }
}