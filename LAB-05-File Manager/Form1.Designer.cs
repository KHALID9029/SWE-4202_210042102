namespace File_Manager
{
    partial class Form1
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileContentLabel = new System.Windows.Forms.Label();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileContentTextBox = new System.Windows.Forms.TextBox();
            this.FileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.RFileNameTextBox = new System.Windows.Forms.TextBox();
            this.RFileNameLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UFileNameTextBox = new System.Windows.Forms.TextBox();
            this.UFileNameLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ShowContentLabel = new System.Windows.Forms.Label();
            this.ShowContentListBox = new System.Windows.Forms.ListBox();
            this.NewContentTextBox = new System.Windows.Forms.TextBox();
            this.NewContentLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.VFileNameTextBox = new System.Windows.Forms.TextBox();
            this.VFileNameLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ContentListBox = new System.Windows.Forms.ListBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.AllowedFeaturesListBox = new System.Windows.Forms.ListBox();
            this.AllowedFeaturesLabel = new System.Windows.Forms.Label();
            this.ShowSummaryButton = new System.Windows.Forms.Button();
            this.TotalFileLabel = new System.Windows.Forms.Label();
            this.TotalMemoryLabel = new System.Windows.Forms.Label();
            this.FileListLabel = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(99, 20);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name :";
            this.FileNameLabel.Click += new System.EventHandler(this.FileNameLabel_Click);
            // 
            // FileContentLabel
            // 
            this.FileContentLabel.AutoSize = true;
            this.FileContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileContentLabel.Location = new System.Drawing.Point(0, 64);
            this.FileContentLabel.Name = "FileContentLabel";
            this.FileContentLabel.Size = new System.Drawing.Size(117, 20);
            this.FileContentLabel.TabIndex = 1;
            this.FileContentLabel.Text = "File Content :";
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTypeLabel.Location = new System.Drawing.Point(0, 33);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(91, 20);
            this.FileTypeLabel.TabIndex = 2;
            this.FileTypeLabel.Text = "File Type :";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameTextBox.Location = new System.Drawing.Point(140, 0);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FileNameTextBox.TabIndex = 3;
            // 
            // FileContentTextBox
            // 
            this.FileContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileContentTextBox.Location = new System.Drawing.Point(140, 64);
            this.FileContentTextBox.Name = "FileContentTextBox";
            this.FileContentTextBox.Size = new System.Drawing.Size(100, 22);
            this.FileContentTextBox.TabIndex = 4;
            // 
            // FileTypeComboBox
            // 
            this.FileTypeComboBox.FormattingEnabled = true;
            this.FileTypeComboBox.Items.AddRange(new object[] {
            "Read Only",
            "Editable"});
            this.FileTypeComboBox.Location = new System.Drawing.Point(140, 32);
            this.FileTypeComboBox.Name = "FileTypeComboBox";
            this.FileTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.FileTypeComboBox.TabIndex = 5;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton.Location = new System.Drawing.Point(140, 101);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(100, 26);
            this.AddFileButton.TabIndex = 6;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // RFileNameTextBox
            // 
            this.RFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFileNameTextBox.Location = new System.Drawing.Point(140, 140);
            this.RFileNameTextBox.Name = "RFileNameTextBox";
            this.RFileNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.RFileNameTextBox.TabIndex = 8;
            // 
            // RFileNameLabel
            // 
            this.RFileNameLabel.AutoSize = true;
            this.RFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFileNameLabel.Location = new System.Drawing.Point(0, 140);
            this.RFileNameLabel.Name = "RFileNameLabel";
            this.RFileNameLabel.Size = new System.Drawing.Size(99, 20);
            this.RFileNameLabel.TabIndex = 7;
            this.RFileNameLabel.Text = "File Name :";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(140, 184);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 26);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UFileNameTextBox
            // 
            this.UFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFileNameTextBox.Location = new System.Drawing.Point(140, 230);
            this.UFileNameTextBox.Name = "UFileNameTextBox";
            this.UFileNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.UFileNameTextBox.TabIndex = 11;
            // 
            // UFileNameLabel
            // 
            this.UFileNameLabel.AutoSize = true;
            this.UFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFileNameLabel.Location = new System.Drawing.Point(0, 230);
            this.UFileNameLabel.Name = "UFileNameLabel";
            this.UFileNameLabel.Size = new System.Drawing.Size(99, 20);
            this.UFileNameLabel.TabIndex = 10;
            this.UFileNameLabel.Text = "File Name :";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(140, 268);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 26);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShowContentLabel
            // 
            this.ShowContentLabel.AutoSize = true;
            this.ShowContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowContentLabel.Location = new System.Drawing.Point(0, 314);
            this.ShowContentLabel.Name = "ShowContentLabel";
            this.ShowContentLabel.Size = new System.Drawing.Size(122, 20);
            this.ShowContentLabel.TabIndex = 13;
            this.ShowContentLabel.Text = "Show Content";
            // 
            // ShowContentListBox
            // 
            this.ShowContentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowContentListBox.FormattingEnabled = true;
            this.ShowContentListBox.ItemHeight = 20;
            this.ShowContentListBox.Location = new System.Drawing.Point(140, 314);
            this.ShowContentListBox.Name = "ShowContentListBox";
            this.ShowContentListBox.Size = new System.Drawing.Size(194, 24);
            this.ShowContentListBox.TabIndex = 14;
            // 
            // NewContentTextBox
            // 
            this.NewContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContentTextBox.Location = new System.Drawing.Point(140, 357);
            this.NewContentTextBox.Name = "NewContentTextBox";
            this.NewContentTextBox.Size = new System.Drawing.Size(194, 22);
            this.NewContentTextBox.TabIndex = 16;
            // 
            // NewContentLabel
            // 
            this.NewContentLabel.AutoSize = true;
            this.NewContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContentLabel.Location = new System.Drawing.Point(0, 357);
            this.NewContentLabel.Name = "NewContentLabel";
            this.NewContentLabel.Size = new System.Drawing.Size(112, 20);
            this.NewContentLabel.TabIndex = 15;
            this.NewContentLabel.Text = "New Content";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(140, 401);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 26);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VFileNameTextBox
            // 
            this.VFileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VFileNameTextBox.Location = new System.Drawing.Point(600, 9);
            this.VFileNameTextBox.Name = "VFileNameTextBox";
            this.VFileNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.VFileNameTextBox.TabIndex = 19;
            // 
            // VFileNameLabel
            // 
            this.VFileNameLabel.AutoSize = true;
            this.VFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VFileNameLabel.Location = new System.Drawing.Point(434, 9);
            this.VFileNameLabel.Name = "VFileNameLabel";
            this.VFileNameLabel.Size = new System.Drawing.Size(99, 20);
            this.VFileNameLabel.TabIndex = 18;
            this.VFileNameLabel.Text = "File Name :";
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(600, 46);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(100, 26);
            this.ViewButton.TabIndex = 20;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ContentListBox
            // 
            this.ContentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentListBox.FormattingEnabled = true;
            this.ContentListBox.ItemHeight = 20;
            this.ContentListBox.Location = new System.Drawing.Point(600, 103);
            this.ContentListBox.Name = "ContentListBox";
            this.ContentListBox.Size = new System.Drawing.Size(194, 24);
            this.ContentListBox.TabIndex = 22;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(434, 101);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(73, 20);
            this.ContentLabel.TabIndex = 21;
            this.ContentLabel.Text = "Content";
            // 
            // AllowedFeaturesListBox
            // 
            this.AllowedFeaturesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowedFeaturesListBox.FormattingEnabled = true;
            this.AllowedFeaturesListBox.ItemHeight = 20;
            this.AllowedFeaturesListBox.Location = new System.Drawing.Point(600, 140);
            this.AllowedFeaturesListBox.Name = "AllowedFeaturesListBox";
            this.AllowedFeaturesListBox.Size = new System.Drawing.Size(194, 84);
            this.AllowedFeaturesListBox.TabIndex = 24;
            // 
            // AllowedFeaturesLabel
            // 
            this.AllowedFeaturesLabel.AutoSize = true;
            this.AllowedFeaturesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowedFeaturesLabel.Location = new System.Drawing.Point(434, 140);
            this.AllowedFeaturesLabel.Name = "AllowedFeaturesLabel";
            this.AllowedFeaturesLabel.Size = new System.Drawing.Size(148, 20);
            this.AllowedFeaturesLabel.TabIndex = 23;
            this.AllowedFeaturesLabel.Text = "Allowed Features";
            // 
            // ShowSummaryButton
            // 
            this.ShowSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSummaryButton.Location = new System.Drawing.Point(438, 230);
            this.ShowSummaryButton.Name = "ShowSummaryButton";
            this.ShowSummaryButton.Size = new System.Drawing.Size(163, 26);
            this.ShowSummaryButton.TabIndex = 25;
            this.ShowSummaryButton.Text = "Show Summary";
            this.ShowSummaryButton.UseVisualStyleBackColor = true;
            this.ShowSummaryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalFileLabel
            // 
            this.TotalFileLabel.AutoSize = true;
            this.TotalFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFileLabel.Location = new System.Drawing.Point(383, 274);
            this.TotalFileLabel.Name = "TotalFileLabel";
            this.TotalFileLabel.Size = new System.Drawing.Size(93, 20);
            this.TotalFileLabel.TabIndex = 26;
            this.TotalFileLabel.Text = "Total File :";
            // 
            // TotalMemoryLabel
            // 
            this.TotalMemoryLabel.AutoSize = true;
            this.TotalMemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemoryLabel.Location = new System.Drawing.Point(523, 274);
            this.TotalMemoryLabel.Name = "TotalMemoryLabel";
            this.TotalMemoryLabel.Size = new System.Drawing.Size(206, 20);
            this.TotalMemoryLabel.TabIndex = 27;
            this.TotalMemoryLabel.Text = "Total Occupied Memory :";
            // 
            // FileListLabel
            // 
            this.FileListLabel.AutoSize = true;
            this.FileListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileListLabel.Location = new System.Drawing.Point(510, 314);
            this.FileListLabel.Name = "FileListLabel";
            this.FileListLabel.Size = new System.Drawing.Size(105, 20);
            this.FileListLabel.TabIndex = 28;
            this.FileListLabel.Text = "List Of Files";
            this.FileListLabel.Click += new System.EventHandler(this.FileListLabel_Click);
            // 
            // FileListBox
            // 
            this.FileListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 20;
            this.FileListBox.Location = new System.Drawing.Point(429, 337);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(284, 104);
            this.FileListBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.FileListLabel);
            this.Controls.Add(this.TotalMemoryLabel);
            this.Controls.Add(this.TotalFileLabel);
            this.Controls.Add(this.ShowSummaryButton);
            this.Controls.Add(this.AllowedFeaturesListBox);
            this.Controls.Add(this.AllowedFeaturesLabel);
            this.Controls.Add(this.ContentListBox);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.VFileNameTextBox);
            this.Controls.Add(this.VFileNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewContentTextBox);
            this.Controls.Add(this.NewContentLabel);
            this.Controls.Add(this.ShowContentListBox);
            this.Controls.Add(this.ShowContentLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UFileNameTextBox);
            this.Controls.Add(this.UFileNameLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RFileNameTextBox);
            this.Controls.Add(this.RFileNameLabel);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.FileTypeComboBox);
            this.Controls.Add(this.FileContentTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.FileContentLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileContentLabel;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox FileContentTextBox;
        private System.Windows.Forms.ComboBox FileTypeComboBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.TextBox RFileNameTextBox;
        private System.Windows.Forms.Label RFileNameLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox UFileNameTextBox;
        private System.Windows.Forms.Label UFileNameLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label ShowContentLabel;
        private System.Windows.Forms.ListBox ShowContentListBox;
        private System.Windows.Forms.TextBox NewContentTextBox;
        private System.Windows.Forms.Label NewContentLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox VFileNameTextBox;
        private System.Windows.Forms.Label VFileNameLabel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ListBox ContentListBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.ListBox AllowedFeaturesListBox;
        private System.Windows.Forms.Label AllowedFeaturesLabel;
        private System.Windows.Forms.Button ShowSummaryButton;
        private System.Windows.Forms.Label TotalFileLabel;
        private System.Windows.Forms.Label TotalMemoryLabel;
        private System.Windows.Forms.Label FileListLabel;
        private System.Windows.Forms.ListBox FileListBox;
    }
}

