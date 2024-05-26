// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="char" /> type.
	/// </summary>
	[PublicAPI]
	public static class CharExtensions
	{
#if NET7_0_OR_GREATER
		/// <summary>
		///     Repeats the given <see cref="char" /> the specified number of times.
		/// </summary>
		/// <param name="input">The char to repeat.</param>
		/// <param name="count">The number of times to repeat the string.</param>
		/// <returns>The repeated char string.</returns>
		[Pure]
		public static string Repeat(this char input, int count)
		{
			Guard.ThrowIfNegative(count);

			string str = string.Empty;
			count.Times(() => str = string.Concat(str, input));
			return str;
		}
#endif

#if NET6_0
		/// <summary>
		///     Repeats the given <see cref="char" /> the specified number of times.
		/// </summary>
		/// <param name="input">The char to repeat.</param>
		/// <param name="count">The number of times to repeat the string.</param>
		/// <returns>The repeated char string.</returns>
		[Pure]
		public static string Repeat(this char input, int count)
		{
			Guard.ThrowIfNegative(count);

			string str = string.Empty;
			count.Times(() => str = string.Concat(str, input));
			return str;
		}
#endif
	}
}
