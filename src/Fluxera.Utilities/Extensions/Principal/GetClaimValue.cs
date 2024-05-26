// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Security.Claims;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="ClaimsPrincipal" /> type.
	/// </summary>
	[PublicAPI]
	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Gets the first value of the given claim type and returns its value.
		/// </summary>
		/// <param name="principal">The principal instance.</param>
		/// <param name="claim">The claim type to get.</param>
		/// <returns>The values of the claim or null.</returns>
		public static string GetClaimValue(this ClaimsPrincipal principal, string claim)
		{
			Guard.ThrowIfNull(principal);
			Guard.ThrowIfNullOrWhiteSpace(claim);

			return principal.FindFirst(claim)?.Value;
		}
	}
}
