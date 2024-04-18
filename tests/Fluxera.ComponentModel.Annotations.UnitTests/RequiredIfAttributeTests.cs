namespace Fluxera.ComponentModel.Annotations.UnitTests
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Reflection;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class RequiredIfAttributeTests
	{
		[Test]
		public void ShouldBeRequired()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfBoolean = true,
				RequiredIfBooleanString = null
			};

			// Act
			RequiredIfAttribute requiredAttribute = obj.GetType().GetProperty(nameof(TestClass.RequiredIfBooleanString)).GetCustomAttribute<RequiredIfAttribute>();
			bool result = requiredAttribute.IsRequired(obj);

			// Assert
			result.Should().BeTrue();
		}

		[Test]
		public void ShouldHaveValidationError_Boolean()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfBooleanString = null
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldHaveValidationError_Enum()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfEnumString = null
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldNotBeRequired()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfBoolean = false,
				RequiredIfBooleanString = null
			};

			// Act
			RequiredIfAttribute requiredAttribute = obj.GetType().GetProperty(nameof(TestClass.RequiredIfBooleanString)).GetCustomAttribute<RequiredIfAttribute>();
			bool result = requiredAttribute.IsRequired(obj);

			// Assert
			result.Should().BeFalse();
		}

		[Test]
		public void ShouldNotHaveValidationError_Boolean()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfBooleanString = "Hallo"
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}

		[Test]
		public void ShouldNotHaveValidationError_Enum()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				RequiredIfEnumString = "Hallo"
			};

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}

		// TODO: Test more edge cases.
	}
}
