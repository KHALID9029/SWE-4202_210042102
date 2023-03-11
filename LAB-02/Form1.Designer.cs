namespace LAB_02_TASK
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Courselabel = new System.Windows.Forms.Label();
            this.CoursecomboBox = new System.Windows.Forms.ComboBox();
            this.Quiz1label = new System.Windows.Forms.Label();
            this.Quiz2label = new System.Windows.Forms.Label();
            this.Quiz3label = new System.Windows.Forms.Label();
            this.Quiz4label = new System.Windows.Forms.Label();
            this.Midlabel = new System.Windows.Forms.Label();
            this.Finallabel = new System.Windows.Forms.Label();
            this.Attendancelabel = new System.Windows.Forms.Label();
            this.AttendancetextBox = new System.Windows.Forms.TextBox();
            this.FinaltextBox = new System.Windows.Forms.TextBox();
            this.MidtextBox = new System.Windows.Forms.TextBox();
            this.Quiz4textBox = new System.Windows.Forms.TextBox();
            this.Quiz3textBox = new System.Windows.Forms.TextBox();
            this.Quiz2textBox = new System.Windows.Forms.TextBox();
            this.Quiz1textBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.resultlistBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CGPAlabel = new System.Windows.Forms.Label();
            this.sessionallabel = new System.Windows.Forms.Label();
            this.sessionaltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(0, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(51, 20);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.Location = new System.Drawing.Point(0, 29);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(26, 20);
            this.Idlabel.TabIndex = 1;
            this.Idlabel.Text = "ID";
            // 
            // Courselabel
            // 
            this.Courselabel.AutoSize = true;
            this.Courselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courselabel.Location = new System.Drawing.Point(0, 56);
            this.Courselabel.Name = "Courselabel";
            this.Courselabel.Size = new System.Drawing.Size(60, 20);
            this.Courselabel.TabIndex = 2;
            this.Courselabel.Text = "Course";
            // 
            // CoursecomboBox
            // 
            this.CoursecomboBox.FormattingEnabled = true;
            this.CoursecomboBox.Items.AddRange(new object[] {
            "SWE 4201",
            "CSE 4203",
            "CSE 4205",
            "HUM 4247",
            "HUM 4249",
            "MATH 4241",
            "CSE 4206",
            "SWE 4202",
            "HUM 4242"});
            this.CoursecomboBox.Location = new System.Drawing.Point(165, 55);
            this.CoursecomboBox.Name = "CoursecomboBox";
            this.CoursecomboBox.Size = new System.Drawing.Size(117, 21);
            this.CoursecomboBox.TabIndex = 3;
            // 
            // Quiz1label
            // 
            this.Quiz1label.AutoSize = true;
            this.Quiz1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz1label.Location = new System.Drawing.Point(0, 85);
            this.Quiz1label.Name = "Quiz1label";
            this.Quiz1label.Size = new System.Drawing.Size(99, 20);
            this.Quiz1label.TabIndex = 4;
            this.Quiz1label.Text = "Quiz 1 (_/15)";
            // 
            // Quiz2label
            // 
            this.Quiz2label.AutoSize = true;
            this.Quiz2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz2label.Location = new System.Drawing.Point(0, 116);
            this.Quiz2label.Name = "Quiz2label";
            this.Quiz2label.Size = new System.Drawing.Size(99, 20);
            this.Quiz2label.TabIndex = 5;
            this.Quiz2label.Text = "Quiz 2 (_/15)";
            // 
            // Quiz3label
            // 
            this.Quiz3label.AutoSize = true;
            this.Quiz3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz3label.Location = new System.Drawing.Point(0, 149);
            this.Quiz3label.Name = "Quiz3label";
            this.Quiz3label.Size = new System.Drawing.Size(99, 20);
            this.Quiz3label.TabIndex = 6;
            this.Quiz3label.Text = "Quiz 3 (_/15)";
            // 
            // Quiz4label
            // 
            this.Quiz4label.AutoSize = true;
            this.Quiz4label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz4label.Location = new System.Drawing.Point(0, 184);
            this.Quiz4label.Name = "Quiz4label";
            this.Quiz4label.Size = new System.Drawing.Size(99, 20);
            this.Quiz4label.TabIndex = 7;
            this.Quiz4label.Text = "Quiz 4 (_/15)";
            // 
            // Midlabel
            // 
            this.Midlabel.AutoSize = true;
            this.Midlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Midlabel.Location = new System.Drawing.Point(0, 214);
            this.Midlabel.Name = "Midlabel";
            this.Midlabel.Size = new System.Drawing.Size(79, 20);
            this.Midlabel.TabIndex = 8;
            this.Midlabel.Text = "Mid (_/75)";
            // 
            // Finallabel
            // 
            this.Finallabel.AutoSize = true;
            this.Finallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finallabel.Location = new System.Drawing.Point(3, 243);
            this.Finallabel.Name = "Finallabel";
            this.Finallabel.Size = new System.Drawing.Size(97, 20);
            this.Finallabel.TabIndex = 9;
            this.Finallabel.Text = "Final (_/150)";
            // 
            // Attendancelabel
            // 
            this.Attendancelabel.AutoSize = true;
            this.Attendancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancelabel.Location = new System.Drawing.Point(3, 273);
            this.Attendancelabel.Name = "Attendancelabel";
            this.Attendancelabel.Size = new System.Drawing.Size(137, 20);
            this.Attendancelabel.TabIndex = 10;
            this.Attendancelabel.Text = "Attendance (_/30)";
            // 
            // AttendancetextBox
            // 
            this.AttendancetextBox.Location = new System.Drawing.Point(165, 273);
            this.AttendancetextBox.Name = "AttendancetextBox";
            this.AttendancetextBox.Size = new System.Drawing.Size(117, 20);
            this.AttendancetextBox.TabIndex = 11;
            // 
            // FinaltextBox
            // 
            this.FinaltextBox.Location = new System.Drawing.Point(165, 243);
            this.FinaltextBox.Name = "FinaltextBox";
            this.FinaltextBox.Size = new System.Drawing.Size(117, 20);
            this.FinaltextBox.TabIndex = 12;
            // 
            // MidtextBox
            // 
            this.MidtextBox.Location = new System.Drawing.Point(165, 214);
            this.MidtextBox.Name = "MidtextBox";
            this.MidtextBox.Size = new System.Drawing.Size(117, 20);
            this.MidtextBox.TabIndex = 13;
            // 
            // Quiz4textBox
            // 
            this.Quiz4textBox.Location = new System.Drawing.Point(165, 184);
            this.Quiz4textBox.Name = "Quiz4textBox";
            this.Quiz4textBox.Size = new System.Drawing.Size(117, 20);
            this.Quiz4textBox.TabIndex = 14;
            // 
            // Quiz3textBox
            // 
            this.Quiz3textBox.Location = new System.Drawing.Point(165, 149);
            this.Quiz3textBox.Name = "Quiz3textBox";
            this.Quiz3textBox.Size = new System.Drawing.Size(117, 20);
            this.Quiz3textBox.TabIndex = 15;
            // 
            // Quiz2textBox
            // 
            this.Quiz2textBox.Location = new System.Drawing.Point(165, 116);
            this.Quiz2textBox.Name = "Quiz2textBox";
            this.Quiz2textBox.Size = new System.Drawing.Size(117, 20);
            this.Quiz2textBox.TabIndex = 16;
            // 
            // Quiz1textBox
            // 
            this.Quiz1textBox.Location = new System.Drawing.Point(165, 85);
            this.Quiz1textBox.Name = "Quiz1textBox";
            this.Quiz1textBox.Size = new System.Drawing.Size(117, 20);
            this.Quiz1textBox.TabIndex = 17;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(165, 29);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(117, 20);
            this.IdtextBox.TabIndex = 18;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(165, 0);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(117, 20);
            this.NametextBox.TabIndex = 19;
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.OrangeRed;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(116, 350);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 31);
            this.Clearbutton.TabIndex = 20;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(207, 350);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 31);
            this.Addbutton.TabIndex = 21;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Submitbutton
            // 
            this.Submitbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.Submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbutton.Location = new System.Drawing.Point(139, 396);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(118, 31);
            this.Submitbutton.TabIndex = 22;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = false;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // resultlistBox
            // 
            this.resultlistBox.FormattingEnabled = true;
            this.resultlistBox.Location = new System.Drawing.Point(355, 42);
            this.resultlistBox.Name = "resultlistBox";
            this.resultlistBox.Size = new System.Drawing.Size(364, 147);
            this.resultlistBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(360, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Result Will  be show here!";
            // 
            // CGPAlabel
            // 
            this.CGPAlabel.AutoSize = true;
            this.CGPAlabel.BackColor = System.Drawing.Color.Red;
            this.CGPAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGPAlabel.ForeColor = System.Drawing.Color.Black;
            this.CGPAlabel.Location = new System.Drawing.Point(360, 202);
            this.CGPAlabel.Name = "CGPAlabel";
            this.CGPAlabel.Size = new System.Drawing.Size(228, 20);
            this.CGPAlabel.TabIndex = 25;
            this.CGPAlabel.Text = "Final CGPA will be shown here!";
            // 
            // sessionallabel
            // 
            this.sessionallabel.AutoSize = true;
            this.sessionallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionallabel.Location = new System.Drawing.Point(3, 305);
            this.sessionallabel.Name = "sessionallabel";
            this.sessionallabel.Size = new System.Drawing.Size(132, 20);
            this.sessionallabel.TabIndex = 26;
            this.sessionallabel.Text = "Sessional (_/100)";
            // 
            // sessionaltextBox
            // 
            this.sessionaltextBox.Location = new System.Drawing.Point(165, 307);
            this.sessionaltextBox.Name = "sessionaltextBox";
            this.sessionaltextBox.Size = new System.Drawing.Size(117, 20);
            this.sessionaltextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.sessionaltextBox);
            this.Controls.Add(this.sessionallabel);
            this.Controls.Add(this.CGPAlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultlistBox);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Quiz1textBox);
            this.Controls.Add(this.Quiz2textBox);
            this.Controls.Add(this.Quiz3textBox);
            this.Controls.Add(this.Quiz4textBox);
            this.Controls.Add(this.MidtextBox);
            this.Controls.Add(this.FinaltextBox);
            this.Controls.Add(this.AttendancetextBox);
            this.Controls.Add(this.Attendancelabel);
            this.Controls.Add(this.Finallabel);
            this.Controls.Add(this.Midlabel);
            this.Controls.Add(this.Quiz4label);
            this.Controls.Add(this.Quiz3label);
            this.Controls.Add(this.Quiz2label);
            this.Controls.Add(this.Quiz1label);
            this.Controls.Add(this.CoursecomboBox);
            this.Controls.Add(this.Courselabel);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGPA CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Courselabel;
        private System.Windows.Forms.ComboBox CoursecomboBox;
        private System.Windows.Forms.Label Quiz1label;
        private System.Windows.Forms.Label Quiz2label;
        private System.Windows.Forms.Label Quiz3label;
        private System.Windows.Forms.Label Quiz4label;
        private System.Windows.Forms.Label Midlabel;
        private System.Windows.Forms.Label Finallabel;
        private System.Windows.Forms.Label Attendancelabel;
        private System.Windows.Forms.TextBox AttendancetextBox;
        private System.Windows.Forms.TextBox FinaltextBox;
        private System.Windows.Forms.TextBox MidtextBox;
        private System.Windows.Forms.TextBox Quiz4textBox;
        private System.Windows.Forms.TextBox Quiz3textBox;
        private System.Windows.Forms.TextBox Quiz2textBox;
        private System.Windows.Forms.TextBox Quiz1textBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.ListBox resultlistBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CGPAlabel;
        private System.Windows.Forms.Label sessionallabel;
        private System.Windows.Forms.TextBox sessionaltextBox;
    }
}

