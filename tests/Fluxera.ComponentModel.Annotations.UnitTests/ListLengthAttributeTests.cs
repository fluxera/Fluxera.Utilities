namespace Fluxera.ComponentModel.Annotations.UnitTests
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class ListLengthAttributeTests
	{
		[Test]
		public void ShouldHaveValidationError_MinMax_TooLess()
		{
			// Arrange  
			TestClass obj = new TestClass
			{
				ListLengthMinMaxList = new List<object>()
			};
			obj.ListLengthMinMaxList.Add(new object());

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldHaveValidationError_MinMax_TooMay()
		{
			// Arrange  
			TestClass obj = new TestClass
			{
				ListLengthMinMaxList = new List<object>()
			};
			for(int i = 0; i < 11; i++)
			{
				obj.ListLengthMinMaxList.Add(new object());
			}

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldHaveValidationError_OnlyMax_TooMany()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				ListLengthMaxList = new List<object>()
			};
			for(int i = 0; i < 11; i++)
			{
				obj.ListLengthMaxList.Add(new object());
			}

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeFalse();
			results.Count.Should().Be(1);
		}

		[Test]
		public void ShouldNotHaveValidationError_MinMax()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				ListLengthMinMaxList = new List<object>()
			};
			for(int i = 0; i < 10; i++)
			{
				obj.ListLengthMinMaxList.Add(new object());
			}

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}

		[Test]
		public void ShouldNotHaveValidationError_OnlyMax()
		{
			// Arrange
			TestClass obj = new TestClass
			{
				ListLengthMaxList = new List<object>()
			};
			for(int i = 0; i < 10; i++)
			{
				obj.ListLengthMaxList.Add(new object());
			}

			// Act
			ICollection<ValidationResult> results = new List<ValidationResult>();
			bool result = Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

			// Assert
			result.Should().BeTrue();
			results.Count.Should().Be(0);
		}
	}
}
