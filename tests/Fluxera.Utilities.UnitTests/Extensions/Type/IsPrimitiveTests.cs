namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsAssignableToTests
	{
		private class First
		{
		}

		private class Second : First
		{
		}

		[Test]
		public void ShouldBeAssignableTo()
		{
			bool result = typeof(Second).IsAssignableTo<First>();
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldNotBeAssignableTo()
		{
			bool result = typeof(First).IsAssignableTo<Second>();
			result.Should().BeFalse();
		}
	}

	[TestFixture]
	public class IsAssignableFromTests
	{
		private class First
		{
		}

		private class Second : First
		{
		}

		[Test]
		public void ShouldBeAssignableFrom()
		{
			bool result = typeof(First).IsAssignableFrom<Second>();
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldNotBeAssignableFrom()
		{
			bool result = typeof(Second).IsAssignableFrom<First>();
			result.Should().BeFalse();
		}
	}

	[TestFixture]
	public class IsPrimitiveTests
	{
		public static IEnumerable<object[]> TestCases()
		{
			yield return new object[] { typeof(string), true };
			yield return new object[] { typeof(decimal), true };
			yield return new object[] { typeof(DateTime), true };
			yield return new object[] { typeof(DateTimeOffset), true };
			yield return new object[] { typeof(TimeSpan), true };
			yield return new object[] { typeof(Guid), true };
			yield return new object[] { typeof(decimal?), true };
			yield return new object[] { typeof(DateTime?), true };
			yield return new object[] { typeof(DateTimeOffset?), true };
			yield return new object[] { typeof(TimeSpan?), true };
			yield return new object[] { typeof(Guid?), true };
			yield return new object[] { typeof(byte), true };
			yield return new object[] { typeof(short), true };
			yield return new object[] { typeof(int), true };
			yield return new object[] { typeof(long), true };
			yield return new object[] { typeof(float), true };
			yield return new object[] { typeof(double), true };
			yield return new object[] { typeof(byte?), true };
			yield return new object[] { typeof(short?), true };
			yield return new object[] { typeof(int?), true };
			yield return new object[] { typeof(long?), true };
			yield return new object[] { typeof(float?), true };
			yield return new object[] { typeof(double?), true };
		}

		[Test]
		[TestCaseSource(nameof(TestCases))]
		public void ShouldRecognizeAsPrimitive(Type type, bool expected)
		{
			type.IsPrimitive().Should().Be(expected);
		}
	}
}
