﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;

	public static partial class StringExtensions
	{
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
	}
}
