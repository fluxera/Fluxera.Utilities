namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsBetweenTests
	{
		[Test]
		public void ShouldBeBetween()
		{
			((byte)4).IsBetween((byte)2, (byte)6).Should().BeTrue();
			((short)4).IsBetween((short)2, (short)6).Should().BeTrue();
			4.IsBetween(2, 6).Should().BeTrue();
			((long)4).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldBeBetweenAtLowerEnd()
		{
			((byte)2).IsBetween((byte)2, (byte)6).Should().BeTrue();
			((short)2).IsBetween((short)2, (short)6).Should().BeTrue();
			2.IsBetween(2, 6).Should().BeTrue();
			((long)2).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldBeBetweenAtUpperEnd()
		{
			((byte)6).IsBetween((byte)2, (byte)6).Should().BeTrue();
			((short)6).IsBetween((short)2, (short)6).Should().BeTrue();
			6.IsBetween(2, 6).Should().BeTrue();
			((long)6).IsBetween(2, 6).Should().BeTrue();
		}

		[Test]
		public void ShouldNotBeBetweenHigher()
		{
			((byte)8).IsBetween((byte)4, (byte)6).Should().BeFalse();
			((short)8).IsBetween((short)4, (short)6).Should().BeFalse();
			8.IsBetween(4, 6).Should().BeFalse();
			((long)8).IsBetween(4, 6).Should().BeFalse();
		}

		[Test]
		public void ShouldNotBeBetweenLower()
		{
			((byte)2).IsBetween((byte)4, (byte)6).Should().BeFalse();
			((short)2).IsBetween((short)4, (short)6).Should().BeFalse();
			2.IsBetween(4, 6).Should().BeFalse();
			((long)2).IsBetween(4, 6).Should().BeFalse();
		}
	}
}
