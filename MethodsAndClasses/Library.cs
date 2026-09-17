using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MethodsAndClasses
{
    public class Library
    {
        public string Name {  get; set; }
        private List<Book> _books;
        public Library(string name)
        {
            Name = name;
            _books = new List<Book>();
        }
        public void AddBook(Book book)=>_books.Add(book);
        public void PrintAll()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book.Describe());
            }
        }
        public int BookCount { get { return _books.Count; }}
        public string FindByTitle(string title) => _books.Where(x => x.Title == title).Select(x => x.Describe()).FirstOrDefault() ?? null;
        public List<Book> FindByAuthor(string author) => _books.Where(x => x.Author == author).ToList();
        public int TotalPages()=>_books.Select(x=>x.PageCount).Sum();
        public double AveragePages()
        {
            if (_books.Any())
            {
                return _books.Select(x => x.PageCount).Average();
            }
            else
            {
                return 0;
            }
        }
        public List<Book> AvailableBooks() => _books.Where(x => x.IsAvailable).Select(x => x).ToList();


    }
}
