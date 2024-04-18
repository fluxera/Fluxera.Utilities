namespace Fluxera.ComponentModel.Annotations
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A validation attribute that checks if the value is required when a condition is met.
	/// </summary>
	/// <remarks>
	///     http://stackoverflow.com/questions/7390902/requiredif-conditional-validation-attribute
	/// </remarks>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class RequiredIfAttribute : RequiredAttribute
	{
		private readonly object[] desiredValues;
		private readonly string propertyName;

		/// <summary>
		///     Creates a new instance of the <see cref="RequiredIfAttribute" /> type.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="desiredValues">The desired values are OR-ed when evaluating.</param>
		public RequiredIfAttribute([InvokerParameterName] string propertyName, params object[] desiredValues)
		{
			Guard.Against.NullOrWhiteSpace(propertyName, nameof(propertyName));
			Guard.Against.Null(desiredValues, nameof(desiredValues));

			this.propertyName = propertyName;
			this.desiredValues = desiredValues;
		}

		/// <inheritdoc />
		protected override ValidationResult IsValid(object instance, ValidationContext validationContext)
		{
			Type type = validationContext.ObjectInstance.GetType();
			object propertyValue = type.GetProperty(this.propertyName)?.GetValue(validationContext.ObjectInstance, null);

			foreach(object desiredValue in this.desiredValues)
			{
				if(propertyValue?.ToString() == desiredValue?.ToString())
				{
					ValidationResult validationResult = base.IsValid(instance, validationContext);
					return validationResult;
				}
			}

			return ValidationResult.Success;
		}

		/// <summary>
		///     Evaluates the required flag for the given instance.
		/// </summary>
		/// <param name="instance"></param>
		/// <returns></returns>
		public bool IsRequired(object instance)
		{
			Type type = instance.GetType();
			object propertyValue = type.GetProperty(this.propertyName)?.GetValue(instance, null);

			bool isRequired = false;

			foreach(object desiredValue in this.desiredValues)
			{
				isRequired |= propertyValue?.ToString() == desiredValue?.ToString();
			}

			return isRequired;
		}
	}
}
