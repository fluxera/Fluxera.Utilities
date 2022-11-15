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
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd<T>(this T value) where T : notnull, INumber<T>
		{
			return !value.IsEven();
		}
	}
}
