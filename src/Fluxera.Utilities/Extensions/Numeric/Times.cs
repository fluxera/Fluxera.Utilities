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
#if NET7_0_OR_GREATER
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
#endif

#if NET6_0
		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this byte value, Action action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<byte>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this byte value, Action<byte> action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<byte>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this short value, Action action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<short>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this short value, Action<short> action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<short>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this int value, Action action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<int>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this int value, Action<int> action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<int>(value, action);
		}


		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this long value, Action action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<long>(value, action);
		}

		/// <summary>
		///     Performs the specified action n times based on the underlying value.
		/// </summary>
		/// <param name="value">The iteration count value.</param>
		/// <param name="action">The action to perform.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Times(this long value, Action<long> action)
		{
			Guard.Against.Negative(value, nameof(value));
			Guard.Against.Null(action, nameof(action));

			Times<long>(value, action);
		}

		private static void Times<T>(T value, Action action)
			where T : struct, IComparable, IComparable<T>
		{
			for(long i = 0; i.CompareTo(Convert.ToInt64(value)) < 0; i++)
			{
				action();
			}
		}

		private static void Times<T>(T value, Action<T> action)
			where T : struct, IComparable, IComparable<T>
		{
			for(long i = 0; i.CompareTo(Convert.ToInt64(value)) < 0; i++)
			{
				action((T)Convert.ChangeType(i, typeof(T)));
			}
		}
#endif
	}
}
