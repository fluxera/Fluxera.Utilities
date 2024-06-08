namespace Fluxera.Linq.Expressions
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	internal static class UtilExtensions
	{
		public static string ToConcatenatedString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool needSeparator = false;

			foreach(T item in source)
			{
				if(needSeparator)
				{
					stringBuilder.Append(separator);
				}

				stringBuilder.Append(selector(item));
				needSeparator = true;
			}

			return stringBuilder.ToString();
		}

		public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> enumerable)
		{
			enumerable ??= [];

			return new LinkedList<T>(enumerable);
		}
	}
}
