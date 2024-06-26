﻿// ReSharper disable once CheckNamespace

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
		///     Gets the last day of the week using the current culture.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The last day of the week.</returns>
		public static DateTime GetLastDayOfWeek(this DateTime date)
		{
			return date.GetLastDayOfWeek(CultureInfo.CurrentCulture);
		}

		/// <summary>
		///     Gets the last day of the week using the specified culture.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="cultureInfo">The culture to determine the first weekday of a week.</param>
		/// <returns>The last day of the week</returns>
		public static DateTime GetLastDayOfWeek(this DateTime date, CultureInfo cultureInfo)
		{
			Guard.ThrowIfNull(cultureInfo);

			return date.GetFirstDayOfWeek(cultureInfo).AddDays(6);
		}
	}
}
