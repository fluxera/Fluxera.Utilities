// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Reflection;

	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Determines if the given property is an indexer.
		/// </summary>
		/// <param name="property">The whole property to check.</param>
		/// <returns><c>true</c> if it's an indexer, <c>false</c> if it's not an indexer.</returns>
		public static bool IsIndexer(this PropertyInfo property)
		{
			return property.GetIndexParameters().Length > 0;
		}
	}
}
