// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using JetBrains.Annotations;

	public static partial class ValueTypeExtensions
	{
		/// <summary>
		///     Checks if the collection is null or empty.
		/// </summary>
		/// <param name="collection">The collection to check.</param>
		/// <returns>True, if the enumerable is null or empty.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return collection.IsNull() || collection.Count <= 0;
		}

		/// <summary>
		///     Checks if the collection is not null or empty.
		/// </summary>
		/// <param name="collection">The collection to check.</param>
		/// <returns>True, if the enumerable is not null or empty.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNullOrEmpty<T>(this ICollection<T> collection)
		{
			return !collection.IsNullOrEmpty();
		}
	}
}
