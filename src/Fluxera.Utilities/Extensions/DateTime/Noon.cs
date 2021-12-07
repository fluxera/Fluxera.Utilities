// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets a DateTime representing noon on the current date.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <returns>The modified DateTime object.</returns>
		public static DateTime Noon(this DateTime current)
		{
			return current.SetTime(12);
		}
	}
}
