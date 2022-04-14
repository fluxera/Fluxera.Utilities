namespace Fluxera.Utilities.UnitTests.Extensions.Type
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

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
