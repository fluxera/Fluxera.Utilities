namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

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
