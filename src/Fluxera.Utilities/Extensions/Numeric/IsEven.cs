// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class NumericExtensions
	{
		/// <summary>
		///     Determines whether the value is even.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is even.</returns>
		public static bool IsEven(this byte value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///     Determines whether the value is even.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is even.</returns>
		public static bool IsEven(this short value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///     Determines whether the value is even.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is even.</returns>
		public static bool IsEven(this int value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///     Determines whether the value is even.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is even.</returns>
		public static bool IsEven(this long value)
		{
			return (value % 2) == 0;
		}
	}
}
