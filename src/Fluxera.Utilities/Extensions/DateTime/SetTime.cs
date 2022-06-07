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
		///     Sets the time of the current date with hour precision. <br />
		///     All other parts (minutes, seconds, milliseconds) are set to zero.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <param name="hour">The hour.</param>
		/// <returns>The modified <see cref="DateTime" /> value.</returns>
		public static DateTime SetTime(this DateTime current, int hour)
		{
			return current.SetTime(hour, 0, 0, 0);
		}

		/// <summary>
		///     Sets the time of the current date with minute precision. <br />
		///     All other parts (minutes, seconds, milliseconds) are set to zero.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <param name="hour">The hour.</param>
		/// <param name="minute">The minute.</param>
		/// <returns>The modified <see cref="DateTime" /> value.</returns>
		public static DateTime SetTime(this DateTime current, int hour, int minute)
		{
			return current.SetTime(hour, minute, 0, 0);
		}

		/// <summary>
		///     Sets the time of the current date with second precision. <br />
		///     All other parts (minutes, seconds, milliseconds) are set to zero.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <param name="hour">The hour.</param>
		/// <param name="minute">The minute.</param>
		/// <param name="second">The second.</param>
		/// <returns>The modified <see cref="DateTime" /> value.</returns>
		public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
		{
			return current.SetTime(hour, minute, second, 0);
		}

		/// <summary>
		///     Sets the time of the current date with millisecond precision. <br />
		///     All other parts (minutes, seconds, milliseconds) are set to zero.
		/// </summary>
		/// <param name="current">The current date.</param>
		/// <param name="hour">The hour.</param>
		/// <param name="minute">The minute.</param>
		/// <param name="second">The second.</param>
		/// <param name="millisecond">The millisecond.</param>
		/// <returns>The modified <see cref="DateTime" /> value.</returns>
		public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
		{
			return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
		}
	}
}
