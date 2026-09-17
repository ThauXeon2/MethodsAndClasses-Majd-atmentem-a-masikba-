using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Librarian
    {
        public string Name { get; set; }
        private Library _library;
        public Librarian(string name, Library library)
        {
            Name = name;
            _library = library;
        }
        public void Introduce() => Console.WriteLine($"{Name}, {_library.Name}");
        public void AddBook(string title, string author, int pageCount)
        {
            _library.AddBook(new(title,author,pageCount));
            Console.WriteLine("Könyv hozzáadva.");
        }
        public void LendBook(string title)
        {
            //
        }
    }
}
