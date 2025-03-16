using System.Collections.Generic;

namespace TripleA.Utils
{
	public static class ListExtensions
	{
		/// <summary>
		///     Refreshes the list with the given items
		/// </summary>
		/// <param name="items">The items to add</param>
		public static void RefreshWith<T>(this List<T> list, IEnumerable<T> items)
		{
			list.Clear();
			list.AddRange(items);
		}
	}
}