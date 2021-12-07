// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Claims;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Gets the first value of the given claim type and returns its value.
		/// </summary>
		/// <param name="principal"></param>
		/// <param name="claim"></param>
		/// <returns></returns>
		public static string? GetClaimValue(this ClaimsPrincipal principal, string claim)
		{
			Guard.Against.Null(principal, nameof(principal));
			Guard.Against.NullOrWhiteSpace(claim, nameof(claim));

			return principal.FindFirst(claim)?.Value;
		}

		/// <summary>
		///     Gets all values of the given claim type and returns their values.
		/// </summary>
		/// <param name="principal"></param>
		/// <param name="claim"></param>
		/// <returns></returns>
		[NotNull]
		public static IEnumerable<string> GetClaimValues(this ClaimsPrincipal principal, string claim)
		{
			Guard.Against.Null(principal, nameof(principal));
			Guard.Against.NullOrWhiteSpace(claim, nameof(claim));

			return principal.FindAll(x => x.Type == claim).Select(x => x.Value);
		}
	}
}
