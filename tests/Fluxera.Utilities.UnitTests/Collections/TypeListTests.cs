namespace Fluxera.Utilities.UnitTests.Collections
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Fluxera.Collections.Generic;
	using NUnit.Framework;

	[TestFixture]
	public class TypeListTests
	{
		private interface ITestInterface
		{
		}

		private class TestClass : ITestInterface
		{
		}

		private class NoGoodTestClass
		{
		}

		[Test]
		public void ShouldAllowInheritedType()
		{
			ITypeList<ITestInterface> list = new TypeList<ITestInterface>();
			list.Add<TestClass>();

			list[0].Should().Be<TestClass>();
		}


		[Test]
		public void ShouldAllowInheritedType_DefaultAdd()
		{
			IList<Type> list = new TypeList<ITestInterface>();
			list.Add(typeof(TestClass));

			list[0].Should().Be<TestClass>();
		}

		[Test]
		public void ShouldDenyInheritedType_DefaultAdd()
		{
			IList<Type> list = new TypeList<ITestInterface>();

			Action action = () => list.Add(typeof(NoGoodTestClass));
			action.Should().Throw<ArgumentException>();
		}
	}
}
