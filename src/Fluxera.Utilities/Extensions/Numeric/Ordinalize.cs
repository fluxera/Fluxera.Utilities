// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for numeric types.
	/// </summary>
	public static partial class NumericExtensions
	{
		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this byte number)
		{
			Guard.ThrowIfNegative(number);

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this short number)
		{
			Guard.ThrowIfNegative(number);

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this int number)
		{
			Guard.ThrowIfNegative(number);

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this long number)
		{
			Guard.ThrowIfNegative(number);

			return Inflector.Ordinalize(number);
		}
	}
}
