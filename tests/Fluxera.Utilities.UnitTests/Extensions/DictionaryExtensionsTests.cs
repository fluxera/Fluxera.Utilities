namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.Collections.Generic;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class DictionaryExtensionsTests
	{
		[Test]
		public void ShouldContainValue()
		{
			// Arrange
			IDictionary<string, string> dict = new Dictionary<string, string>
			{
				{"key-1", "Hallo"},
				{"key-2", "Radio"},
				{"key-3", "Auto"},
				{"key-4", "World"},
			};

			// Act
			bool containsValue = dict.ContainsValue("Radio");

			// Assert
			containsValue.Should().BeTrue();
		}

		[Test]
		public void ShouldNotContainValue()
		{
			// Arrange
			IDictionary<string, string> dict = new Dictionary<string, string>
			{
				{"key-1", "Hallo"},
				{"key-2", "Radio"},
				{"key-3", "Auto"},
				{"key-4", "World"},
			};

			// Act
			bool containsValue = dict.ContainsValue("Tesla");

			// Assert
			containsValue.Should().BeFalse();
		}
	}
}
