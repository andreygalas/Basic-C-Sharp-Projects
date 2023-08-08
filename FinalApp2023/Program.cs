// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


using System;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        // Ensure the database is created and apply any pending migrations.
        using (var context = new StudentDbContext())
        {
           
        }

        // Add a student to the database.
        using (var context = new StudentDbContext())
        {
            var student = new Student
            {
                Name = "John Doe",
                Age = 20
            };

            context.Students.Add(student);
            context.SaveChanges();
        }

        Console.WriteLine("Student added successfully!");
    }
}



public class Student
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }

    public int Age { get; set; }
}

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseSqlServer("Server=ANDREY\\SQLEXPRESS;Database=aspnet-WebApplication3-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true", options => options.EnableRetryOnFailure());

    }

}