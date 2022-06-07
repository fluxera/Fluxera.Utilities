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
		///     Get the number of days within that date year.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>the number of days within that year.</returns>
		public static int GetDayCountOfYear(this DateTime date)
		{
			return date.IsLeapYear() ? 366 : 365;
		}
	}
}
