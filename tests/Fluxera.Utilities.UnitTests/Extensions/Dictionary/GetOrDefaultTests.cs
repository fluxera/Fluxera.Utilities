namespace Fluxera.Utilities.UnitTests.Extensions.Dictionary
{
	using System.Collections.Concurrent;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Utilities.Extensions;
	using NUnit.Framework;

	[TestFixture]
	public class GetOrDefaultTests
	{
		[Test]
		public void ShouldGetValue_ConcurrentDict()
		{
			// Arrange
			IDictionary<string, string> values = new Dictionary<string, string>
			{
				{ "key-1", "Hallo" },
				{ "key-2", "Radio" },
				{ "key-3", "Auto" },
				{ "key-4", "World" },
			};
			ConcurrentDictionary<string, string> dict = new ConcurrentDictionary<string, string>(values);

			// Act
			string value = dict.GetOrDefault("key-2");

			// Assert
			value.Should().NotBeNull().And.Be("Radio");
		}

		[Test]
		public void ShouldGetValue_Dict()
		{
			// Arrange
			Dictionary<string, string> dict = new Dictionary<string, string>
			{
				{ "key-1", "Hallo" },
				{ "key-2", "Radio" },
				{ "key-3", "Auto" },
				{ "key-4", "World" },
			};

			// Act
			string value = dict.GetOrDefault("key-2");

			// Assert
			value.Should().NotBeNull().And.Be("Radio");
		}

		[Test]
		public void ShouldGetValue_IDict()
		{
			// Arrange
			IDictionary<string, string> dict = new Dictionary<string, string>
			{
				{ "key-1", "Hallo" },
				{ "key-2", "Radio" },
				{ "key-3", "Auto" },
				{ "key-4", "World" },
			};

			// Act
			string value = dict.GetOrDefault("key-2");

			// Assert
			value.Should().NotBeNull().And.Be("Radio");
		}

		[Test]
		public void ShouldGetValue_IReadOnlyDict()
		{
			// Arrange
			IReadOnlyDictionary<string, string> dict = new Dictionary<string, string>
			{
				{ "key-1", "Hallo" },
				{ "key-2", "Radio" },
				{ "key-3", "Auto" },
				{ "key-4", "World" },
			};

			// Act
			string value = dict.GetOrDefault("key-2");

			// Assert
			value.Should().NotBeNull().And.Be("Radio");
		}
	}
}
