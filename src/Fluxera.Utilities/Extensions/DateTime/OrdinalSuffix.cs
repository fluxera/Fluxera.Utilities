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
		///     Converts the day to an ordinal string, f.e. 3 to '3rd'.
		/// </summary>
		/// <param name="dateTime">The date time to convert.</param>
		/// <returns>The ordinal string of the day.</returns>
		public static string OrdinalSuffix(this DateTime dateTime)
		{
			int day = dateTime.Day;

			if(day % 100 >= 11 && day % 100 <= 13)
			{
				return string.Concat(day, "th");
			}

			return (day % 10) switch
			{
				1 => string.Concat(day, "st"),
				2 => string.Concat(day, "nd"),
				3 => string.Concat(day, "rd"),
				_ => string.Concat(day, "th")
			};
		}
	}
}
