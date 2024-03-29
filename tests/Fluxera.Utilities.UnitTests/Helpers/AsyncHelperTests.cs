﻿namespace Fluxera.Utilities.UnitTests.Helpers
{
	using System.Reflection;
	using System.Threading.Tasks;
	using FluentAssertions;
	using JetBrains.Annotations;
	using NUnit.Framework;

	[TestFixture]
	public class AsyncHelperTests
	{
		private static async Task TaskWithoutReturnValueAsync()
		{
			await Task.Delay(1);
		}

		private static async Task<int> TaskWithReturnValueAsync(int aNumber)
		{
			await Task.Delay(1);
			return aNumber;
		}

		[UsedImplicitly]
		private int MethodWithReturnValue(int aNumber)
		{
			return aNumber;
		}

		[Test]
		public void ShouldBeFalseForNonAsyncMethod()
		{
			this.GetType().GetMethod(
				"MethodWithReturnValue",
				BindingFlags.NonPublic | BindingFlags.Instance
			).IsAsync().Should().Be(false);
		}

		[Test]
		public void ShouldBeTrueForAsyncMethods()
		{
			this.GetType().GetMethod(
				"TaskWithoutReturnValueAsync",
				BindingFlags.NonPublic | BindingFlags.Static
			).IsAsync().Should().Be(true);

			this.GetType().GetMethod(
				"TaskWithReturnValueAsync",
				BindingFlags.NonPublic | BindingFlags.Static
			).IsAsync().Should().Be(true);

			this.GetType().GetMethod(
				"MethodWithReturnValue",
				BindingFlags.NonPublic | BindingFlags.Instance
			).IsAsync().Should().Be(false);
		}

		[Test]
		public void ShouldDoNothingForRunSyncWithoutReturnValue()
		{
			AsyncHelper.RunSync(TaskWithoutReturnValueAsync);
		}

		[Test]
		public void ShouldDoNothingForRunSyncWithReturnValue()
		{
			AsyncHelper.RunSync(() => TaskWithReturnValueAsync(42)).Should().Be(42);
		}
	}
}
