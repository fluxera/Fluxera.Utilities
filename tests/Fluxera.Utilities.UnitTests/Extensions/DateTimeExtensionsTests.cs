namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class DateTimeExtensionsTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void GetLastDayOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfMonth();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Friday);
		}

		[Test]
		public void GetLastDayOfMonthWithDesiredDayOfWeek()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfMonth(DayOfWeek.Wednesday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Wednesday);
			result.Day.Should().Be(29);
		}

		[Test]
		public void ShouldAddMonthsToEndOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("31.05.2019 16:23:53");

			// Act
			DateTime result = dt.AddMonthsToEndOfMonth(4);

			// Assert
			result.Day.Should().Be(30);
			result.Month.Should().Be(9);
			result.Year.Should().Be(2019);
		}

		[Test]
		public void ShouldAddWeeks()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000");

			// Act
			DateTime result = dt.AddWeeks(2);

			// Assert
			result.Day.Should().Be(15);
		}

		[Test]
		public void ShouldBeLeapYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("18.05.2000");

			// Act
			bool isLeapYear = dt.IsLeapYear();

			// Assert
			isLeapYear.Should().BeTrue();
		}

		[Test]
		public void ShouldBeWeekend()
		{
			// Arrange
			DateTime dt = DateTime.Parse("18.05.2019");

			// Act
			bool isWeekend = dt.IsWeekend();

			// Assert
			isWeekend.Should().BeTrue();
		}

		[Test]
		public void ShouldCalculateAge()
		{
			// Arrange
			DateTime referenceDate = DateTime.Parse("05.01.2000");
			DateTime dt = DateTime.Parse("05.01.1980");

			// Act
			int age = dt.CalculateAge(referenceDate);

			// Assert
			age.Should().Be(20);
		}

		[Test]
		public void ShouldConfirmThatItIsToday()
		{
			// Arrange
			DateTime dt = DateTime.Now;

			// Act
			bool isToday = dt.IsToday();

			// Assert
			isToday.Should().BeTrue();
		}

		[Test]
		public void ShouldConvertToUnixTimestampOneDay()
		{
			// Arrange
			DateTime dt = DateTime.Parse("02.01.1970 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(1 * 24 * 60 * 60);
		}

		[Test]
		public void ShouldConvertToUnixTimestampOneYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.01.1971 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(365 * 24 * 60 * 60);
		}

		[Test]
		public void ShouldConvertToUnixTimestampZero()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.01.1970 00:00:00");

			// Act
			int result = dt.ToUnixTimestamp();

			// Assert
			result.Should().Be(0);
		}

		[Test]
		public void ShouldCreateOrdinalSuffixedString()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019 14:34:56");

			// Act
			string result = dt.OrdinalSuffix();

			// Assert
			result.Should().Be("6th");
		}

		[Test]
		public void ShouldDateBeEqual()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("06.05.2019 14:34:56");
			DateTime dt2 = DateTime.Parse("06.05.2019 16:34:56");

			// Act
			bool isDateEqual = dt1.IsDateEqual(dt2);

			// Assert
			isDateEqual.Should().BeTrue();
		}

		[Test]
		public void ShouldGetDayCountOfYearForLeapYearYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000");

			// Act
			int result = dt.GetDayCountOfYear();

			// Assert
			result.Should().Be(366);
		}

		[Test]
		public void ShouldGetDayCountOfYearForNormalYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2001");

			// Act
			int result = dt.GetDayCountOfYear();

			// Assert
			result.Should().Be(365);
		}

		[Test]
		public void ShouldGetDaysBetweenDates()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("01.05.2000");
			DateTime dt2 = DateTime.Parse("23.05.2000");

			// Act
			int result = dt1.GetDays(dt2);

			// Assert
			result.Should().Be(22);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForLeapYearFebruary()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.02.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(29);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForLongMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.08.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(31);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForNormalYearFebruary()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.02.2001");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(28);
		}

		[Test]
		public void ShouldGetDaysOfMonthCountForShortMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.04.2000");

			// Act
			int count = dt.GetDaysOfMonthCount();

			// Assert
			count.Should().Be(30);
		}

		[Test]
		public void ShouldGetFirstDayOfMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfMonth();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Wednesday);
		}

		[Test]
		public void ShouldGetFirstDayOfMonthWithDesiredDayOfWeek()
		{
			// Arrange
			DateTime dt = DateTime.Parse("23.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfMonth(DayOfWeek.Thursday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Thursday);
			result.Day.Should().Be(2);
		}

		[Test]
		public void ShouldGetFirstDayOfWeekCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfWeek();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Monday);
			result.Day.Should().Be(13);
		}

		[Test]
		public void ShouldGetFirstDayOfWeekSundayFirstDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetFirstDayOfWeek(CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Sunday);
			result.Day.Should().Be(12);
		}

		[Test]
		public void ShouldGetLastDayOfWeekCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfWeek();

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Sunday);
			result.Day.Should().Be(19);
		}

		[Test]
		public void ShouldGetLastDayOfWeekSaturdayLastDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("15.05.2019");

			// Act
			DateTime result = dt.GetLastDayOfWeek(CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Saturday);
			result.Day.Should().Be(18);
		}

		[Test]
		public void ShouldGetNextMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.NextMonth();

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(6);
			result.Year.Should().Be(2019);
		}

		[Test]
		public void ShouldGetNextMonthLargeToSmallMonth()
		{
			// Arrange
			DateTime dt = DateTime.Parse("31.05.2019 16:23:53");

			// Act
			DateTime result = dt.NextMonth();

			// Assert
			result.Day.Should().Be(30);
			result.Month.Should().Be(6);
			result.Year.Should().Be(2019);
		}

		[Test]
		public void ShouldGetNextWeekday()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019");

			// Act
			DateTime result = dt.GetNextWeekday(DayOfWeek.Friday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Friday);
			result.Day.Should().Be(10);
		}

		[Test]
		public void ShouldGetPeriodOfDayAfternoon()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 14:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Afternoon);
		}

		[Test]
		public void ShouldGetPeriodOfDayEvening()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 23:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Evening);
		}

		[Test]
		public void ShouldGetPeriodOfDayMorning()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2000 10:00:00");

			// Act
			PeriodOfDay result = dt.GetPeriodOfDay();

			// Assert
			result.Should().Be(PeriodOfDay.Morning);
		}

		[Test]
		public void ShouldGetPreviousWeekday()
		{
			// Arrange
			DateTime dt = DateTime.Parse("06.05.2019");

			// Act
			DateTime result = dt.GetPreviousWeekday(DayOfWeek.Thursday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Thursday);
			result.Day.Should().Be(2);
		}

		[Test]
		public void ShouldGetWeekOfYear()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019");

			// Act
			int result = dt.GetWeekOfYear();

			// Assert
			result.Should().Be(18);
		}

		[Test]
		public void ShouldGetWeeksWeekdayCurrentCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("19.05.2019");

			// Act
			DateTime result = dt.GetWeeksWeekday(DayOfWeek.Tuesday);

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Tuesday);
			result.Day.Should().Be(14);
		}

		[Test]
		public void ShouldGetWeeksWeekdaySaturdayLastDayCulture()
		{
			// Arrange
			DateTime dt = DateTime.Parse("19.05.2019");

			// Act
			DateTime result = dt.GetWeeksWeekday(DayOfWeek.Tuesday, CultureInfo.GetCultureInfo("en-US"));

			// Assert
			result.DayOfWeek.Should().Be(DayOfWeek.Tuesday);
			result.Day.Should().Be(21);
		}

		[Test]
		public void ShouldSetTimeHour()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(0);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinute()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinuteSecond()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35, 12);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(12);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeHourMinuteSecondMillisecond()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.SetTime(18, 35, 12, 564);

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(18);
			result.Minute.Should().Be(35);
			result.Second.Should().Be(12);
			result.Millisecond.Should().Be(564);
		}

		[Test]
		public void ShouldSetTimeToMidnight()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.Midnight();

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(0);
			result.Minute.Should().Be(0);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldSetTimeToNoon()
		{
			// Arrange
			DateTime dt = DateTime.Parse("01.05.2019 16:23:53");

			// Act
			DateTime result = dt.Noon();

			// Assert
			result.Day.Should().Be(1);
			result.Month.Should().Be(5);
			result.Year.Should().Be(2019);
			result.Hour.Should().Be(12);
			result.Minute.Should().Be(0);
			result.Second.Should().Be(0);
			result.Millisecond.Should().Be(0);
		}

		[Test]
		public void ShouldTimeBeEqual()
		{
			// Arrange
			DateTime dt1 = DateTime.Parse("06.05.2019 14:34:56");
			DateTime dt2 = DateTime.Parse("12.05.2019 14:34:56");

			// Act
			bool isTimeEqual = dt1.IsTimeEqual(dt2);

			// Assert
			isTimeEqual.Should().BeTrue();
		}
	}
}
