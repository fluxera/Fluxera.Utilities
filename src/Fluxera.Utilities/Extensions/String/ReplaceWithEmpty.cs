// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	public static partial class StringExtensions
	{
		/// <summary>
		///     Replaces all occurrences of a string in the input string with <see cref="string.Empty"/>.
		/// </summary>
		/// <param name="str">The string to modify.</param>
		/// <param name="subStringToRemove">The string to remove/replace.</param>
		/// <returns></returns>
		public static string ReplaceWithEmpty(this string str, string subStringToRemove)
		{
			return str.Replace(subStringToRemove, string.Empty);
		}
	}
}
