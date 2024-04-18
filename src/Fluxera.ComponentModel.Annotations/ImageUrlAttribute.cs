// ReSharper disable once CheckNamespace

namespace System.ComponentModel.DataAnnotations
{
	using JetBrains.Annotations;

	/// <summary>
	///     A data-type attribute for image-url values.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class ImageUrlAttribute : DataTypeAttribute
	{
		/// <inheritdoc />
		public ImageUrlAttribute() : base(DataType.ImageUrl)
		{
		}

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value == null)
			{
				return true;
			}

			return value is string valueAsString &&
				(valueAsString.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
					|| valueAsString.StartsWith("https://", StringComparison.OrdinalIgnoreCase)
					|| valueAsString.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase));
		}
	}
}
