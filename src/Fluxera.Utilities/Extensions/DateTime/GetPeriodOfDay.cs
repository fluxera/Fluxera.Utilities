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
		///     Returns the period of the day <see cref="PeriodOfDay.Morning" />, <see cref="PeriodOfDay.Afternoon" />,
		///     <see cref="PeriodOfDay.Evening" />.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>The period "morning", "afternoon", or "evening".</returns>
		public static PeriodOfDay GetPeriodOfDay(this DateTime date)
		{
			const int eveningEnds = 2;
			const int morningEnds = 12;
			const int afternoonEnds = 18;

			int hour = date.Hour;

			PeriodOfDay result = hour switch
			{
				< eveningEnds => PeriodOfDay.Evening,
				< morningEnds => PeriodOfDay.Morning,
				< afternoonEnds => PeriodOfDay.Afternoon,
				_ => PeriodOfDay.Evening
			};

			return result;
		}
	}
}
