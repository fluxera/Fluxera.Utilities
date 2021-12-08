namespace Fluxera.Utilities.UnitTests.Extensions.Principal
{
	using System.Collections.Generic;
	using System.Security.Claims;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class GetClaimValueTests
	{
		[Test]
		public void ShouldGetExistingClaimValue()
		{
			// Arrange
			ClaimsIdentity identity = new ClaimsIdentity(new List<Claim>
			{
				new Claim("test-claim", "Hallo"),
			});
			ClaimsPrincipal principal = new ClaimsPrincipal(identity);

			// Act
			string? result = principal.GetClaimValue("test-claim");

			// Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("Hallo");
		}

		[Test]
		public void ShouldNotGetNotExistingClaimValue()
		{
			// Arrange
			ClaimsIdentity identity = new ClaimsIdentity(new List<Claim>
			{
				new Claim("test-claim", "Hallo"),
			});
			ClaimsPrincipal principal = new ClaimsPrincipal(identity);

			// Act
			string? result = principal.GetClaimValue("test-klaim");

			// Assert
			result.Should().BeNull();
		}
	}
}
