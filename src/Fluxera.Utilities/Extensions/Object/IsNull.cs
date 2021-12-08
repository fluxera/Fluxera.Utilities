// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using JetBrains.Annotations;

	[PublicAPI]
	public static partial class ObjectExtensions
	{
		/// <summary>
		///     Returns <code>true</code>, if the specified target reference is equal to the null reference.
		///     Otherwise returns <code>false</code>.
		/// </summary>
		/// <param name="target">Target reference. Can be null.</param>
		[ContractAnnotation("null => true")]
		public static bool IsNull(this object? target)
		{
			bool result = target.IsNull<object>();
			return result;
		}

		/// <summary>
		///     Returns <code>true</code>, if the specified target reference is equal to the null reference.
		///     Otherwise returns <code>false</code>.
		/// </summary>
		/// <typeparam name="T">Type of target.</typeparam>
		/// <param name="target">Target reference. Can be null.</param>
		[ContractAnnotation("null => true")]
		public static bool IsNull<T>([NoEnumeration] this T? target) where T : class
		{
			bool result = ReferenceEquals(target, null);
			return result;
		}

		/// <summary>
		///     Returns <code>true</code>, if the specified target reference is not equal to the null reference.
		///     Otherwise returns <code>false</code>.
		/// </summary>
		/// <param name="target">Target reference. Can be null.</param>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNull(this object? target)
		{
			bool result = target.IsNotNull<object>();
			return result;
		}

		/// <summary>
		///     Returns <code>true</code>, if the specified target reference is not equal to the null reference.
		///     Otherwise returns <code>false</code>.
		/// </summary>
		/// <typeparam name="T">Type of target.</typeparam>
		/// <param name="target">Target reference. Can be null.</param>
		[ContractAnnotation("notnull => true")]
		public static bool IsNotNull<T>([NoEnumeration] this T? target) where T : class
		{
			bool result = !target.IsNull();
			return result;
		}
	}
}
