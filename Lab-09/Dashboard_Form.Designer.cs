namespace Lab_09
{
    partial class Dashboard_Form
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(220, 138);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(98, 20);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "WELCOME";
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbutton.Location = new System.Drawing.Point(272, 220);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(86, 31);
            this.LogOutbutton.TabIndex = 12;
            this.LogOutbutton.Text = "Log Out!";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Dashboard_Form";
            this.Text = "Dashboard_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button LogOutbutton;
    }
}