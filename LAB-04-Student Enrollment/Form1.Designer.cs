namespace Student_Enrollment
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
            this.DepNameLabel = new System.Windows.Forms.Label();
            this.DepCodelabel = new System.Windows.Forms.Label();
            this.DepNameTextBox = new System.Windows.Forms.TextBox();
            this.DepCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddDepButton = new System.Windows.Forms.Button();
            this.SIdLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.SDepCodeLabel = new System.Windows.Forms.Label();
            this.SectionLabel = new System.Windows.Forms.Label();
            this.SIdTextBox = new System.Windows.Forms.TextBox();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.AdmitButton = new System.Windows.Forms.Button();
            this.SDepCodeComboBox = new System.Windows.Forms.ComboBox();
            this.InfoDepCodelabel = new System.Windows.Forms.Label();
            this.InfoDepCodeComboBox = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowStudentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DepNameLabel
            // 
            this.DepNameLabel.AutoSize = true;
            this.DepNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepNameLabel.Location = new System.Drawing.Point(0, 9);
            this.DepNameLabel.Name = "DepNameLabel";
            this.DepNameLabel.Size = new System.Drawing.Size(155, 20);
            this.DepNameLabel.TabIndex = 0;
            this.DepNameLabel.Text = "Department Name";
            // 
            // DepCodelabel
            // 
            this.DepCodelabel.AutoSize = true;
            this.DepCodelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepCodelabel.Location = new System.Drawing.Point(4, 49);
            this.DepCodelabel.Name = "DepCodelabel";
            this.DepCodelabel.Size = new System.Drawing.Size(151, 20);
            this.DepCodelabel.TabIndex = 1;
            this.DepCodelabel.Text = "Department Code";
            // 
            // DepNameTextBox
            // 
            this.DepNameTextBox.Location = new System.Drawing.Point(185, 9);
            this.DepNameTextBox.Name = "DepNameTextBox";
            this.DepNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepNameTextBox.TabIndex = 2;
            // 
            // DepCodeTextBox
            // 
            this.DepCodeTextBox.Location = new System.Drawing.Point(185, 49);
            this.DepCodeTextBox.Name = "DepCodeTextBox";
            this.DepCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepCodeTextBox.TabIndex = 3;
            // 
            // AddDepButton
            // 
            this.AddDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDepButton.Location = new System.Drawing.Point(79, 91);
            this.AddDepButton.Name = "AddDepButton";
            this.AddDepButton.Size = new System.Drawing.Size(131, 29);
            this.AddDepButton.TabIndex = 4;
            this.AddDepButton.Text = "Add Department";
            this.AddDepButton.UseVisualStyleBackColor = true;
            this.AddDepButton.Click += new System.EventHandler(this.AddDepButton_Click);
            // 
            // SIdLabel
            // 
            this.SIdLabel.AutoSize = true;
            this.SIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIdLabel.Location = new System.Drawing.Point(4, 163);
            this.SIdLabel.Name = "SIdLabel";
            this.SIdLabel.Size = new System.Drawing.Size(97, 20);
            this.SIdLabel.TabIndex = 5;
            this.SIdLabel.Text = "Student ID";
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLabel.Location = new System.Drawing.Point(4, 197);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(55, 20);
            this.SNameLabel.TabIndex = 6;
            this.SNameLabel.Text = "Name";
            // 
            // SDepCodeLabel
            // 
            this.SDepCodeLabel.AutoSize = true;
            this.SDepCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDepCodeLabel.Location = new System.Drawing.Point(4, 237);
            this.SDepCodeLabel.Name = "SDepCodeLabel";
            this.SDepCodeLabel.Size = new System.Drawing.Size(151, 20);
            this.SDepCodeLabel.TabIndex = 7;
            this.SDepCodeLabel.Text = "Department Code";
            // 
            // SectionLabel
            // 
            this.SectionLabel.AutoSize = true;
            this.SectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionLabel.Location = new System.Drawing.Point(4, 278);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(70, 20);
            this.SectionLabel.TabIndex = 8;
            this.SectionLabel.Text = "Section";
            // 
            // SIdTextBox
            // 
            this.SIdTextBox.Location = new System.Drawing.Point(185, 163);
            this.SIdTextBox.Name = "SIdTextBox";
            this.SIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.SIdTextBox.TabIndex = 9;
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(185, 197);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SNameTextBox.TabIndex = 10;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Location = new System.Drawing.Point(185, 278);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.SectionTextBox.TabIndex = 12;
            // 
            // AdmitButton
            // 
            this.AdmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmitButton.Location = new System.Drawing.Point(79, 331);
            this.AdmitButton.Name = "AdmitButton";
            this.AdmitButton.Size = new System.Drawing.Size(131, 29);
            this.AdmitButton.TabIndex = 13;
            this.AdmitButton.Text = "Admit Student";
            this.AdmitButton.UseVisualStyleBackColor = true;
            this.AdmitButton.Click += new System.EventHandler(this.AdmitButton_Click);
            // 
            // SDepCodeComboBox
            // 
            this.SDepCodeComboBox.FormattingEnabled = true;
            this.SDepCodeComboBox.Location = new System.Drawing.Point(185, 236);
            this.SDepCodeComboBox.Name = "SDepCodeComboBox";
            this.SDepCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.SDepCodeComboBox.TabIndex = 14;
            // 
            // InfoDepCodelabel
            // 
            this.InfoDepCodelabel.AutoSize = true;
            this.InfoDepCodelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoDepCodelabel.Location = new System.Drawing.Point(420, 47);
            this.InfoDepCodelabel.Name = "InfoDepCodelabel";
            this.InfoDepCodelabel.Size = new System.Drawing.Size(151, 20);
            this.InfoDepCodelabel.TabIndex = 15;
            this.InfoDepCodelabel.Text = "Department Code";
            // 
            // InfoDepCodeComboBox
            // 
            this.InfoDepCodeComboBox.FormattingEnabled = true;
            this.InfoDepCodeComboBox.Location = new System.Drawing.Point(605, 47);
            this.InfoDepCodeComboBox.Name = "InfoDepCodeComboBox";
            this.InfoDepCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.InfoDepCodeComboBox.TabIndex = 16;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(605, 91);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(131, 29);
            this.ShowButton.TabIndex = 17;
            this.ShowButton.Text = "Show Student";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowStudentsListBox
            // 
            this.ShowStudentsListBox.FormattingEnabled = true;
            this.ShowStudentsListBox.Location = new System.Drawing.Point(424, 162);
            this.ShowStudentsListBox.Name = "ShowStudentsListBox";
            this.ShowStudentsListBox.Size = new System.Drawing.Size(312, 147);
            this.ShowStudentsListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowStudentsListBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.InfoDepCodeComboBox);
            this.Controls.Add(this.InfoDepCodelabel);
            this.Controls.Add(this.SDepCodeComboBox);
            this.Controls.Add(this.AdmitButton);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.SIdTextBox);
            this.Controls.Add(this.SectionLabel);
            this.Controls.Add(this.SDepCodeLabel);
            this.Controls.Add(this.SNameLabel);
            this.Controls.Add(this.SIdLabel);
            this.Controls.Add(this.AddDepButton);
            this.Controls.Add(this.DepCodeTextBox);
            this.Controls.Add(this.DepNameTextBox);
            this.Controls.Add(this.DepCodelabel);
            this.Controls.Add(this.DepNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepNameLabel;
        private System.Windows.Forms.Label DepCodelabel;
        private System.Windows.Forms.TextBox DepNameTextBox;
        private System.Windows.Forms.TextBox DepCodeTextBox;
        private System.Windows.Forms.Button AddDepButton;
        private System.Windows.Forms.Label SIdLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label SDepCodeLabel;
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.TextBox SIdTextBox;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.Button AdmitButton;
        private System.Windows.Forms.ComboBox SDepCodeComboBox;
        private System.Windows.Forms.Label InfoDepCodelabel;
        private System.Windows.Forms.ComboBox InfoDepCodeComboBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListBox ShowStudentsListBox;
    }
}

