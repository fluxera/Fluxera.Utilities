namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GuidExtensionsTests
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
