// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for the <see cref="Nullable{T}" /> type.
	/// </summary>
	[PublicAPI]
	public static class NullableExtensions
	{
		/// <summary>
		///     Checks if the given nullable has no value.
		/// </summary>
		/// <typeparam name="T">The type of the nullable.</typeparam>
		/// <param name="target">The target nullable.</param>
		/// <returns><code>true</code> if the target is null, <code>false</code> otherwise.</returns>
		[ContractAnnotation("null => true")]
		public static bool IsNull<T>(this T? target) where T : struct
		{
			return !target.HasValue;
		}

		/// <summary>
		///     Checks if the given nullable has a value.
		/// </summary>
		/// <typeparam name="T">The type of the nullable.</typeparam>
		/// <param name="target">The target nullable.</param>
		/// <returns><code>true</code> if the target is not null, <code>false</code> otherwise.</returns>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNull<T>(this T? target) where T : struct
		{
			return !target.IsNull();
		}
	}
}
