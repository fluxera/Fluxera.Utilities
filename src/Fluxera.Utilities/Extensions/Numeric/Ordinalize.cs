// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class NumericExtensions
	{
		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this byte number)
		{
			Guard.Against.Negative(number, nameof(number));

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this short number)
		{
			Guard.Against.Negative(number, nameof(number));

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this int number)
		{
			Guard.Against.Negative(number, nameof(number));

			return Inflector.Ordinalize(number);
		}

		/// <summary>
		///     Ordinalize the given number, f.e. 6 to '6th'.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns>The ordinal number as string.</returns>
		public static string Ordinalize(this long number)
		{
			Guard.Against.Negative(number, nameof(number));

			return Inflector.Ordinalize(number);
		}
	}
}
