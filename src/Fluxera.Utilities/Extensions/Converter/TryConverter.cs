// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Globalization;

	/// <summary>
	///     Internal default implementation for try converters.
	/// </summary>
	internal sealed class TryConverter<T> : ITryConverter<T>
	{
		/// <summary>
		///     Initializes a new instance of the Converter class. The current
		///     culture is used as format provider.
		/// </summary>
		/// <param name="value">The internal value.</param>
		public TryConverter(T value)
			: this(value, CultureInfo.CurrentCulture) { }

		/// <summary>
		///     Initializes a new instance of the Converter class.
		/// </summary>
		/// <param name="value">The internal value.</param>
		/// <param name="formatProvider">The format provider to use for conversions.</param>
		public TryConverter(T value, IFormatProvider formatProvider)
		{
			this.Value = value;
			this.FormatProvider = formatProvider ?? CultureInfo.CurrentCulture;
		}

		/// <summary>
		///     Gets the internal value to be converted.
		/// </summary>
		/// <value>The internal value.</value>
		public T Value { get; }

		/// <summary>
		///     Get the format provider to use for conversions.
		/// </summary>
		/// <value>The format provider.</value>
		public IFormatProvider FormatProvider { get; }
	}
}
