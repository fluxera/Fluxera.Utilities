// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets a DateTime representing midnight on the current date.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <returns>The modified DateTime object.</returns>
		public static DateTime Midnight(this DateTime current)
		{
			return current.SetTime(0);
		}
	}
}
