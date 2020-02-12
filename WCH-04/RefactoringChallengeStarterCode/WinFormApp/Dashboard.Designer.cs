namespace WinFormApp
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.insertGroup = new System.Windows.Forms.GroupBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.createUserLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.filterUsersLabel = new System.Windows.Forms.Label();
            this.filterUsersText = new System.Windows.Forms.TextBox();
            this.displayGroup = new System.Windows.Forms.GroupBox();
            this.userDisplayList = new System.Windows.Forms.ListBox();
            this.displayUsersLabel = new System.Windows.Forms.Label();
            this.insertGroup.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.displayGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(256, 51);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "System Users";
            // 
            // insertGroup
            // 
            this.insertGroup.Controls.Add(this.createUserButton);
            this.insertGroup.Controls.Add(this.createUserLabel);
            this.insertGroup.Controls.Add(this.lastNameText);
            this.insertGroup.Controls.Add(this.lastNameLabel);
            this.insertGroup.Controls.Add(this.firstNameText);
            this.insertGroup.Controls.Add(this.firstNameLabel);
            this.insertGroup.Location = new System.Drawing.Point(21, 73);
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.Size = new System.Drawing.Size(425, 354);
            this.insertGroup.TabIndex = 1;
            this.insertGroup.TabStop = false;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(76, 244);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(260, 76);
            this.createUserButton.TabIndex = 5;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(11, 36);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(269, 43);
            this.createUserLabel.TabIndex = 4;
            this.createUserLabel.Text = "Create New User";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(171, 177);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(235, 40);
            this.lastNameText.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 180);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(131, 33);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(171, 106);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(235, 40);
            this.firstNameText.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 109);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(134, 33);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.applyFilterButton);
            this.filterGroup.Controls.Add(this.filterUsersLabel);
            this.filterGroup.Controls.Add(this.filterUsersText);
            this.filterGroup.Location = new System.Drawing.Point(21, 450);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(425, 246);
            this.filterGroup.TabIndex = 2;
            this.filterGroup.TabStop = false;
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(76, 152);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(260, 76);
            this.applyFilterButton.TabIndex = 5;
            this.applyFilterButton.Text = "Apply Filter";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // filterUsersLabel
            // 
            this.filterUsersLabel.AutoSize = true;
            this.filterUsersLabel.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterUsersLabel.Location = new System.Drawing.Point(11, 36);
            this.filterUsersLabel.Name = "filterUsersLabel";
            this.filterUsersLabel.Size = new System.Drawing.Size(186, 43);
            this.filterUsersLabel.TabIndex = 4;
            this.filterUsersLabel.Text = "Filter Users";
            // 
            // filterUsersText
            // 
            this.filterUsersText.Location = new System.Drawing.Point(19, 90);
            this.filterUsersText.Name = "filterUsersText";
            this.filterUsersText.Size = new System.Drawing.Size(387, 40);
            this.filterUsersText.TabIndex = 1;
            // 
            // displayGroup
            // 
            this.displayGroup.Controls.Add(this.userDisplayList);
            this.displayGroup.Controls.Add(this.displayUsersLabel);
            this.displayGroup.Location = new System.Drawing.Point(463, 73);
            this.displayGroup.Name = "displayGroup";
            this.displayGroup.Size = new System.Drawing.Size(425, 623);
            this.displayGroup.TabIndex = 3;
            this.displayGroup.TabStop = false;
            // 
            // userDisplayList
            // 
            this.userDisplayList.FormattingEnabled = true;
            this.userDisplayList.ItemHeight = 33;
            this.userDisplayList.Location = new System.Drawing.Point(19, 106);
            this.userDisplayList.Name = "userDisplayList";
            this.userDisplayList.Size = new System.Drawing.Size(386, 499);
            this.userDisplayList.TabIndex = 5;
            // 
            // displayUsersLabel
            // 
            this.displayUsersLabel.AutoSize = true;
            this.displayUsersLabel.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUsersLabel.Location = new System.Drawing.Point(11, 36);
            this.displayUsersLabel.Name = "displayUsersLabel";
            this.displayUsersLabel.Size = new System.Drawing.Size(219, 43);
            this.displayUsersLabel.TabIndex = 4;
            this.displayUsersLabel.Text = "Display Users";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 730);
            this.Controls.Add(this.displayGroup);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.insertGroup);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Dashboard";
            this.Text = "Refactoring Challenge by Tim Corey";
            this.insertGroup.ResumeLayout(false);
            this.insertGroup.PerformLayout();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.displayGroup.ResumeLayout(false);
            this.displayGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox insertGroup;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Label filterUsersLabel;
        private System.Windows.Forms.TextBox filterUsersText;
        private System.Windows.Forms.GroupBox displayGroup;
        private System.Windows.Forms.ListBox userDisplayList;
        private System.Windows.Forms.Label displayUsersLabel;
    }
}

