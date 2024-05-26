// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Humanizes the given string input.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns></returns>
		public static string Humanize(this string str)
		{
			Guard.ThrowIfNullOrWhiteSpace(str);

			return Inflector.Humanize(str);
		}
	}
}
