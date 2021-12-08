namespace Fluxera.Utilities.UnitTests.Extensions.Principal
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Claims;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetClaimValuesTests
	{
		[Test]
		public void ShouldGetExistingClaimValues()
		{
			// Arrange
			ClaimsIdentity identity = new ClaimsIdentity(new List<Claim>
			{
				new Claim("test-claim", "Hallo0"),
				new Claim("test-claim", "Hallo1"),
			});
			ClaimsPrincipal principal = new ClaimsPrincipal(identity);

			// Act
			IEnumerable<string> results = principal.GetClaimValues("test-claim");

			// Assert
			IList<string> list = results.ToList();
			list.Should().NotBeNullOrEmpty();
			for (int index = 0; index < list.Count; index++)
			{
				string result = list[index];
				result.Should().NotBeNullOrWhiteSpace();
				result.Should().Be("Hallo" + index);
			}
		}

		[Test]
		public void ShouldNotGetExistingClaimValues()
		{
			// Arrange
			ClaimsIdentity identity = new ClaimsIdentity(new List<Claim>
			{
				new Claim("test-claim", "Hallo0"),
				new Claim("test-claim", "Hallo1"),
			});
			ClaimsPrincipal principal = new ClaimsPrincipal(identity);

			// Act
			IEnumerable<string> results = principal.GetClaimValues("test-klaim");

			// Assert
			IList<string> list = results.ToList();
			list.Should().NotBeNull();
			list.Should().BeEmpty();
		}
	}
}
