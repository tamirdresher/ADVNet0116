using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new[]
            {
                new Book() {Name = "11", Year = 2010},
                new Book() {Name = "12", Year = 2011}
            };

            IEnumerable<IGrouping<int, Book>> groups = 
                books.GroupBy(b => b.Year);

            IEnumerable<IGrouping<int, Book>> yearGroups = 
                from book in books
                from book2 in books
                let year= book.Year-book2.Year
                group book by book.Year
                into g 
                select g;

            var bookGroups = 
                from g in yearGroups
                orderby g.Key descending
                select new {Year = g.Key, Books = g, Count=g.Count()};
        }
    }

    class BookGroup
    {
        public int Year { get; set; }
        public IEnumerable<Book> Books { get; set; } 
    }

    internal class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
