namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using JetBrains.Annotations;

	/// <summary>
	///     An attribute to provide the date precision to potential data stores.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class DatePrecisionAttribute : Attribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="DatePrecisionAttribute" /> type.
		/// </summary>
		/// <param name="precision"></param>
		public DatePrecisionAttribute(byte precision)
		{
			this.Precision = precision;
		}

		/// <summary>
		///     Gets the precision.
		/// </summary>
		public byte Precision { get; }
	}
}
