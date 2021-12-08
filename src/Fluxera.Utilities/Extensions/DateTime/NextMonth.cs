// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets the next month.
		/// </summary>
		/// <returns>The month.</returns>
		/// <param name="date">The date.</param>
		public static DateTime NextMonth(this DateTime date)
		{
			DateTime nextMonth = date.AddMonths(1);

			if(date.Day != DateTime.DaysInMonth(date.Year, date.Month)) // Is last day in month.
			{
				//any other day then last day
				return nextMonth;
			}

			// Last day in the month will produce the last day in the next month.
			return date.AddDays(DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month));
		}
	}
}
