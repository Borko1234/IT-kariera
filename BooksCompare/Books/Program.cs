using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "DorothySayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            SortedSet<Book> set= new SortedSet<Book>();
            set.Add(bookOne);
            set.Add(bookTwo);
            set.Add(bookThree);
            foreach (Book book in set)
            {
                Console.WriteLine(book);
            }
            if (bookOne.CompareTo(bookTwo) < 0)
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
