using System.ComponentModel.DataAnnotations;
using System.Configuration.Provider;
using System.Data.Entity;
using System.Xml.Linq;

public class Student
{
    public int StudentId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }
}




public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}


