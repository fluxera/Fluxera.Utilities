namespace Fluxera.Utilities.UnitTests.Extensions.String
{
	using System.Globalization;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class IsNullOrEmptyTests
	{
		[SetUp]
		public void Setup()
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
		}

		[Test]
		public void ShouldCheckIsNotNullOrEmptyWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNotNullOrEmpty();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrEmptyWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNotNullOrEmpty();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrWhiteSpaceWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNotNullOrWhiteSpace();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNotNullOrWhiteSpaceWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNotNullOrWhiteSpace();

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckIsNullOrEmptyWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNullOrEmpty();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrEmptyWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNullOrEmpty();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrWhiteSpaceWithEmpty()
		{
			// Arrange
			string str = string.Empty;

			// Act
			bool result = str.IsNullOrWhiteSpace();

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckIsNullOrWhiteSpaceWithNull()
		{
			// Arrange
			string str = null;

			// Act
			bool result = str.IsNullOrWhiteSpace();

			// Assert
			result.Should().BeTrue();
		}
	}
}
