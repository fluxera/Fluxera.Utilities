// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="DayOfWeek" /> type.
	/// </summary>
	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Determines if the specified <see cref="DayOfWeek" /> is a weekday.
		/// </summary>
		/// <param name="dayOfWeek">The day.</param>
		/// <returns><code>true</code>, if the specified date is a weekday.</returns>
		public static bool IsWeekday(this DayOfWeek dayOfWeek)
		{
			return !dayOfWeek.IsWeekend();
		}

		/// <summary>
		///     Determines if the specified <see cref="DateTime" /> is a weekday.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns><code>true</code>, if the specified date is a weekday.</returns>
		public static bool IsWeekday(this DateTime date)
		{
			return date.DayOfWeek.IsWeekday();
		}
	}
}
