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
		///     Determines if the date is <see cref="DateTime.Today" />.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>True, if the specified date is today.</returns>
		public static bool IsToday(this DateTime date)
		{
			return date.Date == DateTime.Today;
		}
	}
}
