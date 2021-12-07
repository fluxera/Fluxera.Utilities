// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public static partial class EnumerableExtensions
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
	}
}
