// ReSharper disable once CheckNamespace
namespace Fluxera.Collections.Generic
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     A sorted list with elements of type <see ref="T" />.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	[PublicAPI]
	public class SortedList<T> : IList<T>
	{
		private readonly Comparer<T> comparer;
		private readonly List<T> innerList;

		/// <summary>
		///     Creates a new instance of the <see cref="SortedList" /> class.
		/// </summary>
		public SortedList() : this(Comparer<T>.Default) { }

		/// <summary>
		///     Creates a new instance of the <see cref="SortedList" /> class.
		/// </summary>
		/// <param name="comparer">The comparer to use when sorting.</param>
		public SortedList(Comparer<T> comparer)
		{
			this.innerList = new List<T>();
			this.comparer = comparer;
		}

		/// <inheritdoc />
		public int Count => this.innerList.Count;

		/// <inheritdoc />
		public bool IsReadOnly => false;

		/// <inheritdoc />
		public void Add(T item)
		{
			Guard.Against.Null(item, nameof(item));

			int position = this.innerList.BinarySearch(item, this.comparer);
			if (position < 0)
			{
				position = ~position;
			}

			this.innerList.Insert(position, item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			this.innerList.Clear();
		}

		/// <inheritdoc />
		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}

		/// <inheritdoc />
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.innerList.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove(T item)
		{
			int index = this.IndexOf(item);
			if (index >= 0)
			{
				this.innerList.RemoveAt(index);
				return true;
			}

			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <inheritdoc />
		public IEnumerator<T> GetEnumerator()
		{
			return this.innerList.GetEnumerator();
		}

		/// <inheritdoc />
		public T this[int index]
		{
			get => this.innerList[index];
			set => throw new NotSupportedException("Inserting at a specific index is not supported in a sorted list.");
		}

		/// <inheritdoc />
		public int IndexOf(T item)
		{
			int position = this.innerList.BinarySearch(item, this.comparer);
			return position;
		}

		/// <inheritdoc />
		public void Insert(int index, T item)
		{
			throw new NotSupportedException("Inserting at a specific index is not supported in a sorted list.");
		}

		/// <inheritdoc />
		public void RemoveAt(int index)
		{
			this.innerList.RemoveAt(index);
		}
	}
}
