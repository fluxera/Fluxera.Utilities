// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for date-time values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class DateTimeAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public DateTimeAttribute() : base(DataType.DateTime)
		{
		}
	}
}
