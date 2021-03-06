// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for numeric types.
	/// </summary>
	public static partial class NumericExtensions
	{
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
	}
}
