// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Numerics;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     Extension methods for numeric types.
	/// </summary>
	[PublicAPI]
	public static partial class NumericExtensions
	{
		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times<T>(this T value, Action action) where T : INumber<T>
		{
			// Against Negative
			Guard.Against.False(T.IsPositive(value), message: "The number must be positive.");
			Guard.Against.Null(action, nameof(action));

			for(T i = T.Zero; i < value; i++)
			{
				action.Invoke();
			}
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times<T>(this T value, Action<T> action) where T : INumber<T>
		{
			// Against Negative
			Guard.Against.False(T.IsPositive(value), message: "The number must be positive.");
			Guard.Against.Null(action, nameof(action));

			for(T i = T.Zero; i < value; i++)
			{
				action.Invoke(i);
			}
		}
	}
}
