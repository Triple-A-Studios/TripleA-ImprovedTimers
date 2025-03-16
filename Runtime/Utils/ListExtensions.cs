using System.Collections.Generic;

namespace TripleA.Utils
{
	internal static class ListExtensions
	{
		/// <summary>
		///     Refreshes the list with the given items
		/// </summary>
		/// <param name="items">The items to add</param>
		internal static void RefreshWith<T>(this List<T> list, IEnumerable<T> items)
		{
			list.Clear();
			list.AddRange(items);
		}
	}
}