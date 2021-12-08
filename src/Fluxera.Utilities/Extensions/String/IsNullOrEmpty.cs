// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Determines if the string is null or empty.
		/// </summary>
		/// <param name="value">The string to check.</param>
		/// <returns>True, if the string is null or empty.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		/// <summary>
		///     Determines if the specified string is not null or empty.
		/// </summary>
		/// <param name="value">The string to check.</param>
		/// <returns>True, if the string is not null or empty.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNullOrEmpty(this string value)
		{
			return !value.IsNullOrEmpty();
		}
	}
}
