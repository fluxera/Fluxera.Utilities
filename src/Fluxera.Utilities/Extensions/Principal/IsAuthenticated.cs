﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Diagnostics;
	using System.Security.Principal;

	/// <summary>
	///     Extension methods for the <see cref="IPrincipal" /> type.
	/// </summary>
	public static partial class PrincipalExtensions
	{
		/// <summary>
		///     Determines whether this principal is authenticated.
		/// </summary>
		/// <param name="principal">The principal.</param>
		/// <returns><c>true</c> if the specified principal is authenticated; otherwise, <c>false</c>.</returns>
		[DebuggerStepThrough]
		public static bool IsAuthenticated(this IPrincipal principal)
		{
			Guard.ThrowIfNull(principal);

			return principal.Identity != null && principal.Identity.IsAuthenticated;
		}
	}
}
