using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DesktopUI
{
	public partial class Dashboard : Form
	{
		BindingList<string> matchedLines = new BindingList<string>();
		List<string> lines = File.ReadAllLines(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-37\primary.txt").ToList();

		public Dashboard()
		{
			InitializeComponent();

			resultsListBox.DataSource = matchedLines;
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			matchedLines.Clear();

			foreach (var line in lines)
			{
				if (line.IndexOf(textToSearchForText.Text, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					matchedLines.Add(line);
				}
			}
		}

		private void searchForPhoneNumbersButton_Click(object sender, EventArgs e)
		{
			string fileText = File.ReadAllText(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-37\bonus.txt");
			matchedLines.Clear();

			// (123) 456-7890
			Regex regex = new Regex(@" \(([0-9]{3})\) ([0-9]{3})-([0-9]{4}) ");
			MatchCollection matches = regex.Matches(fileText);

			foreach (Match match in matches)
			{
				if (string.IsNullOrWhiteSpace(match.Groups[0].Value) == false)
				{
					matchedLines.Add(match.Groups[0].Value.Trim());
				}
			}
		
		}

		private void textToSearchForText_TextChanged(object sender, EventArgs e)
		{
			if (textToSearchForText.Text.Length < 2)
			{
				return;
			}

			searchButton_Click(sender, e);
		}
	}
}
