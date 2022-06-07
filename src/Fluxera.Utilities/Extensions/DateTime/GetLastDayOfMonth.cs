// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="DateTime" /> type.
	/// </summary>
	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Returns the last day of the month of the provided date.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The last day of the month.</returns>
		public static DateTime GetLastDayOfMonth(this DateTime date)
		{
			return new DateTime(date.Year, date.Month, date.GetDaysOfMonthCount());
		}

		/// <summary>
		///     Returns the last day of the month of the provided date.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="dayOfWeek">The desired day of week.</param>
		/// <returns>The date time.</returns>
		public static DateTime GetLastDayOfMonth(this DateTime date, DayOfWeek dayOfWeek)
		{
			DateTime dt = date.GetLastDayOfMonth();
			while(dt.DayOfWeek != dayOfWeek)
			{
				dt = dt.AddDays(-1);
			}

			return dt;
		}
	}
}
