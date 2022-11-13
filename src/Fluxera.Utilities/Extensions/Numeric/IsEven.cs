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
		///     Determines whether the value is even.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>True, if the value is even.</returns>
		public static bool IsEven<T>(this T value) where T : INumber<T>
		{
			return T.IsEvenInteger(value);
		}
	}
}
