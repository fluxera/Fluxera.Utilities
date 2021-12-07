// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class NumericExtensions
	{
		/// <summary>
		///     Determines if is between the specified value a b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if is between the specified value a b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this byte value, byte a, byte b)
		{
			return a < b
				? (value >= a) && (value <= b)
				: (value >= b) && (value <= a);
		}

		/// <summary>
		///     Determines if is between the specified value a b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if is between the specified value a b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this short value, short a, short b)
		{
			return a < b
				? (value >= a) && (value <= b)
				: (value >= b) && (value <= a);
		}

		/// <summary>
		///     Determines if is between the specified value a b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if is between the specified value a b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this int value, int a, int b)
		{
			return a < b
				? (value >= a) && (value <= b)
				: (value >= b) && (value <= a);
		}

		/// <summary>
		///     Determines if is between the specified value a b (inclusive).
		/// </summary>
		/// <returns><c>true</c> if is between the specified value a b; otherwise, <c>false</c>.</returns>
		/// <param name="value">Value.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static bool IsBetween(this long value, long a, long b)
		{
			return a < b
				? (value >= a) && (value <= b)
				: (value >= b) && (value <= a);
		}
	}
}
