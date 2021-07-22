using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Library.Classes
{
	public class Book
	{
		public string Title { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public int numberOfPages { get; set; }

		// Book constructor ( able to initialize a new book ) 
		public Book(string title, string first, string last, int numOfPages)
		{
			this.Title = title;
			this.firstName = first;
			this.lastName = last;
			this.numberOfPages = numOfPages;
		}
	}
}
