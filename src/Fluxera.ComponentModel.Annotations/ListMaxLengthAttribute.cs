namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.Collections;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute to check the maximum length of a list.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ListMaxLengthAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="ListMaxLengthAttribute" /> type.
		/// </summary>
		/// <param name="maximumLength"></param>
		public ListMaxLengthAttribute(int maximumLength)
		{
			Guard.Against.Negative(maximumLength, nameof(maximumLength));

			this.MaximumLength = maximumLength;
		}

		/// <summary>
		///     Gets the maximum acceptable length of the enumerable.
		/// </summary>
		private int MaximumLength { get; }

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is IEnumerable items)
			{
				long length = items.Cast<object>().LongCount();
				return length <= this.MaximumLength;
			}

			throw new InvalidOperationException("The attribute can only be used with IEnumerable properties.");
		}
	}
}
