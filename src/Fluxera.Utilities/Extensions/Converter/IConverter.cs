// ReSharper disable once CheckNamespace
namespace Fluxera.Utilities.Extensions
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     Interface for all converter based implementations.
	/// </summary>
	[PublicAPI]
	public interface IConverter<out T>
	{
		/// <summary>
		///     Gets the internal value to be converted.
		/// </summary>
		/// <value>The internal value.</value>
		T Value { get; }

		/// <summary>
		///     Get the format provider to use for conversions.
		/// </summary>
		/// <value>The format provider.</value>
		IFormatProvider FormatProvider { get; }
	}
}
