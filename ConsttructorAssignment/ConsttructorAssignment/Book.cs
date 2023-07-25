using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsttructorAssignment
{
    class Book
    {
        //define properties for the Book class
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            this.Title = "Unknown";
            this.Author = "Anonymous";
        }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}

