namespace Fluxera.Utilities.UnitTests.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using FluentAssertions;
	using NUnit.Framework;
	using Utilities.Extensions;

	[TestFixture]
	public class EnumerableExtensionsTests
	{
		[Test]
		public void ShouldCheckNotNullOrEmptyForEmpty()
		{
			// Arrange
			IEnumerable<string> enumerable = new List<string>
			{
				"Test", "Auto", "Radio",
			};

			bool isNullOrEmpty = enumerable.IsNotNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}


		[Test]
		public void ShouldCheckNotNullOrEmptyForNull()
		{
			// Arrange
			IEnumerable<string> enumerable = null;

			bool isNullOrEmpty = enumerable.IsNotNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeFalse();
		}

		[Test]
		public void ShouldCheckNullOrEmptyForEmpty()
		{
			// Arrange
			IEnumerable<string> enumerable = Enumerable.Empty<string>();

			bool isNullOrEmpty = enumerable.IsNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}

		[Test]
		public void ShouldCheckNullOrEmptyForNull()
		{
			// Arrange
			IEnumerable<string> enumerable = null;

			bool isNullOrEmpty = enumerable.IsNullOrEmpty();

			// Assert
			isNullOrEmpty.Should().BeTrue();
		}

		[Test]
		public void ShouldCreateReadOnly()
		{
			// Arrange
			IEnumerable<string> enumerable = Enumerable.Empty<string>();

			// Act
			IReadOnlyCollection<string> readOnlyList = enumerable.AsReadOnly();

			// Assert
			readOnlyList.Should().NotBeNull();
		}

		[Test]
		public void ShouldIterateForEachElement()
		{
			// Arrange
			IEnumerable<string> enumerable = new List<string>
			{
				"Test", "Auto", "Radio",
			};

			// Act
			string result = string.Empty;
			enumerable.ForEach(x => result += x);

			// Assert
			result.Should().NotBeEmpty();
			result.Should().Be("TestAutoRadio");
		}

		[Test]
		public void ForEachThrowsGivenNullInput()
		{
			IEnumerable<object> enumeration = null;

			Action action = () => enumeration.ForEach(x => x.ToString());
			
			action.Should().Throw<ArgumentNullException>();
		}

		[Test]
		public void ForEachThrowsGivenNullAction()
		{
			IEnumerable<object> enumeration = new List<object>();

			Action<object> enumAction = null;

			Action action = () => enumeration.ForEach(enumAction);

			action.Should().Throw<ArgumentNullException>();
		}

		[Test]
		public void ForEachExecutesActionOncePerItem()
		{
			IEnumerable<int> input = new List<int> { 1, 2, 3 };
			int sum = 0;
			Action<int> action = (int x) => sum += x;

			input.ForEach(action);

			sum.Should().Be(6);
		}

		[Test]
		public void ReturnsTrueGivenEnumerableThatHaveValues()
		{
			IEnumerable<int> enumeration = new List<int> { 1, 2, 3, 4 };

			bool result = enumeration.IsAny();

			result.Should().BeTrue();
		}

		[Test]
		public void ReturnsFalseGivenEmptyEnumerable()
		{
			IEnumerable<object> enumeration = null;

			bool result = enumeration.IsAny();

			result.Should().BeFalse();
		}
	}
}
