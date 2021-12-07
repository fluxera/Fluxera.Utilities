namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsBetweenTests
	{
		[Test]
		public void ShouldBeBetween()
		{
			((byte)4).IsBetween(2, 6).Should().BeTrue();
			((short)4).IsBetween(2, 6).Should().BeTrue();
			((int)4).IsBetween(2, 6).Should().BeTrue();
			((long)4).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldBeBetweenAtLowerEnd()
		{
			((byte)2).IsBetween(2, 6).Should().BeTrue();
			((short)2).IsBetween(2, 6).Should().BeTrue();
			((int)2).IsBetween(2, 6).Should().BeTrue();
			((long)2).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldBeBetweenAtUpperEnd()
		{
			((byte)6).IsBetween(2, 6).Should().BeTrue();
			((short)6).IsBetween(2, 6).Should().BeTrue();
			((int)6).IsBetween(2, 6).Should().BeTrue();
			((long)6).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldNotBeBetweenHigher()
		{
			((byte)8).IsBetween(4, 6).Should().BeFalse();
			((short)8).IsBetween(4, 6).Should().BeFalse();
			((int)8).IsBetween(4, 6).Should().BeFalse();
			((long)8).IsBetween(4, 6).Should().BeFalse();
		}

		[Test]
		public void ShouldNotBeBetweenLower()
		{
			((byte)2).IsBetween(4, 6).Should().BeFalse();
			((short)2).IsBetween(4, 6).Should().BeFalse();
			((int)2).IsBetween(4, 6).Should().BeFalse();
			((long)2).IsBetween(4, 6).Should().BeFalse();
		}
	}
}
