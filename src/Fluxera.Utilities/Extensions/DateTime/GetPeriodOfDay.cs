// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Returns a period "Morning", "Afternoon", or "Evening".
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The period "morning", "afternoon", or "evening".</returns>
		public static PeriodOfDay GetPeriodOfDay(this DateTime date)
		{
			PeriodOfDay result;

			const int eveningEnds = 2;
			const int morningEnds = 12;
			const int afternoonEnds = 18;

			int hour = date.Hour;

			if (hour < eveningEnds)
			{
				result = PeriodOfDay.Evening;
			}
			else if (hour < morningEnds)
			{
				result = PeriodOfDay.Morning;
			}
			else if (hour < afternoonEnds)
			{
				result = PeriodOfDay.Afternoon;
			}
			else
			{
				result = PeriodOfDay.Evening;
			}

			return result;
		}
	}
}
