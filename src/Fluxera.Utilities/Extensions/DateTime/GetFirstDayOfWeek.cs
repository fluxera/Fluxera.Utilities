// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;
	using Guards;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets the first day of the week using the current culture.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The first day of the week</returns>
		public static DateTime GetFirstDayOfWeek(this DateTime date)
		{
			return date.GetFirstDayOfWeek(CultureInfo.CurrentCulture);
		}

		/// <summary>
		///     Gets the first day of the week using the specified culture.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="cultureInfo">The culture to determine the first weekday of a week.</param>
		/// <returns>The first day of the week.</returns>
		public static DateTime GetFirstDayOfWeek(this DateTime date, CultureInfo cultureInfo)
		{
			Guard.Against.Null(cultureInfo, nameof(cultureInfo));

			DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
			while (date.DayOfWeek != firstDayOfWeek)
			{
				date = date.AddDays(-1);
			}

			return date;
		}
	}
}
