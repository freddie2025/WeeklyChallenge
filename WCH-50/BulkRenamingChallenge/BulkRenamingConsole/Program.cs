using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace BulkRenamingConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press enter to start...");
			Console.ReadLine();

			// Primary Challenge
			var files = Directory.EnumerateFiles(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-50\BulkFileRenamingChallengeStarterFiles\PrimaryChallengeFiles");

			// file - C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-50\BulkFileRenamingChallengeStarterFiles\PrimaryChallengeFilesacme by acme inc.txt
			// fileName - acme by acme inc
			// filePath - C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-50\BulkFileRenamingChallengeStarterFiles\PrimaryChallengeFiles
			// fileExtension - .txt

			foreach (var file in files)
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				string filePath = Path.GetDirectoryName(file);
				string fileExtension = Path.GetExtension(file);

				string newFileName = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(fileName.ToLower());

				newFileName = newFileName.Replace(" acme ", " FredCo ", StringComparison.InvariantCultureIgnoreCase);

				if (newFileName.StartsWith("acme ", StringComparison.InvariantCultureIgnoreCase))
				{
					newFileName = "FredCo " + newFileName.Substring(5); 
				}

				if (newFileName.EndsWith(" acme", StringComparison.InvariantCultureIgnoreCase))
				{
					newFileName = newFileName.Substring(0, newFileName.Length - 5) + " FredCo";
				}

				File.Move(file, Path.Combine(filePath, newFileName + fileExtension));
			}				
			
			// Bonus Challenge
			var bonusFiles = Directory.EnumerateFiles(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-50\BulkFileRenamingChallengeStarterFiles\BonusChallengeFiles");

			foreach (var file in bonusFiles)
			{
				string filePath = Path.GetDirectoryName(file);
				string fileExtension = Path.GetExtension(file);
				string line1 = File.ReadLines(file).First();

				string newFullNameAndPath = Path.Combine(filePath, line1 + fileExtension);

				File.Move(file, newFullNameAndPath);
			}
		}
	}
}
