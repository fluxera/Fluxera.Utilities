// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Replaces all dashes with underscores.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The string containing underscores.</returns>
		public static string Underscore(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Underscore(str);
		}
	}
}
