namespace Fluxera.Utilities.UnitTests.Extensions.Guid
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsEmptyTests
	{
		[Test]
		public void ShouldBeEmpty()
		{
			// Arrange
			Guid guid = Guid.Empty;

			// Act
			bool isEmpty = guid.IsEmpty();

			// Assert
			isEmpty.Should().BeTrue();
		}

		[Test]
		public void ShouldNotBeEmpty()
		{
			// Arrange
			Guid guid = Guid.NewGuid();

			// Act
			bool isNotEmpty = guid.IsNotEmpty();

			// Assert
			isNotEmpty.Should().BeTrue();
		}
	}
}
