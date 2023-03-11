namespace Lab_03_Banking_System
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
            this.AccNoLabel = new System.Windows.Forms.Label();
            this.ShowAccNoLabel = new System.Windows.Forms.Label();
            this.IniDepLabel = new System.Windows.Forms.Label();
            this.AccTypeLabel = new System.Windows.Forms.Label();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IniDepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.CreateAccButton = new System.Windows.Forms.Button();
            this.InfoAccNoLabel = new System.Windows.Forms.Label();
            this.InfoAccNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendButton = new System.Windows.Forms.Button();
            this.InfolistBox = new System.Windows.Forms.ListBox();
            this.TrnxAccNoLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TrnxAccNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AmountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.ShowBalanceButton = new System.Windows.Forms.Button();
            this.ListBoxClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccNoLabel
            // 
            this.AccNoLabel.AutoSize = true;
            this.AccNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNoLabel.Location = new System.Drawing.Point(1, 9);
            this.AccNoLabel.Name = "AccNoLabel";
            this.AccNoLabel.Size = new System.Drawing.Size(112, 20);
            this.AccNoLabel.TabIndex = 0;
            this.AccNoLabel.Text = "Account No :";
            this.AccNoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowAccNoLabel
            // 
            this.ShowAccNoLabel.AutoSize = true;
            this.ShowAccNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAccNoLabel.Location = new System.Drawing.Point(119, 9);
            this.ShowAccNoLabel.Name = "ShowAccNoLabel";
            this.ShowAccNoLabel.Size = new System.Drawing.Size(0, 20);
            this.ShowAccNoLabel.TabIndex = 1;
            // 
            // IniDepLabel
            // 
            this.IniDepLabel.AutoSize = true;
            this.IniDepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniDepLabel.Location = new System.Drawing.Point(1, 141);
            this.IniDepLabel.Name = "IniDepLabel";
            this.IniDepLabel.Size = new System.Drawing.Size(130, 20);
            this.IniDepLabel.TabIndex = 2;
            this.IniDepLabel.Text = "Initial Deposit :";
            // 
            // AccTypeLabel
            // 
            this.AccTypeLabel.AutoSize = true;
            this.AccTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccTypeLabel.Location = new System.Drawing.Point(1, 110);
            this.AccTypeLabel.Name = "AccTypeLabel";
            this.AccTypeLabel.Size = new System.Drawing.Size(128, 20);
            this.AccTypeLabel.TabIndex = 3;
            this.AccTypeLabel.Text = "Account Type :";
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchLabel.Location = new System.Drawing.Point(1, 77);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(76, 20);
            this.BranchLabel.TabIndex = 4;
            this.BranchLabel.Text = "Branch :";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(1, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(146, 44);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // IniDepTextBox
            // 
            this.IniDepTextBox.Location = new System.Drawing.Point(146, 141);
            this.IniDepTextBox.Name = "IniDepTextBox";
            this.IniDepTextBox.Size = new System.Drawing.Size(100, 20);
            this.IniDepTextBox.TabIndex = 7;
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Items.AddRange(new object[] {
            "Board Bazar"});
            this.BranchComboBox.Location = new System.Drawing.Point(146, 76);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(100, 21);
            this.BranchComboBox.TabIndex = 8;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Savings"});
            this.TypeComboBox.Location = new System.Drawing.Point(146, 109);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.TypeComboBox.TabIndex = 9;
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.Location = new System.Drawing.Point(63, 176);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(129, 23);
            this.CreateAccButton.TabIndex = 10;
            this.CreateAccButton.Text = "Create Account";
            this.CreateAccButton.UseVisualStyleBackColor = true;
            this.CreateAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // InfoAccNoLabel
            // 
            this.InfoAccNoLabel.AutoSize = true;
            this.InfoAccNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoAccNoLabel.Location = new System.Drawing.Point(440, 9);
            this.InfoAccNoLabel.Name = "InfoAccNoLabel";
            this.InfoAccNoLabel.Size = new System.Drawing.Size(112, 20);
            this.InfoAccNoLabel.TabIndex = 11;
            this.InfoAccNoLabel.Text = "Account No :";
            // 
            // InfoAccNoTextBox
            // 
            this.InfoAccNoTextBox.Location = new System.Drawing.Point(590, 9);
            this.InfoAccNoTextBox.Name = "InfoAccNoTextBox";
            this.InfoAccNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoAccNoTextBox.TabIndex = 12;
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(497, 54);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(173, 23);
            this.InfoButton.TabIndex = 13;
            this.InfoButton.Text = "Show Account Information";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SuspendButton
            // 
            this.SuspendButton.Location = new System.Drawing.Point(497, 95);
            this.SuspendButton.Name = "SuspendButton";
            this.SuspendButton.Size = new System.Drawing.Size(173, 23);
            this.SuspendButton.TabIndex = 14;
            this.SuspendButton.Text = "Suspend Account";
            this.SuspendButton.UseVisualStyleBackColor = true;
            this.SuspendButton.Click += new System.EventHandler(this.SuspendButton_Click);
            // 
            // InfolistBox
            // 
            this.InfolistBox.FormattingEnabled = true;
            this.InfolistBox.Location = new System.Drawing.Point(497, 176);
            this.InfolistBox.Name = "InfolistBox";
            this.InfolistBox.Size = new System.Drawing.Size(173, 95);
            this.InfolistBox.TabIndex = 15;
            // 
            // TrnxAccNoLabel
            // 
            this.TrnxAccNoLabel.AutoSize = true;
            this.TrnxAccNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrnxAccNoLabel.Location = new System.Drawing.Point(7, 228);
            this.TrnxAccNoLabel.Name = "TrnxAccNoLabel";
            this.TrnxAccNoLabel.Size = new System.Drawing.Size(112, 20);
            this.TrnxAccNoLabel.TabIndex = 16;
            this.TrnxAccNoLabel.Text = "Account No :";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(7, 261);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(81, 20);
            this.AmountLabel.TabIndex = 17;
            this.AmountLabel.Text = "Amount :";
            // 
            // TrnxAccNoTextBox
            // 
            this.TrnxAccNoTextBox.Location = new System.Drawing.Point(146, 230);
            this.TrnxAccNoTextBox.Name = "TrnxAccNoTextBox";
            this.TrnxAccNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.TrnxAccNoTextBox.TabIndex = 18;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(146, 263);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 19;
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(63, 298);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(129, 23);
            this.DepositButton.TabIndex = 20;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(63, 341);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(129, 23);
            this.WithdrawButton.TabIndex = 21;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // ShowBalanceButton
            // 
            this.ShowBalanceButton.Location = new System.Drawing.Point(63, 380);
            this.ShowBalanceButton.Name = "ShowBalanceButton";
            this.ShowBalanceButton.Size = new System.Drawing.Size(129, 23);
            this.ShowBalanceButton.TabIndex = 22;
            this.ShowBalanceButton.Text = "Show Balance";
            this.ShowBalanceButton.UseVisualStyleBackColor = true;
            this.ShowBalanceButton.Click += new System.EventHandler(this.ShowBalanceButton_Click);
            // 
            // ListBoxClearButton
            // 
            this.ListBoxClearButton.Location = new System.Drawing.Point(497, 138);
            this.ListBoxClearButton.Name = "ListBoxClearButton";
            this.ListBoxClearButton.Size = new System.Drawing.Size(173, 23);
            this.ListBoxClearButton.TabIndex = 23;
            this.ListBoxClearButton.Text = "Clear List";
            this.ListBoxClearButton.UseVisualStyleBackColor = true;
            this.ListBoxClearButton.Click += new System.EventHandler(this.ListBoxClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxClearButton);
            this.Controls.Add(this.ShowBalanceButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.TrnxAccNoTextBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.TrnxAccNoLabel);
            this.Controls.Add(this.InfolistBox);
            this.Controls.Add(this.SuspendButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.InfoAccNoTextBox);
            this.Controls.Add(this.InfoAccNoLabel);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.IniDepTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.AccTypeLabel);
            this.Controls.Add(this.IniDepLabel);
            this.Controls.Add(this.ShowAccNoLabel);
            this.Controls.Add(this.AccNoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccNoLabel;
        private System.Windows.Forms.Label ShowAccNoLabel;
        private System.Windows.Forms.Label IniDepLabel;
        private System.Windows.Forms.Label AccTypeLabel;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MaskedTextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox IniDepTextBox;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button CreateAccButton;
        private System.Windows.Forms.Label InfoAccNoLabel;
        private System.Windows.Forms.MaskedTextBox InfoAccNoTextBox;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button SuspendButton;
        private System.Windows.Forms.ListBox InfolistBox;
        private System.Windows.Forms.Label TrnxAccNoLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.MaskedTextBox TrnxAccNoTextBox;
        private System.Windows.Forms.MaskedTextBox AmountTextBox;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button ShowBalanceButton;
        private System.Windows.Forms.Button ListBoxClearButton;
    }
}

