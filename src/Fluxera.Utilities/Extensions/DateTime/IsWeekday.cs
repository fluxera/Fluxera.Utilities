// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Indicates whether the specified <see cref="DayOfWeek" /> is a weekday.
		/// </summary>
		/// <param name="dayOfWeek">The day.</param>
		/// <returns><code>true</code>, if the specified date is a weekend.</returns>
		public static bool IsWeekday(this DayOfWeek dayOfWeek)
		{
			return !dayOfWeek.IsWeekend();
		}

		/// <summary>
		///     Indicates whether the specified date is a weekend (Saturday or Sunday).
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns><code>true</code>, if the specified date is a weekend.</returns>
		public static bool IsWeekday(this DateTime date)
		{
			return date.DayOfWeek.IsWeekday();
		}
	}
}
