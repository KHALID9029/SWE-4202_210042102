namespace Lab_09
{
    partial class Log_In_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.LUsernameTB = new System.Windows.Forms.TextBox();
            this.LPasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.PCSignUpbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LUsernameTB
            // 
            this.LUsernameTB.Location = new System.Drawing.Point(320, 94);
            this.LUsernameTB.Name = "LUsernameTB";
            this.LUsernameTB.Size = new System.Drawing.Size(128, 20);
            this.LUsernameTB.TabIndex = 2;
            // 
            // LPasswordTB
            // 
            this.LPasswordTB.Location = new System.Drawing.Point(320, 133);
            this.LPasswordTB.Name = "LPasswordTB";
            this.LPasswordTB.Size = new System.Drawing.Size(128, 20);
            this.LPasswordTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // LogInbutton
            // 
            this.LogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbutton.Location = new System.Drawing.Point(278, 186);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(86, 31);
            this.LogInbutton.TabIndex = 5;
            this.LogInbutton.Text = "Log In";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PCSignUpbutton
            // 
            this.PCSignUpbutton.Location = new System.Drawing.Point(339, 239);
            this.PCSignUpbutton.Name = "PCSignUpbutton";
            this.PCSignUpbutton.Size = new System.Drawing.Size(75, 23);
            this.PCSignUpbutton.TabIndex = 6;
            this.PCSignUpbutton.Text = "Create One!";
            this.PCSignUpbutton.UseVisualStyleBackColor = true;
            this.PCSignUpbutton.Click += new System.EventHandler(this.PCSignUpbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t have an account?";
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PCSignUpbutton);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.LPasswordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LUsernameTB);
            this.Controls.Add(this.label2);
            this.Name = "Log_In_Form";
            this.Text = "Log_In_Page_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LUsernameTB;
        private System.Windows.Forms.TextBox LPasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Button PCSignUpbutton;
        private System.Windows.Forms.Label label3;
    }
}

