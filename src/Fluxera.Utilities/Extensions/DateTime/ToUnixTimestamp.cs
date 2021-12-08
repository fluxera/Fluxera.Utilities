// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Converts the given <see cref="DateTime" /> to a UNIX timestamp (seconds since 01.01.1970).
		/// </summary>
		/// <param name="dateTime">The date time to convert.</param>
		/// <returns>The UNIX timestamp.</returns>
		public static int ToUnixTimestamp(this DateTime dateTime)
		{
			return (int)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}
	}
}
