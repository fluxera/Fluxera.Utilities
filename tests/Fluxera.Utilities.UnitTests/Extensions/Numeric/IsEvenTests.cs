// ReSharper disable RedundantCast

namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class IsEvenTests
	{
		[Test]
		public void ShouldBeEven()
		{
			((byte)4).IsEven().Should().BeTrue();
			((short)4).IsEven().Should().BeTrue();
			((int)4).IsEven().Should().BeTrue();
			((long)4).IsEven().Should().BeTrue();
		}
	}
}
