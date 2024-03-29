﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="string" /> type.
	/// </summary>
	public static partial class StringExtensions
	{
		/// <summary>
		///     Determines if the string is null or empty or consists of whitespace-only characters.
		/// </summary>
		/// <param name="value">The string to check.</param>
		/// <returns>True, if the string is null or empty or consists only of whitespace-only.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}

		/// <summary>
		///     Determines if the specified string is not null or empty or consists of whitespace-only characters.
		/// </summary>
		/// <param name="value">The string to check.</param>
		/// <returns>True, if the string is not null or empty or consists only of white-spaces.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNullOrWhiteSpace(this string value)
		{
			return !value.IsNullOrWhiteSpace();
		}
	}
}
