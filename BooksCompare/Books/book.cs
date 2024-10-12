using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book:IComparable<Book>
    {

		public Book(string title, int year, params string[] authors) 
		{
			this.Title = title;
			this.Year = year;
			this.Authors = authors;
		}
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int result=this.Year.CompareTo(other.Year);
			if (result == 0)  result=this.Title.CompareTo(other.title);
			return result;
        }
		public override string ToString()
		{
			return $"{Title}-{Year}";
		}
    }
}
