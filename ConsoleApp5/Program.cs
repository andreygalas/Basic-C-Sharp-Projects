using System;
using System.Linq;
using System.Data.Entity;

namespace StudentDatabase
{
    // define the Student class as an Entity
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                //add student to the database
                var newStudent = new Student
                {
                    FirstName = "Andrey",
                    LastName = "Galas"
                };

                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }
        }
    }
}
