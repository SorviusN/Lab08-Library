using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab08_Library.Interfaces;

namespace Lab08_Library.Classes
{
	public class Satchel : IBag<Book>
	{

		// Intitializing our list of books which are borrowed from the library and returned back to the library.
		public List<Book> books { get; set; } = new List<Book>();

		public string ShowBooks()
		{
			string display = "";
			foreach(Book book in books)
			{
				display += $"{book.Title} ";
			}
			return display;
		}
		public void Pack(Book item)
		{	
			// Uses List.Add functionality to add the passed in book to the satchel.
			books.Add(item);
		}

		public Book Unpack(int index)
		{
			// Search for the correct book from given index, return the book (so it can be put back in the library)
			Book bookToRemove = books.ElementAt(index);
			books.RemoveAt(index);
			return bookToRemove;
		}

		// BOILERPLATE 
		public IEnumerator<Book> GetEnumerator()
		{
			foreach (Book book in books)
			{
				yield return book;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
