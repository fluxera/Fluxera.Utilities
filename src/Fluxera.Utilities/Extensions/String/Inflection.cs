// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Returns the plural form of the specified word.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is the plural form of the input parameter.</returns>
		public static string Pluralize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Pluralize(str);
		}

		/// <summary>
		///     Returns the singular form of the specified word.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is the singular form of the input parameter.</returns>
		public static string Singularize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Singularize(str);
		}

		/// <summary>
		///     Return the string is form that can be used as title.
		///     Every word is capitalized and the string stripped of dashes
		///     and underscores.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>A string that is in title form.</returns>
		public static string Titleize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Titleize(str);
		}

		/// <summary>
		///     Humanizes the given string input.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns></returns>
		public static string Humanize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Humanize(str);
		}

		/// <summary>
		///     Pascalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The pascal cased string.</returns>
		public static string Pascalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Pascalize(str);
		}

		/// <summary>
		///     Camelizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The camel cased string.</returns>
		public static string Camelize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Camelize(str);
		}

		/// <summary>
		///     Replaces all dashes with underscores.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The string containing underscores.</returns>
		public static string Underscore(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Underscore(str);
		}

		/// <summary>
		///     Capitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The capitalized string.</returns>
		public static string Capitalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Capitalize(str);
		}

		/// <summary>
		///     Uncapitalizes the given string.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The uncapitalized string.</returns>
		public static string Uncapitalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Uncapitalize(str);
		}

		/// <summary>
		///     Ordinalizes the given number-as-string, f.e. '6' to '6th'.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The ordinalized string.</returns>
		public static string Ordinalize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));
			Guard.Against.False(str.IsNumeric(), nameof(str));

			return Inflector.Ordinalize(str);
		}

		/// <summary>
		///     Converts all underscores to dashes.
		/// </summary>
		/// <param name="str">The string.</param>
		/// <returns>The dasherized string.</returns>
		public static string Dasherize(this string str)
		{
			Guard.Against.NullOrWhiteSpace(str, nameof(str));

			return Inflector.Dasherize(str);
		}
	}
}
