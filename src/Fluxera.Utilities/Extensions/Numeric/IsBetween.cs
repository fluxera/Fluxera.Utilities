// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Numerics;

	/// <summary>
	///     Extension methods for numeric types.
	/// </summary>
	public static partial class NumericExtensions
	{
#if NET7_0_OR_GREATER
		/// <summary>
		///     Determines if the given value is between the specified values a and b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if the given value is between the specified values a and b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween<T>(this T value, T a, T b) where T : notnull, INumber<T>
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}
#endif

#if NET6_0
		/// <summary>
		///     Determines if the given value is between the specified values a and b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if the given value is between the specified values a and b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this byte value, byte a, byte b)
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}

		/// <summary>
		///     Determines if the given value is between the specified values a and b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if the given value is between the specified values a and b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this short value, short a, short b)
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}

		/// <summary>
		///     Determines if the given value is between the specified values a and b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if the given value is between the specified values a and b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this int value, int a, int b)
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}

		/// <summary>
		///     Determines if the given value is between the specified values a and b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if the given value is between the specified values a and b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this long value, long a, long b)
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}
#endif
	}
}
