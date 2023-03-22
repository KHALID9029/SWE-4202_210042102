namespace Lab_09
{
    partial class Sign_Up_Page_Form
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
            this.SNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SUsernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sre_passTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PCLogInbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SNameTB
            // 
            this.SNameTB.Location = new System.Drawing.Point(319, 85);
            this.SNameTB.Name = "SNameTB";
            this.SNameTB.Size = new System.Drawing.Size(128, 20);
            this.SNameTB.TabIndex = 4;
            this.SNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // SUsernameTB
            // 
            this.SUsernameTB.Location = new System.Drawing.Point(319, 136);
            this.SUsernameTB.Name = "SUsernameTB";
            this.SUsernameTB.Size = new System.Drawing.Size(128, 20);
            this.SUsernameTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(319, 189);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(128, 20);
            this.PasswordTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // Sre_passTB
            // 
            this.Sre_passTB.Location = new System.Drawing.Point(319, 234);
            this.Sre_passTB.Name = "Sre_passTB";
            this.Sre_passTB.Size = new System.Drawing.Size(128, 20);
            this.Sre_passTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Re-Type Password";
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.Location = new System.Drawing.Point(266, 285);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(86, 31);
            this.SignUpbutton.TabIndex = 11;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = true;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Already havean account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PCLogInbutton
            // 
            this.PCLogInbutton.Location = new System.Drawing.Point(360, 330);
            this.PCLogInbutton.Name = "PCLogInbutton";
            this.PCLogInbutton.Size = new System.Drawing.Size(75, 23);
            this.PCLogInbutton.TabIndex = 12;
            this.PCLogInbutton.Text = "Log In!";
            this.PCLogInbutton.UseVisualStyleBackColor = true;
            this.PCLogInbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sign_Up_Page_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PCLogInbutton);
            this.Controls.Add(this.SignUpbutton);
            this.Controls.Add(this.Sre_passTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SUsernameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SNameTB);
            this.Controls.Add(this.label2);
            this.Name = "Sign_Up_Page_Form";
            this.Text = "Sign_Up_Page_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SUsernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sre_passTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PCLogInbutton;
    }
}