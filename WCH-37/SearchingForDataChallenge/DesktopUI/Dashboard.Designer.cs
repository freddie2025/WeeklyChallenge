namespace DesktopUI
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textToSearchForLabel = new System.Windows.Forms.Label();
			this.textToSearchForText = new System.Windows.Forms.TextBox();
			this.resultsListBox = new System.Windows.Forms.ListBox();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchForPhoneNumbersButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textToSearchForLabel
			// 
			this.textToSearchForLabel.AutoSize = true;
			this.textToSearchForLabel.Location = new System.Drawing.Point(12, 21);
			this.textToSearchForLabel.Name = "textToSearchForLabel";
			this.textToSearchForLabel.Size = new System.Drawing.Size(61, 13);
			this.textToSearchForLabel.TabIndex = 0;
			this.textToSearchForLabel.Text = "Search For";
			// 
			// textToSearchForText
			// 
			this.textToSearchForText.Location = new System.Drawing.Point(79, 18);
			this.textToSearchForText.Name = "textToSearchForText";
			this.textToSearchForText.Size = new System.Drawing.Size(264, 21);
			this.textToSearchForText.TabIndex = 1;
			this.textToSearchForText.TextChanged += new System.EventHandler(this.textToSearchForText_TextChanged);
			// 
			// resultsListBox
			// 
			this.resultsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsListBox.FormattingEnabled = true;
			this.resultsListBox.ItemHeight = 15;
			this.resultsListBox.Location = new System.Drawing.Point(15, 93);
			this.resultsListBox.Name = "resultsListBox";
			this.resultsListBox.Size = new System.Drawing.Size(797, 259);
			this.resultsListBox.TabIndex = 2;
			// 
			// resultsLabel
			// 
			this.resultsLabel.AutoSize = true;
			this.resultsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsLabel.Location = new System.Drawing.Point(12, 65);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(56, 20);
			this.resultsLabel.TabIndex = 3;
			this.resultsLabel.Text = "Results";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(349, 16);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 4;
			this.searchButton.Text = "Search Text";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchForPhoneNumbersButton
			// 
			this.searchForPhoneNumbersButton.Location = new System.Drawing.Point(430, 16);
			this.searchForPhoneNumbersButton.Name = "searchForPhoneNumbersButton";
			this.searchForPhoneNumbersButton.Size = new System.Drawing.Size(159, 23);
			this.searchForPhoneNumbersButton.TabIndex = 5;
			this.searchForPhoneNumbersButton.Text = "Search For Phone Numbers";
			this.searchForPhoneNumbersButton.UseVisualStyleBackColor = true;
			this.searchForPhoneNumbersButton.Click += new System.EventHandler(this.searchForPhoneNumbersButton_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 391);
			this.Controls.Add(this.searchForPhoneNumbersButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.resultsListBox);
			this.Controls.Add(this.textToSearchForText);
			this.Controls.Add(this.textToSearchForLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(840, 430);
			this.MinimumSize = new System.Drawing.Size(840, 430);
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Searching For Data Challenge";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label textToSearchForLabel;
		private System.Windows.Forms.TextBox textToSearchForText;
		private System.Windows.Forms.ListBox resultsListBox;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button searchForPhoneNumbersButton;
	}
}

