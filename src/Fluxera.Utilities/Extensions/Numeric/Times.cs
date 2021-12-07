// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using Guards;
	using JetBrains.Annotations;

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
	}
}
