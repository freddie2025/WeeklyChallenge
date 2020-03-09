namespace MongoDB.UI
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
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.firstNameText = new System.Windows.Forms.TextBox();
			this.emailText = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lastNameText = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.peopleDropDown = new System.Windows.Forms.ComboBox();
			this.peopleLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.phoneNumberText = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(79, 219);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(174, 45);
			this.firstNameLabel.TabIndex = 0;
			this.firstNameLabel.Text = "First Name";
			// 
			// firstNameText
			// 
			this.firstNameText.Location = new System.Drawing.Point(265, 219);
			this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.firstNameText.Name = "firstNameText";
			this.firstNameText.Size = new System.Drawing.Size(480, 50);
			this.firstNameText.TabIndex = 1;
			// 
			// emailText
			// 
			this.emailText.Location = new System.Drawing.Point(265, 339);
			this.emailText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.emailText.Name = "emailText";
			this.emailText.Size = new System.Drawing.Size(480, 50);
			this.emailText.TabIndex = 3;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(79, 339);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(96, 45);
			this.emailLabel.TabIndex = 2;
			this.emailLabel.Text = "Email";
			// 
			// lastNameText
			// 
			this.lastNameText.Location = new System.Drawing.Point(265, 279);
			this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lastNameText.Name = "lastNameText";
			this.lastNameText.Size = new System.Drawing.Size(480, 50);
			this.lastNameText.TabIndex = 5;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(79, 279);
			this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(170, 45);
			this.lastNameLabel.TabIndex = 4;
			this.lastNameLabel.Text = "Last Name";
			// 
			// peopleDropDown
			// 
			this.peopleDropDown.FormattingEnabled = true;
			this.peopleDropDown.Location = new System.Drawing.Point(265, 118);
			this.peopleDropDown.Name = "peopleDropDown";
			this.peopleDropDown.Size = new System.Drawing.Size(480, 53);
			this.peopleDropDown.TabIndex = 6;
			this.peopleDropDown.SelectedIndexChanged += new System.EventHandler(this.PeopleDropDown_SelectedindexChanged);
			// 
			// peopleLabel
			// 
			this.peopleLabel.AutoSize = true;
			this.peopleLabel.Location = new System.Drawing.Point(79, 118);
			this.peopleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.peopleLabel.Name = "peopleLabel";
			this.peopleLabel.Size = new System.Drawing.Size(117, 45);
			this.peopleLabel.TabIndex = 7;
			this.peopleLabel.Text = "People";
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(265, 481);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(480, 76);
			this.submitButton.TabIndex = 8;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// phoneNumberText
			// 
			this.phoneNumberText.Location = new System.Drawing.Point(265, 399);
			this.phoneNumberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.phoneNumberText.Name = "phoneNumberText";
			this.phoneNumberText.Size = new System.Drawing.Size(480, 50);
			this.phoneNumberText.TabIndex = 10;
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(79, 399);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(110, 45);
			this.phoneNumberLabel.TabIndex = 9;
			this.phoneNumberLabel.Text = "Phone";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 645);
			this.Controls.Add(this.phoneNumberText);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.peopleLabel);
			this.Controls.Add(this.peopleDropDown);
			this.Controls.Add(this.lastNameText);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.emailText);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.firstNameText);
			this.Controls.Add(this.firstNameLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Dashboard";
			this.Text = "MongoDB Challenge";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox firstNameText;
		private System.Windows.Forms.TextBox emailText;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox lastNameText;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.ComboBox peopleDropDown;
		private System.Windows.Forms.Label peopleLabel;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.TextBox phoneNumberText;
		private System.Windows.Forms.Label phoneNumberLabel;
	}
}

