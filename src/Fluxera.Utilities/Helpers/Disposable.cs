// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities
{
	using System;
	using System.Threading.Tasks;
	using JetBrains.Annotations;

	/// <summary>
	///     A base class for disposable objects.
	/// </summary>
	[PublicAPI]
	public abstract class Disposable : IDisposable, IAsyncDisposable
	{
		/// <summary>
		///     Creates a new instance of the <see cref="Disposable" /> type.
		/// </summary>
		protected Disposable()
		{
			this.IsDisposed = false;
		}

		/// <summary>
		///     Gets a value indicating whether this <see cref="Disposable" /> is disposed.
		/// </summary>
		/// <value><c>true</c> if disposed; otherwise <c>false</c>.</value>
		protected bool IsDisposed { get; private set; }

		/// <inheritdoc />
		ValueTask IAsyncDisposable.DisposeAsync()
		{
			try
			{
				// Dispose all managed and unmanaged resources.
				this.Dispose(true);

				return default;
			}
			catch(Exception exception)
			{
				// Take this object off the finalization queue and prevent finalization code for this
				// object from executing a second time.
				GC.SuppressFinalize(this);

				return new ValueTask(Task.FromException(exception));
			}
		}

		/// <summary>
		///     Immediately releases all resources owned by the object.
		///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		void IDisposable.Dispose()
		{
			try
			{
				// Dispose all managed and unmanaged resources.
				this.Dispose(true);
			}
			finally
			{
				// Take this object off the finalization queue and prevent finalization code for this
				// object from executing a second time.
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>
		///     Finalizes an instance of the <see cref="Disposable" /> class. Releases unmanaged
		///     resources and performs other cleanup operations before the <see cref="Disposable" />
		///     is reclaimed by garbage collection. Will run only if the
		///     Dispose method does not get called.
		/// </summary>
		~Disposable()
		{
			try
			{
				this.Dispose(false);
			}
			// ReSharper disable EmptyGeneralCatchClause
			catch
			{
				// Note[mge]: Intentionally left empty.
			}
			// ReSharper restore EmptyGeneralCatchClause
		}

		/// <summary>
		///     Perform finalization of managed objects. The object is being disposed explicitly
		///     and can still access other managed objects it is referencing.
		///     Disposes the managed resources implementing <see cref="IDisposable" />.
		/// </summary>
		protected virtual void DisposeManaged()
		{
		}

		/// <summary>
		///     Perform finalization of unmanaged objects. Other managed objects
		///     may have been destroyed already and mustn't be touched.
		///     Disposes the unmanaged resources implementing <see cref="IDisposable" />.
		/// </summary>
		protected virtual void DisposeUnmanaged()
		{
		}

		/// <summary>
		///     Throws an <see cref="ObjectDisposedException" /> if this object has already been disposed.
		/// </summary>
		/// <exception cref="ObjectDisposedException"></exception>
		protected void AssureNotDisposed()
		{
			if(this.IsDisposed)
			{
				throw new ObjectDisposedException(this.GetType().FullName);
			}
		}

		/// <summary>
		///     Is called when the dispose operation has finished.
		/// </summary>
		protected virtual void OnDisposed()
		{
		}

		/// <summary>
		///     Immediately releases all resources owned by the object.
		/// </summary>
		/// <param name="disposing">
		///     If true, the object is being disposed explicitly and can still access
		///     other managed objects it is referencing. If false, other managed objects
		///     may have been destroyed already and mustn't be touched.
		/// </param>
		private void Dispose(bool disposing)
		{
			// Check to see if Dispose has already been called.
			if(!this.IsDisposed)
			{
				if(disposing)
				{
					// Perform finalization of managed objects.
					this.DisposeManaged();
				}

				// Perform finalization of unmanaged objects.
				this.DisposeUnmanaged();

				this.IsDisposed = true;

				this.OnDisposed();
			}
		}
	}
}
