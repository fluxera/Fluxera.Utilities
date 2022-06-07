// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="IEnumerable" /> type.
	/// </summary>
	public static partial class EnumerableExtensions
	{
		/// <summary>
		///     Checks if the enumerable is null or empty.
		/// </summary>
		/// <param name="enumerable">The enumerable to check.</param>
		/// <returns>True, if the enumerable is null or empty.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNullOrEmpty(this IEnumerable enumerable)
		{
			return enumerable is null || !enumerable.GetEnumerator().MoveNext();
		}

		/// <summary>
		///     Checks if the enumerable is not null or empty.
		/// </summary>
		/// <param name="enumerable">The enumerable to check.</param>
		/// <returns>True, if the enumerable is not null or empty.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNullOrEmpty(this IEnumerable enumerable)
		{
			return !enumerable.IsNullOrEmpty();
		}
	}
}
