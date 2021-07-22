using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab08_Library;
using Lab08_Library.Interfaces;

namespace Lab08_Library.Classes
{
	public class Library : ILibrary
	{
		public int Count { get; set; } = 0;

		private Dictionary<string, Book> storage { get; set; }

		private List<string> temp { get; set; }


		public string DisplayBooks()
		{
			string display = "";
			// For every book in library, display the title.
			foreach(string book in temp)
			{
				display += book;
				Console.WriteLine($"{book}");
			}
			return display;
		}
		public string Add(string title, string first, string last, int numOfPages)
		{
			// Create a new book from the parameters given when we add.
			Book newBook = new Book(title, first, last, numOfPages);
			//Add the book to our Dictionary.
			storage.Add(title, newBook);
			temp.Add(title);
			// Increase count by 1
			Count++;
			return newBook.Title;
		}

		public Book Borrow(string title)
		{
			Book bookToBorrow = storage.GetValueOrDefault(title);
			storage.Remove(title);
			temp.Remove(title);
			Count--;
			Console.WriteLine($"Borrowing the book {title}..");
			return bookToBorrow;
		}


		public void Return(Book book)
		{
			// Add the book back to the library (from the satchel)
			storage.Add(book.Title, book);
			Count++;
		}

		public IEnumerator<string> GetEnumerator()
		{
			return temp.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return storage.GetEnumerator();
		}

		IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
		{
			throw new NotImplementedException();
		}

	}
}
