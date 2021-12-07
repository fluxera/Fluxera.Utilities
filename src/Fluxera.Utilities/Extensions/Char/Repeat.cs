// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class CharExtensions
	{
		/// <summary>
		///     Repeat the given <see cref="char" /> the specified number of times.
		/// </summary>
		/// <param name="input">The char to repeat.</param>
		/// <param name="count">The number of times to repeat the string.</param>
		/// <returns>The repeated char string.</returns>
		[Pure]
		public static string Repeat(this char input, int count)
		{
			Guard.Against.Negative(count, nameof(count));

			string str = string.Empty;
			count.Times(() => str = string.Concat(str, input));
			return str;
		}
	}
}
