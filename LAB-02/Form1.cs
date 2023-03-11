using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02_TASK
{
    public partial class Form1 : Form
    {
        List<string> codesArray= new List<string>();    
        List<int> totalArray = new List<int>();
        List<double> gpaAarray = new List<double>();
        List<string> gradesArray= new List<string>();
        string name;
        string ID;
        public Form1()
        {
            InitializeComponent();
            NametextBox.Focus();
            resultlistBox.Items.Add("Course code \t Total Marks \t Grade \t Grade Point");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NametextBox.Clear();
            IdtextBox.Clear();
            Quiz1textBox.Clear();
            Quiz2textBox.Clear();
            Quiz3textBox.Clear();
            Quiz4textBox.Clear();
            MidtextBox.Clear();
            FinaltextBox.Clear();
            AttendancetextBox.Clear();
            sessionaltextBox.Clear();

            NametextBox.Focus();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            name = NametextBox.Text;
            ID = IdtextBox.Text;
            string code = CoursecomboBox.Text;
            int total;
            codesArray.Add(code);
            if (code == "SWE 4202" || code == "CSE 4206" || code == "HUM 4242") { total = Convert.ToInt32(sessionaltextBox.Text); }
            else
            {
                int mid = Convert.ToInt32(MidtextBox.Text) / 3;
                int final = Convert.ToInt32(FinaltextBox.Text) / 3;
                int attendance = Convert.ToInt32(AttendancetextBox.Text) / 3;
                int quiz1 = Convert.ToInt32(Quiz1textBox.Text);
                int quiz2 = Convert.ToInt32(Quiz2textBox.Text);
                int quiz3 = Convert.ToInt32(Quiz3textBox.Text);
                int quiz4 = Convert.ToInt32(Quiz4textBox.Text);

                int[] quiz = new int[4];
                quiz[0] = quiz1;
                quiz[1] = quiz2;
                quiz[2] = quiz3;
                quiz[3] = quiz4;
                Array.Sort(quiz);

                int newquiz = (quiz[3] + quiz[1] + quiz[2]) / 3;

                total = newquiz + mid + final + attendance;
            }
            totalArray.Add(total);

            string grade = "";
            double gpa = 0.0;

            if(total>=80) { grade = "A+";gpa = 4.0; }
            else if (total>=75 && total<80) { grade = "A";gpa = 3.75; }
            else if (total >= 70 && total < 75) { grade = "A-"; gpa = 3.50; }
            else if (total >= 65 && total < 70) { grade = "B+"; gpa = 3.25; }
            else if (total >= 60 && total < 65) { grade = "B"; gpa = 3.00; }
            else if (total >= 55 && total < 60) { grade = "B-"; gpa = 2.75; }
            else if (total >= 50 && total < 55) { grade = "C+"; gpa = 2.50; }
            else if (total >= 45 && total < 50) { grade = "C"; gpa = 2.25; }
            else if (total >= 40 && total < 45) { grade = "D"; gpa = 2.00; }
            else { grade = "F";gpa= 0; }

            gpaAarray.Add(gpa);
            gradesArray.Add(grade);

            MessageBox.Show("Course added successfully. After adding all the courses Please click SUBMIT to see result");

            Quiz1textBox.Clear();
            Quiz2textBox.Clear();
            Quiz3textBox.Clear();
            Quiz4textBox.Clear();
            MidtextBox.Clear();
            FinaltextBox.Clear();
            AttendancetextBox.Clear();
            sessionaltextBox.Clear();
            //string result = $"{code} \t {total} \t\t {grade} \t {gpa}";
            // resultlistBox.Items.Add(result);
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<gpaAarray.Count;i++) 
            {
                string result = $"{codesArray[i]} \t {totalArray[i]} \t\t {gradesArray[i]} \t {gpaAarray[i]}";
                resultlistBox.Items.Add(result);
            }

            double sum = 0;
            for(int j=0;j<gpaAarray.Count;j++) 
            {
                sum += gpaAarray[j];
            }

            double CGPA = sum/gpaAarray.Count;
            CGPA = (double)System.Math.Round(CGPA, 2);

            CGPAlabel.Text = $"Final CGPA of {name}, ID:{ID} is {CGPA}";
        }
    }
}
