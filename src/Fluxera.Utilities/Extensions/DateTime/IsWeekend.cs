// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Determines if the specified <see cref="DayOfWeek" /> is a weekend (Saturday or Sunday).
		/// </summary>
		/// <param name="dayOfWeek">The day.</param>
		/// <returns><code>true</code>, if the specified date is a weekend.</returns>
		public static bool IsWeekend(this DayOfWeek dayOfWeek)
		{
			return dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday;
		}

		/// <summary>
		///     Determines if the specified <see cref="DateTime"/> is a weekend (Saturday or Sunday).
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns><code>true</code>, if the specified date is a weekend.</returns>
		public static bool IsWeekend(this DateTime date)
		{
			return date.DayOfWeek.IsWeekend();
		}
	}
}
