// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Numerics;

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
		public static bool IsBetween<T>(this T value, T a, T b) where T : notnull, INumber<T>
		{
			return a < b
				? value >= a && value <= b
				: value >= b && value <= a;
		}
	}
}
