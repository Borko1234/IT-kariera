using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class LibraryIterator : IEnumerator<Book>
    {

        private readonly List<Book> books;
        private int currentIndex;
        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }
        public void Dispose() { }
        public bool MoveNext()
        {
            if (currentIndex < books.Count) {
                ++currentIndex; return true;

            }
            return false;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public Book Current => this.books[this.currentIndex];
        object IEnumerator.Current => this.Current;

        
    }
}
