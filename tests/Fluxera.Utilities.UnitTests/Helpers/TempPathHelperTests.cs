namespace Fluxera.Utilities.UnitTests.Helpers
{
	using System.IO;
	using FluentAssertions;
	using NUnit.Framework;

	[TestFixture]
	public class TempPathHelperTests
	{
		[Test]
		public void ShouldCreateTempFile()
		{
			string tempFileName = TempPathHelper.CreateTempFile();
			tempFileName.Should().NotBeNullOrWhiteSpace();
			tempFileName.Should().EndWith(".tmp");

			bool exists = File.Exists(tempFileName);
			exists.Should().BeTrue();
		}

		[Test]
		public void ShouldCreateTempFileWithCustomExtension()
		{
			string tempFileName = TempPathHelper.CreateTempFile(".pdf");
			tempFileName.Should().NotBeNullOrWhiteSpace();
			tempFileName.Should().EndWith(".pdf");

			bool exists = File.Exists(tempFileName);
			exists.Should().BeTrue();
		}

		[Test]
		public void ShouldCreateTempFileWithCustomExtensionWithoutLeadingDot()
		{
			string tempFileName = TempPathHelper.CreateTempFile("xml");
			tempFileName.Should().NotBeNullOrWhiteSpace();
			tempFileName.Should().EndWith(".xml");

			bool exists = File.Exists(tempFileName);
			exists.Should().BeTrue();
		}

		[Test]
		public void ShouldCreateTempFolder()
		{
			string tempFolderName = TempPathHelper.CreateTempFolder();
			tempFolderName.Should().NotBeNullOrWhiteSpace();

			bool exists = Directory.Exists(tempFolderName);
			exists.Should().BeTrue();
		}
	}
}
