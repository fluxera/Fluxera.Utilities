namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsOddTests
	{
		[Test]
		public void ShouldBeOdd()
		{
			((byte)5).IsOdd().Should().BeTrue();
			((short)5).IsOdd().Should().BeTrue();
			((int)5).IsOdd().Should().BeTrue();
			((long)5).IsOdd().Should().BeTrue();
		}
	}
}
