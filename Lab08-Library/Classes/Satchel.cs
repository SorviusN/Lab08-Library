using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab08_Library.Interfaces;

namespace Lab08_Library.Classes
{
	class Satchel : IBag<Book>
	{

		// Intitializing our list of books which are borrowed from the library and returned back to the library.
		private List<Book> books { get; set; }

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

		public IEnumerator<Book> GetEnumerator()
		{
			return books.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
