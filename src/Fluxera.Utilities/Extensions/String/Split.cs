// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class StringExtensions
	{
		/// <summary>
		///     Uses string.Split method to split given string by given separator.
		/// </summary>
		public static string[] Split(this string str, string separator)
		{
			return str.Split(new string[] { separator }, StringSplitOptions.None);
		}

		/// <summary>
		///     Uses string.Split method to split given string by given separator.
		/// </summary>
		public static string[] Split(this string str, string separator, StringSplitOptions options)
		{
			return str.Split(new string[] { separator }, options);
		}
	}
}
