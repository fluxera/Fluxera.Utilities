﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	/// <summary>
	///     Extension methods for the <see cref="DateTime" /> type.
	/// </summary>
	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Adds the specified amount of weeks (=7 days gregorian calendar) to the given date value.
		/// </summary>
		/// <param name="date">The origin date.</param>
		/// <param name="value">The amount of weeks to be added.</param>
		/// <returns>The new date value.</returns>
		public static DateTime AddWeeks(this DateTime date, int value)
		{
			return date.AddDays(value * 7);
		}
	}
}
