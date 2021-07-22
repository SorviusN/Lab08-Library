using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Library.Interfaces
{
	// Interface that inherits the IEnumerable interface with given type (whatever type is used in your class)
	interface IBag<T> : IEnumerable<T>
	{
		/// <summary>
		/// Add an item to the bag. <c>null</c> items are ignored.
		/// </summary>
		void Pack(T item);

		/// <summary>
		/// Remove the item from the bag at the given index (make a list in your bag class)
		/// </summary>
		/// <returns>The item that was removed back into library.</returns>
		T Unpack(int index);
	}
}
