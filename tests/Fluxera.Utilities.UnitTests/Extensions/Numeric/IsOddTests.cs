// ReSharper disable RedundantCast

namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

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
