// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Threading.Tasks;
	using Guards;
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class TaskExtensions
	{
		public static async void Await(this Task task, Action? successCallback = null, Action<Exception>? exceptionCallback = null)
		{
			Guard.Against.Null(task, nameof(task));

			try
			{
				await task;
				successCallback?.Invoke();
			}
			catch (Exception ex)
			{
				exceptionCallback?.Invoke(ex);
			}
		}

		public static async void Await<T>(this Task<T> task, Action<T>? successCallback = null, Action<Exception>? exceptionCallback = null)
		{
			Guard.Against.Null(task, nameof(task));

			try
			{
				T result = await task;
				successCallback?.Invoke(result);
			}
			catch (Exception ex)
			{
				exceptionCallback?.Invoke(ex);
			}
		}
	}
}
