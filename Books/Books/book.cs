using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
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
	}
}
