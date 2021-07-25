using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab08_Library.Classes;


namespace Lab08_Library.Interfaces
{
	public interface ILibrary : IReadOnlyCollection<Book>
	{
        /// <summary>
        /// Add a Book to the library. 
        /// </summary>
        public string Add(string title, string firstName, string lastName, int numberOfPages);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found. Make sure to create a test case for null.</returns>
        Book Borrow(string title);

        /// <summary>
        /// Return a Book to the library.
        /// </summary>
        void Return(Book book);

    }
}
