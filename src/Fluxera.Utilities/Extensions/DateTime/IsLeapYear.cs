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
		///     Returns if or not a <see cref="DateTime" /> is during a leap year.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsLeapYear(this DateTime value)
		{
			return DateTime.DaysInMonth(value.Year, 2) == 29;
		}
	}
}
