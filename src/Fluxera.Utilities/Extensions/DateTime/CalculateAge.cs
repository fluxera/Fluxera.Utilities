// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Calculates the age based on today.
		/// </summary>
		/// <param name="dateOfBirth">The date of birth.</param>
		/// <returns>The calculated age.</returns>
		public static int CalculateAge(this DateTime dateOfBirth)
		{
			return dateOfBirth.CalculateAge(DateTime.Today);
		}

		/// <summary>
		///     Calculates the age based on a passed reference date.
		/// </summary>
		/// <param name="dateOfBirth">The date of birth.</param>
		/// <param name="referenceDate">The reference date to calculate on.</param>
		/// <returns>The calculated age.</returns>
		public static int CalculateAge(this DateTime dateOfBirth, DateTime referenceDate)
		{
			int years = referenceDate.Year - dateOfBirth.Year;
			if (referenceDate.Month < dateOfBirth.Month ||
				referenceDate.Month == dateOfBirth.Month &&
				referenceDate.Day < dateOfBirth.Day)
			{
				years--;
			}

			return years;
		}
	}
}
