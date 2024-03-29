﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Diagnostics;
	using System.Security.Claims;
	using System.Security.Principal;
	using Fluxera.Guards;

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
			Guard.Against.Null(principal, nameof(principal));

			return principal.Identity.GetSubjectId();
		}

		/// <summary>
		///     Gets the subject identifier.
		/// </summary>
		/// <param name="identity">The identity.</param>
		/// <returns>The subject.</returns>
		/// <exception cref="InvalidOperationException">sub claim is missing</exception>
		[DebuggerStepThrough]
		public static string GetSubjectId(this IIdentity identity)
		{
			Guard.Against.Null(identity, nameof(identity));

			ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
			Claim claim = claimsIdentity?.FindFirst("sub");

			return claim?.Value ?? string.Empty;
		}
	}
}
