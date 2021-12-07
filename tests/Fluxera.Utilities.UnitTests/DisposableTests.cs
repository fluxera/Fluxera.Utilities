namespace Fluxera.Utilities.UnitTests
{
	using System;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class DisposableTests
	{
		private class DisposeMe : Disposable
		{
			public bool DisposedManagedObjects { get; set; }

			public bool DisposedUnmanagedObjects { get; set; }

			public bool CheckDisposed()
			{
				return this.IsDisposed;
			}

			/// <inheritdoc />
			protected override void DisposeManaged()
			{
				this.DisposedManagedObjects = true;
				base.DisposeManaged();
			}

			/// <inheritdoc />
			protected override void DisposeUnmanaged()
			{
				this.DisposedUnmanagedObjects = true;
				base.DisposeUnmanaged();
			}

			public void SomeMethod()
			{
				this.AssureNotDisposed();
			}
		}

		[Test]
		public void ShouldDispose()
		{
			// Arrange
			IDisposable disposable = new DisposeMe();

			// Act
			disposable.Dispose();

			// Assert
			((DisposeMe)disposable).CheckDisposed().Should().BeTrue();
			((DisposeMe)disposable).DisposedManagedObjects.Should().BeTrue();
			((DisposeMe)disposable).DisposedUnmanagedObjects.Should().BeTrue();
		}

		[Test]
		public void ShouldThrowWhenAlreadyDisposed()
		{
			// Arrange
			DisposeMe disposable = new DisposeMe();
			using(disposable)
			{
			}

			// Act
			Action action = () => disposable.SomeMethod();

			// Assert
			action.Should().Throw<ObjectDisposedException>();
		}
	}
}
