﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Determines whether the time only part of two DateTime values are equal.
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
