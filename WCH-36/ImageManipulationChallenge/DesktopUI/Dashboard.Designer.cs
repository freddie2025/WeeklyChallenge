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
			this.selectedFileLabel = new System.Windows.Forms.Label();
			this.selectedFileName = new System.Windows.Forms.TextBox();
			this.selectFileButton = new System.Windows.Forms.Button();
			this.newFileName = new System.Windows.Forms.TextBox();
			this.newFileNameLabel = new System.Windows.Forms.Label();
			this.newFileTypeLabel = new System.Windows.Forms.Label();
			this.newFileTypeDropDown = new System.Windows.Forms.ComboBox();
			this.processChange = new System.Windows.Forms.Button();
			this.resizeImageCheckBox = new System.Windows.Forms.CheckBox();
			this.resizeImageLabel = new System.Windows.Forms.Label();
			this.newImageSizeDropDown = new System.Windows.Forms.ComboBox();
			this.imageSizeLabel = new System.Windows.Forms.Label();
			this.widthText = new System.Windows.Forms.TextBox();
			this.heightText = new System.Windows.Forms.TextBox();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// selectedFileLabel
			// 
			this.selectedFileLabel.AutoSize = true;
			this.selectedFileLabel.Location = new System.Drawing.Point(12, 18);
			this.selectedFileLabel.Name = "selectedFileLabel";
			this.selectedFileLabel.Size = new System.Drawing.Size(71, 13);
			this.selectedFileLabel.TabIndex = 0;
			this.selectedFileLabel.Text = "Selected File";
			// 
			// selectedFileName
			// 
			this.selectedFileName.Location = new System.Drawing.Point(101, 18);
			this.selectedFileName.Name = "selectedFileName";
			this.selectedFileName.Size = new System.Drawing.Size(287, 22);
			this.selectedFileName.TabIndex = 1;
			// 
			// selectFileButton
			// 
			this.selectFileButton.Location = new System.Drawing.Point(394, 18);
			this.selectFileButton.Name = "selectFileButton";
			this.selectFileButton.Size = new System.Drawing.Size(29, 23);
			this.selectFileButton.TabIndex = 2;
			this.selectFileButton.Text = "...";
			this.selectFileButton.UseVisualStyleBackColor = true;
			this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
			// 
			// newFileName
			// 
			this.newFileName.Location = new System.Drawing.Point(101, 46);
			this.newFileName.Name = "newFileName";
			this.newFileName.Size = new System.Drawing.Size(287, 22);
			this.newFileName.TabIndex = 4;
			// 
			// newFileNameLabel
			// 
			this.newFileNameLabel.AutoSize = true;
			this.newFileNameLabel.Location = new System.Drawing.Point(12, 46);
			this.newFileNameLabel.Name = "newFileNameLabel";
			this.newFileNameLabel.Size = new System.Drawing.Size(83, 13);
			this.newFileNameLabel.TabIndex = 3;
			this.newFileNameLabel.Text = "New File Name";
			// 
			// newFileTypeLabel
			// 
			this.newFileTypeLabel.AutoSize = true;
			this.newFileTypeLabel.Location = new System.Drawing.Point(12, 74);
			this.newFileTypeLabel.Name = "newFileTypeLabel";
			this.newFileTypeLabel.Size = new System.Drawing.Size(77, 13);
			this.newFileTypeLabel.TabIndex = 5;
			this.newFileTypeLabel.Text = "New File Type";
			// 
			// newFileTypeDropDown
			// 
			this.newFileTypeDropDown.FormattingEnabled = true;
			this.newFileTypeDropDown.Location = new System.Drawing.Point(101, 74);
			this.newFileTypeDropDown.Name = "newFileTypeDropDown";
			this.newFileTypeDropDown.Size = new System.Drawing.Size(287, 21);
			this.newFileTypeDropDown.TabIndex = 7;
			// 
			// processChange
			// 
			this.processChange.Location = new System.Drawing.Point(101, 195);
			this.processChange.Name = "processChange";
			this.processChange.Size = new System.Drawing.Size(287, 40);
			this.processChange.TabIndex = 8;
			this.processChange.Text = "Process";
			this.processChange.UseVisualStyleBackColor = true;
			this.processChange.Click += new System.EventHandler(this.processChange_Click);
			// 
			// resizeImageCheckBox
			// 
			this.resizeImageCheckBox.AutoSize = true;
			this.resizeImageCheckBox.Location = new System.Drawing.Point(101, 103);
			this.resizeImageCheckBox.Name = "resizeImageCheckBox";
			this.resizeImageCheckBox.Size = new System.Drawing.Size(15, 14);
			this.resizeImageCheckBox.TabIndex = 9;
			this.resizeImageCheckBox.UseVisualStyleBackColor = true;
			// 
			// resizeImageLabel
			// 
			this.resizeImageLabel.AutoSize = true;
			this.resizeImageLabel.Location = new System.Drawing.Point(12, 103);
			this.resizeImageLabel.Name = "resizeImageLabel";
			this.resizeImageLabel.Size = new System.Drawing.Size(73, 13);
			this.resizeImageLabel.TabIndex = 10;
			this.resizeImageLabel.Text = "Resize Image";
			// 
			// newImageSizeDropDown
			// 
			this.newImageSizeDropDown.FormattingEnabled = true;
			this.newImageSizeDropDown.Location = new System.Drawing.Point(101, 128);
			this.newImageSizeDropDown.Name = "newImageSizeDropDown";
			this.newImageSizeDropDown.Size = new System.Drawing.Size(287, 21);
			this.newImageSizeDropDown.TabIndex = 12;
			this.newImageSizeDropDown.SelectedIndexChanged += new System.EventHandler(this.newImageSizeDropDown_SelectedIndexChanged);
			// 
			// imageSizeLabel
			// 
			this.imageSizeLabel.AutoSize = true;
			this.imageSizeLabel.Location = new System.Drawing.Point(12, 131);
			this.imageSizeLabel.Name = "imageSizeLabel";
			this.imageSizeLabel.Size = new System.Drawing.Size(61, 13);
			this.imageSizeLabel.TabIndex = 11;
			this.imageSizeLabel.Text = "Image Size";
			// 
			// widthText
			// 
			this.widthText.Location = new System.Drawing.Point(129, 155);
			this.widthText.Name = "widthText";
			this.widthText.Size = new System.Drawing.Size(110, 22);
			this.widthText.TabIndex = 13;
			// 
			// heightText
			// 
			this.heightText.Location = new System.Drawing.Point(278, 155);
			this.heightText.Name = "heightText";
			this.heightText.Size = new System.Drawing.Size(110, 22);
			this.heightText.TabIndex = 14;
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(102, 158);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(21, 13);
			this.widthLabel.TabIndex = 15;
			this.widthLabel.Text = "W:";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(254, 158);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(18, 13);
			this.heightLabel.TabIndex = 16;
			this.heightLabel.Text = "H:";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 247);
			this.Controls.Add(this.heightLabel);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.heightText);
			this.Controls.Add(this.widthText);
			this.Controls.Add(this.newImageSizeDropDown);
			this.Controls.Add(this.imageSizeLabel);
			this.Controls.Add(this.resizeImageLabel);
			this.Controls.Add(this.resizeImageCheckBox);
			this.Controls.Add(this.processChange);
			this.Controls.Add(this.newFileTypeDropDown);
			this.Controls.Add(this.newFileTypeLabel);
			this.Controls.Add(this.newFileName);
			this.Controls.Add(this.newFileNameLabel);
			this.Controls.Add(this.selectFileButton);
			this.Controls.Add(this.selectedFileName);
			this.Controls.Add(this.selectedFileLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Dashboard";
			this.Text = "Image Manipulator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label selectedFileLabel;
		private System.Windows.Forms.TextBox selectedFileName;
		private System.Windows.Forms.Button selectFileButton;
		private System.Windows.Forms.TextBox newFileName;
		private System.Windows.Forms.Label newFileNameLabel;
		private System.Windows.Forms.Label newFileTypeLabel;
		private System.Windows.Forms.ComboBox newFileTypeDropDown;
		private System.Windows.Forms.Button processChange;
		private System.Windows.Forms.CheckBox resizeImageCheckBox;
		private System.Windows.Forms.Label resizeImageLabel;
		private System.Windows.Forms.ComboBox newImageSizeDropDown;
		private System.Windows.Forms.Label imageSizeLabel;
		private System.Windows.Forms.TextBox widthText;
		private System.Windows.Forms.TextBox heightText;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
	}
}

