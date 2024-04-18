// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///		A data-type attribute for time values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class TimeAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public TimeAttribute() : base(DataType.Time)
		{
		}
	}
}
