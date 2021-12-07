namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System.Reflection;
	using System.Threading.Tasks;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class AssemblyExtensionsTests
	{
		[Test]
		public async Task ShouldGetResourceAsString()
		{
			// Arrange
			Assembly assembly = Assembly.GetExecutingAssembly();

			// Act
			string result =
				await assembly.GetResourceAsStringAsync("Fluxera.Utilities.UnitTests.Properties.Test.txt");

			// Assert
			result.Should().NotBeNullOrEmpty();
			result.Should().Be("Hello");
		}
	}
}
