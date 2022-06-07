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
		///     Get the number of days between two dates.
		/// </summary>
		/// <param name="fromDate">The origin year.</param>
		/// <param name="toDate">To year.</param>
		/// <returns>The number of days between the two years.</returns>
		public static int GetDays(this DateTime fromDate, DateTime toDate)
		{
			return Convert.ToInt32(toDate.Subtract(fromDate).TotalDays);
		}
	}
}
