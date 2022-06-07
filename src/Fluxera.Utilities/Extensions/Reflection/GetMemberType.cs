// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;
	using Fluxera.Guards;

	/// <summary>
	///     Extension methods for the <see cref="MemberInfo" /> type.
	/// </summary>
	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Gets the underlying type of the member.
		/// </summary>
		/// <param name="memberInfo">The member information.</param>
		/// <returns>The underlying type of the member.</returns>
		public static Type GetMemberType(this MemberInfo memberInfo)
		{
			Guard.Against.Null(memberInfo, nameof(memberInfo));

			return memberInfo switch
			{
				EventInfo eventInfo => eventInfo.EventHandlerType,
				MethodInfo methodInfo => methodInfo.ReturnType,
				PropertyInfo propertyInfo => propertyInfo.PropertyType,
				FieldInfo fieldInfo => fieldInfo.FieldType,
				_ => throw new ArgumentOutOfRangeException(nameof(memberInfo))
			};
		}
	}
}
