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
		///     Returns the number of days in the month of the provided date.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The number of days.</returns>
		public static int GetDaysOfMonthCount(this DateTime date)
		{
			DateTime nextMonth = date.AddMonths(1);
			return new DateTime(nextMonth.Year, nextMonth.Month, 1).AddDays(-1).Day;
		}
	}
}
