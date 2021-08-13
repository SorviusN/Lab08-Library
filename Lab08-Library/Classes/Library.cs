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

		private Dictionary<string, Book> Storage { get; set; }

		public Library()
		{
			// GetEnumerator() allows us to iterate.
			Storage = new Dictionary<string, Book>();
		}

		public string DisplayBooks()
		{
			string display = "";
			// For every book in library, display the title.
			// Will not work with custom collection without GetEnumerator()
			foreach(Book book in Storage.Values)
			{
				display += book.Title;
				Console.WriteLine($"{book.Title}");
			}
			return display;
		}
		public string Add(string title, string first, string last, int numOfPages)
		{
			// Create a new book from the parameters given when we add.
			Book newBook = new Book(title, first, last, numOfPages);
			//Add the book to our Dictionary.
			Storage.Add(title, newBook);
			// Increase count by 1
			Count++;
			return newBook.Title;
		}

		public Book Borrow(string title)
		{
			// Get the title of the book we want to borrow.
			Book bookToBorrow = Storage.GetValueOrDefault(title);
			// remove the book from library storage by key (title)
			Storage.Remove(title);
			Count--;
			Console.WriteLine($"Borrowing the book {title}..");
			return bookToBorrow;
		}

		public void Return(Book book)
		{
			// Add the book back to the library (from the satchel)
			Storage.Add(book.Title, book);
			Count++;
		}


		// DO NOT TOUCH THIS
		public IEnumerator<Book> GetEnumerator()
		{
			// Actual method is written here.
			foreach( Book book in Storage.Values)
			{
				yield return book;
			}
		}

		// BOILERPLATE - so that it can reference internally
		IEnumerator IEnumerable.GetEnumerator()
		{
			// IEnumerator is referenced here.
			return GetEnumerator();
		}

	}
}
