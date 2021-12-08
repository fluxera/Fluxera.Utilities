// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Adds the months to end of month.
		/// </summary>
		/// <returns>The months to end of month.</returns>
		/// <param name="date">Date.</param>
		/// <param name="numberOfMonths">Number of months.</param>
		public static DateTime AddMonthsToEndOfMonth(this DateTime date, int numberOfMonths)
		{
			DateTime nextMonth = date.AddMonths(numberOfMonths);

			if (date.Day != DateTime.DaysInMonth(date.Year, date.Month)) // Is last day in month.
			{
				// Any other day then last day.
				return nextMonth;
			}

			// If the date was end of month, add remaining days.
			int addDays = DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month) - nextMonth.Day;
			return nextMonth.AddDays(addDays);
		}
	}
}
