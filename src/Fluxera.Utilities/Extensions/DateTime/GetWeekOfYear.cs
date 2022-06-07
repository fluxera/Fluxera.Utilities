// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;

	/// <summary>
	///     Extension methods for the <see cref="DateTime" /> type.
	/// </summary>
	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets the week number for a provided date time value based on the current culture settings.
		/// </summary>
		/// <param name="dateTime">The date time.</param>
		/// <returns>The week number.</returns>
		public static int GetWeekOfYear(this DateTime dateTime)
		{
			CultureInfo cultureInfo = CultureInfo.CurrentCulture;
			Calendar calendar = cultureInfo.Calendar;
			DateTimeFormatInfo dateTimeFormat = cultureInfo.DateTimeFormat;

			return calendar.GetWeekOfYear(dateTime, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
		}
	}
}
