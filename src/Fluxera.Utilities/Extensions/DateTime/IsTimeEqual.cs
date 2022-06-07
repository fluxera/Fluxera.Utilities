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
		///     Determines if the time part of two <see cref="DateTime" /> values are equal.
		/// </summary>
		/// <param name="time">The time.</param>
		/// <param name="timeToCompare">The time to compare.</param>
		/// <returns>Trie, if both time values are equal. </returns>
		public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
		{
			return time.TimeOfDay == timeToCompare.TimeOfDay;
		}
	}
}
