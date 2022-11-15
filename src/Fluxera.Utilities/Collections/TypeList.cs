// ReSharper disable once CheckNamespace

namespace Fluxera.Collections.Generic
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Reflection;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A specialized <see cref="IList{T}" /> that enforces a constraint on the
	///     base type of the types to add tio this list.
	/// </summary>
	/// <typeparam name="TBaseType">The base type of the types that can be added to this list.</typeparam>
	[PublicAPI]
	public class TypeList<TBaseType> : ITypeList<TBaseType>
	{
		private readonly List<Type> innerList;

		/// <summary>
		///     Creates a new instance of the <see cref="TypeList{T}" /> type..
		/// </summary>
		public TypeList()
		{
			this.innerList = new List<Type>();
		}

		/// <inheritdoc />
		public IEnumerator<Type> GetEnumerator()
		{
			return this.innerList.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this.innerList).GetEnumerator();
		}

		/// <inheritdoc />
		public void Add(Type item)
		{
			CheckType(item);
			this.innerList.Add(item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			this.innerList.Clear();
		}

		/// <inheritdoc />
		public bool Contains(Type item)
		{
			return this.innerList.Contains(item);
		}

		/// <inheritdoc />
		public void CopyTo(Type[] array, int arrayIndex)
		{
			this.innerList.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove(Type item)
		{
			return this.innerList.Remove(item);
		}

		/// <inheritdoc />
		public int Count => this.innerList.Count;

		/// <inheritdoc />
		public bool IsReadOnly => false;

		/// <inheritdoc />
		public int IndexOf(Type item)
		{
			return this.innerList.IndexOf(item);
		}

		/// <inheritdoc />
		public void Insert(int index, Type item)
		{
			CheckType(item);
			this.innerList.Insert(index, item);
		}

		/// <inheritdoc />
		public void RemoveAt(int index)
		{
			this.innerList.RemoveAt(index);
		}

		/// <inheritdoc />
		public Type this[int index]
		{
			get => this.innerList[index];
			set
			{
				CheckType(value);
				this.innerList[index] = value;
			}
		}

		/// <inheritdoc />
		public void Add<T>() where T : TBaseType
		{
			this.innerList.Add(typeof(T));
		}

		/// <inheritdoc />
		public bool TryAdd<T>() where T : TBaseType
		{
			if(this.Contains<T>())
			{
				return false;
			}

			this.Add<T>();
			return true;
		}

		/// <inheritdoc />
		public bool Contains<T>() where T : TBaseType
		{
			return this.innerList.Contains(typeof(T));
		}

		/// <inheritdoc />
		public void Remove<T>() where T : TBaseType
		{
			this.innerList.Remove(typeof(T));
		}

		private static void CheckType(Type item)
		{
			item = Guard.Against.Null(item);

			if(!typeof(TBaseType).GetTypeInfo().IsAssignableFrom(item))
			{
				throw new ArgumentException($"The type '{item?.Name}' should be assignable to type '{typeof(TBaseType).Name}'.", nameof(item));
			}
		}
	}
}
