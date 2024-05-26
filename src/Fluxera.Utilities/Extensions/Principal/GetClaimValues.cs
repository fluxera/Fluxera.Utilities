// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Claims;

	/// <summary>
	///     Extension methods for the <see cref="ClaimsPrincipal" /> type.
	/// </summary>
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
			Guard.ThrowIfNull(principal);
			Guard.ThrowIfNullOrWhiteSpace(claim);

			return principal.FindAll(x => x.Type == claim).Select(x => x.Value);
		}
	}
}
