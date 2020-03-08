using CalculationsLibrary;
using Moq;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CalculatorLibrary.Test
{
	public class TextDataAccess_Tests
	{
		[Fact]
		public void SaveText_Normal()
		{
			List<string> lines = new List<string>
			{
				"Test one",
				"Test 2",
				"Test III"
			};

			string filePath = @"C:\Temp\Test.txt";
			string fileName = "Test.txt";

			var mock = new Mock<IWriteToText>();

			mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

			TextDataAccess dataAccess = new TextDataAccess();

			dataAccess.SaveText(filePath, lines, mock.Object);

			mock.Verify();
		}

		[Fact]
		public void SaveText_InvalidPathShouldThrowException()
		{
			List<string> lines = new List<string>
			{
				"Test one",
				"Test 2",
				"Test III"
			};

			string filePath = @"C:\Temp\Testendkjnewdjnwekdjnwkendwkjendkjwnedkjwnedkjwnedkjnwekdjnfvnkjtnrtnkrnvkjernvkjwnefnwefnwjenfkjwkjervkjnrkjvnekjrvbkwjenfkjwne
			jrbfkwrfkjbekrjfbekrbfkerfkebrfberfbehrbktnbmeprnvwnvwnowirnvpwmboientoivnernvoiwrncoiwnvoierpvowpfvbeoubvbeorivnworinvowrinvoiwrnvoiwnrviowrvniowrnvoiwrvwi
			jwnrfonworivnwoirnvoienrvoineworvneoinvoienvoienvoineorivnowirmfpoqke[fompevineonburbnoeirmgpowgviwnepfomqpeofmcwpoefmotibnoeinvwimcxwmewcwerneoirvnowiernvo
			iernviernnowirnv.txt";
			string fileName = "Test.txt";

			var mock = new Mock<IWriteToText>();

			mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

			TextDataAccess dataAccess = new TextDataAccess();

			Assert.Throws<PathTooLongException>(
				() => dataAccess.SaveText(filePath, lines, mock.Object));
		}
	}
}
