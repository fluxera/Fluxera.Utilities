// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Indicates whether the date is today.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>True, if the specified date is today.</returns>
		public static bool IsToday(this DateTime date)
		{
			return date.Date == DateTime.Today;
		}
	}
}
