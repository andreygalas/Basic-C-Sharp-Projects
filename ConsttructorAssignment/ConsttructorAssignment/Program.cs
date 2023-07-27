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
            const string defaultTitle = "Unknown"; //Create a constant
            var defaultAuthor = "Anonymous"; //Create a string using Var

            Book book1 = new Book(); //Using the default constructor
            Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

            Console.WriteLine("Book 1: " + book1.Title + " by " + book1.Author);
            Console.WriteLine("Book 2: " + book2.Title + " by " + book2.Author);

            Console.ReadLine();
        }
    }

     // Chain two constructors together
     public class Book
    {
        public Book() : this("Unknown", "Anonymous") { }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
    }
}
