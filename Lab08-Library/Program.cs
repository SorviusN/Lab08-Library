using System;
using Lab08_Library.Classes;
using Lab08_Library.Interfaces;

namespace Lab08_Library
{
	class Program
	{

		static void Main(string[] args)
		{
			Library lib = new Library();
			Satchel satchel = new Satchel();

			CreateBook(lib);
		}

		static void borrowBook(Library lib, Satchel satchel)
		{
			lib.DisplayBooks();
			Console.WriteLine("Which book would you like to borrow? Please enter a valid title.");
			string title = Console.ReadLine();

			// Pack your satchel with the desired book that you picked by title.
			satchel.Pack(lib.Borrow(title));
		}

		static void CreateBook(Library lib)
		{
			// Prompt user for input when creating a new book for the library.
			Console.WriteLine("Book Title:");
			string title = Console.ReadLine();

			Console.WriteLine("First Name:");
			string firstName = Console.ReadLine();

			Console.WriteLine("Last Name:");
			string lastName = Console.ReadLine();

			Console.WriteLine("Number of Pages:");
			int numOfPages = Convert.ToInt32(Console.ReadLine());
			
			//Add book to the library with given parameters.
			lib.Add(title, firstName, lastName, numOfPages);

			Console.WriteLine($"Book {title} Succesfully added to library. Press any key to continue.");
			lib.DisplayBooks();
			Console.ReadLine();

		}
	}
}
