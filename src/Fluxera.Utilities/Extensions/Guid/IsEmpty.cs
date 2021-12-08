// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class GuidExtensions
	{
		/// <summary>
		///     Checks if the given <see cref="Guid" /> is <see cref="Guid.Empty" />.
		/// </summary>
		/// <param name="guid">The guid to check.</param>
		/// <returns><c>true</c> if empty, <c>false</c> otherwise.</returns>
		public static bool IsEmpty(this Guid guid)
		{
			return guid == Guid.Empty;
		}

		/// <summary>
		///     Checks if the given <see cref="Guid" /> is not <see cref="Guid.Empty" />.
		/// </summary>
		/// <param name="guid">The guid to check.</param>
		/// <returns><c>true</c> if not empty, <c>false</c> otherwise.</returns>
		public static bool IsNotEmpty(this Guid guid)
		{
			return !guid.IsEmpty();
		}
	}
}
