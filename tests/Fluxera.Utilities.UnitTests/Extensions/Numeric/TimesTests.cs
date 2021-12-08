namespace Fluxera.Utilities.UnitTests.Extensions.Numeric
{
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class TimesTests
	{
		[Test]
		public void ShouldExecuteTimesByte()
		{
			byte counter = 0;
			((byte)5).Times(() => counter++);

			counter.Should().Be(5);
		}

		[Test]
		public void ShouldExecuteTimesWithCounterByte()
		{
			byte counter = 0;
			((byte)5).Times(i => counter += i);

			counter.Should().Be(10);
		}

		[Test]
		public void ShouldExecuteTimesShort()
		{
			short counter = 0;
			((short)5).Times(() => counter++);

			counter.Should().Be(5);
		}

		[Test]
		public void ShouldExecuteTimesWithCounterShort()
		{
			short counter = 0;
			((short)5).Times(i => counter += i);

			counter.Should().Be(10);
		}

		[Test]
		public void ShouldExecuteTimesInt()
		{
			int counter = 0;
			((int)5).Times(() => counter++);

			counter.Should().Be(5);
		}

		[Test]
		public void ShouldExecuteTimesWithCounterInt()
		{
			int counter = 0;
			((int)5).Times(i => counter += i);

			counter.Should().Be(10);
		}

		[Test]
		public void ShouldExecuteTimesLong()
		{
			long counter = 0;
			((long)5).Times(() => counter++);

			counter.Should().Be(5);
		}

		[Test]
		public void ShouldExecuteTimesWithCounterLong()
		{
			long counter = 0;
			((long)5).Times(i => counter += i);

			counter.Should().Be(10);
		}
	}
}
