namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.Collections;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute to check the length of a list.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ListLengthAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="ListLengthAttribute" /> type.
		/// </summary>
		/// <param name="maximumLength"></param>
		public ListLengthAttribute(int maximumLength)
		{
			Guard.ThrowIfNegative(maximumLength);

			this.MaximumLength = maximumLength;
		}

		/// <summary>
		///     Gets the maximum acceptable length of the enumerable.
		/// </summary>
		private int MaximumLength { get; }

		/// <summary>
		///     Gets or sets the minimum acceptable length of the enumerable.
		/// </summary>
		public int MinimumLength { get; set; }

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is IEnumerable items)
			{
				long length = items.Cast<object>().LongCount();
				return (length >= this.MinimumLength) && (length <= this.MaximumLength);
			}

			throw new InvalidOperationException("The attribute can only be used with IEnumerable properties.");
		}
	}
}
