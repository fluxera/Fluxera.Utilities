// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;
	using Guards;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets the next occurrence of the specified weekday within the current week using the
		///     current culture.
		/// </summary>
		/// <param name="date">The base date.</param>
		/// <param name="weekday">The desired weekday.</param>
		/// <returns>The calculated date.</returns>
		/// <example>
		///     <code>
		/// 		DateTime thisWeeksMonday = DateTime.Now.GetWeeksWeekday(DayOfWeek.Monday);
		/// 	</code>
		/// </example>
		public static DateTime GetWeeksWeekday(this DateTime date, DayOfWeek weekday)
		{
			return date.GetWeeksWeekday(weekday, CultureInfo.CurrentCulture);
		}

		/// <summary>
		///     Gets the next occurrence of the specified weekday within the current week
		///     using the specified culture.
		/// </summary>
		/// <param name="date">The base date.</param>
		/// <param name="weekday">The desired weekday.</param>
		/// <param name="cultureInfo">The culture to determine the first weekday of a week.</param>
		/// <returns>The calculated date.</returns>
		/// <example>
		///     <code>
		/// 		DateTime thisWeeksMonday = DateTime.Now.GetWeeksWeekday(DayOfWeek.Monday);
		/// 	</code>
		/// </example>
		public static DateTime GetWeeksWeekday(this DateTime date, DayOfWeek weekday, CultureInfo cultureInfo)
		{
			Guard.Against.Null(cultureInfo, nameof(cultureInfo));

			DateTime firstDayOfWeek = date.GetFirstDayOfWeek(cultureInfo);
			return firstDayOfWeek.GetNextWeekday(weekday);
		}
	}
}
