using System;
using Xunit;
using System.Collections.Generic;
using System.Collections;
using Lab08_Library.Classes;
using Lab08_Library.Interfaces;

namespace LibraryTests
{
	public class UnitTest1 
	{

		[Fact]
		public void CanAddBook()
		{

			Library lib = new Library();

			Assert.Equal("Test", lib.Add("Test", "First", "Last", 5));
		}

		[Fact]
		public void CanBorrowBook()
		{
			Library lib = new Library();

			lib.Add("Test", "First", "Last", 5);

			Book book = lib.Borrow("Test");

			Assert.DoesNotContain(book, lib);
			Assert.True(lib.Count == 0);
		}

		[Fact]
		public void CannotBorrowNull()
		{
			Library lib = new Library();
			Assert.Null(lib.Borrow("Test"));
		}

		[Fact]
		public void CanReturnToLib()
		{
			Library lib = new Library();
			Satchel satch = new Satchel();

			lib.Add("Test", "First", "Last", 5);
			satch.Pack(lib.Borrow("Test"));
			//returning the satchel's book at index 0.
			lib.Return(satch.Unpack(0));

			Assert.Equal("Test", lib.DisplayBooks());
			Assert.True(lib.Count == 1);
		}

		[Fact]
		public void CanPackAndUnPack()
		{
			Library lib = new Library();
			Satchel satch = new Satchel();
			lib.Add("Test", "First", "Last", 5);
			satch.Pack(lib.Borrow("Test"));

			// We assert that when we show the books in the satchel, test will show up and when we unpack the "test" book, nothing will show.
			Assert.Equal("Test ", satch.ShowBooks());
			satch.Unpack(0);
			Assert.True(satch.ShowBooks() == "");
		}
	}
}
