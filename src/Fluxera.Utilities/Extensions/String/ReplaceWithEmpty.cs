// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Globalization;
	using System.Text;
	using Guards;

	public static partial class StringExtensions
	{
		/// <summary>
		///     Replaces all instances of a string in an input string with String.Empty.
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
