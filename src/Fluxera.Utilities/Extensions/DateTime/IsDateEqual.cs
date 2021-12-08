// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Determines if the date part of two <see cref="DateTime"/> values are equal.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="dateToCompare">The date to compare with.</param>
		/// <returns><code>true</code>, if both date values are equal. </returns>
		public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
		{
			return date.Date == dateToCompare.Date;
		}
	}
}
