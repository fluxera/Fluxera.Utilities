// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Text;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Repeats the string value as provided by the repeat count.
		/// </summary>
		/// <param name="str">The string to repeat.</param>
		/// <param name="repeatCount">The repeat count.</param>
		/// <returns>The repeated string</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static string Repeat(this string str, int repeatCount)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			StringBuilder stringBuilder = new StringBuilder();
			repeatCount.Times(() => stringBuilder.Append(str));
			return stringBuilder.ToString();
		}
	}
}
