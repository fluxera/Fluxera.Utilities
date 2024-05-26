namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.Collections;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute to check the minimum length of a list.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ListMinLengthAttribute : ValidationAttribute
	{
		/// <summary>
		///     Creates a new instance of the <see cref="ListMinLengthAttribute" /> type.
		/// </summary>
		/// <param name="minimumLength"></param>
		public ListMinLengthAttribute(int minimumLength)
		{
			Guard.ThrowIfNegative(minimumLength);

			this.MinimumLength = minimumLength;
		}

		/// <summary>
		///     Gets or sets the minimum acceptable length of the enumerable.
		/// </summary>
		private int MinimumLength { get; }

		/// <inheritdoc />
		public override bool IsValid(object value)
		{
			if(value is IEnumerable items)
			{
				long length = items.Cast<object>().LongCount();
				return length >= this.MinimumLength;
			}

			throw new InvalidOperationException("The attribute can only be used with IEnumerable properties.");
		}
	}
}
