// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Claims;
	using Guards;

	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Gets all values of the given claim type and returns their values.
		/// </summary>
		/// <param name="principal">The principal instance.</param>
		/// <param name="claim">Teh claim type to get.</param>
		/// <returns>The values of the claim or null.</returns>
		public static IEnumerable<string> GetClaimValues(this ClaimsPrincipal principal, string claim)
		{
			Guard.Against.Null(principal, nameof(principal));
			Guard.Against.NullOrWhiteSpace(claim, nameof(claim));

			return principal.FindAll(x => x.Type == claim).Select(x => x.Value);
		}
	}
}
