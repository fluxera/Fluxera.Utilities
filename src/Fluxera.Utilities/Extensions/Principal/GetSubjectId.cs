// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Diagnostics;
	using System.Security.Claims;
	using System.Security.Principal;

	/// <summary>
	///     Extension methods for the <see cref="ClaimsPrincipal" /> type.
	/// </summary>
	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Gets the subject identifier.
		/// </summary>
		/// <param name="principal">The principal.</param>
		/// <returns>The subject.</returns>
		[DebuggerStepThrough]
		public static string GetSubjectId(this IPrincipal principal)
		{
			Guard.ThrowIfNull(principal);

			return principal.Identity.GetSubjectId();
		}

		/// <summary>
		///     Gets the subject identifier.
		/// </summary>
		/// <param name="identity">The identity.</param>
		/// <returns>The subject.</returns>
		/// <exception cref="InvalidOperationException">When the 'sub' claim is missing.</exception>
		[DebuggerStepThrough]
		public static string GetSubjectId(this IIdentity identity)
		{
			Guard.ThrowIfNull(identity);

			ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
			Claim claim = claimsIdentity?.FindFirst("sub");

			return claim?.Value ?? string.Empty;
		}
	}
}
