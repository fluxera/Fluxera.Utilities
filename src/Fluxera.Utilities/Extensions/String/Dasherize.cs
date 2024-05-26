// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Converts all underscores to dashes.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The dasherized string.</returns>
		public static string Dasherize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Dasherize(str);
		}
	}
}
