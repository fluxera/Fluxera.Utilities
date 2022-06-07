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
		///     Gets the next occurrence of the specified weekday.
		/// </summary>
		/// <param name="date">The base date.</param>
		/// <param name="weekday">The desired weekday.</param>
		/// <returns>The calculated date.</returns>
		public static DateTime GetNextWeekday(this DateTime date, DayOfWeek weekday)
		{
			while(date.DayOfWeek != weekday)
			{
				date = date.AddDays(1);
			}

			return date;
		}
	}
}
