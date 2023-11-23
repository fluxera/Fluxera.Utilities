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
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd<T>(this T value) where T : notnull, INumber<T>
		{
			return !value.IsEven();
		}
#endif

#if NET6_0
		/// <summary>
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd(this byte value)
		{
			return !value.IsEven();
		}

		/// <summary>
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd(this short value)
		{
			return !value.IsEven();
		}

		/// <summary>
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd(this int value)
		{
			return !value.IsEven();
		}

		/// <summary>
		///     Determines whether the value is odd.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is odd.</returns>
		public static bool IsOdd(this long value)
		{
			return !value.IsEven();
		}
#endif
	}
}
