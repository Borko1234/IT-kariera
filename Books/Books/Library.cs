using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Library
    {
        public List<Book> books;
        public Library(params Book[] books) 
        {
            this.books = new List<Book>(books);
        }
        
    }
}
