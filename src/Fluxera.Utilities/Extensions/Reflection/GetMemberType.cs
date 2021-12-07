// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;
	using System.Reflection;
	using Guards;

	public static partial class ReflectionExtensions
	{
		/// <summary>
		///     Gets the type of the member.
		/// </summary>
		/// <param name="memberInfo">The member information.</param>
		/// <returns></returns>
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
