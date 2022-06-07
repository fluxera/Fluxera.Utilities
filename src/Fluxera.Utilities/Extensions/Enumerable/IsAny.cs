// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Linq;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="IEnumerable{T}" /> type.
	/// </summary>
	public static partial class EnumerableExtensions
	{
		/// <summary>
		///     Checks if the enumerable is not null or empty.
		/// </summary>
		/// <typeparam name="T">The generic type of the enumerable.</typeparam>
		/// <param name="enumerable">An IEnumerable<typeparamref name="T" /></param>
		/// <returns>True if enumerable have at least one value otherwise false.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsAny<T>(this IEnumerable<T> enumerable)
		{
			return enumerable is not null && enumerable.Any();
		}

		/// <summary>
		///     Checks if then enumerable is null or empty.
		/// </summary>
		/// <typeparam name="T">The generic type of the enumerable.</typeparam>
		/// <param name="enumerable">An IEnumerable<typeparamref name="T" /></param>
		/// <returns>True if enumerable have at least one value otherwise false.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNotAny<T>(this IEnumerable<T> enumerable)
		{
			return !enumerable.IsAny();
		}
	}
}
