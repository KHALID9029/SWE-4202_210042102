using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrollment
{
    public partial class Form1 : Form
    {
        List<Department> departments = new List<Department>();
        public Form1()
        {
            InitializeComponent();
            ShowStudentsListBox.Items.Add("ID\tName\tDepartment\tSection");
        }

        private void AddDepButton_Click(object sender, EventArgs e)
        {
            Department temp = new Department(Convert.ToInt32(DepCodeTextBox.Text),DepNameTextBox.Text);
            departments.Add(temp);
            MessageBox.Show("Department added successfully");

            SDepCodeComboBox.Items.Add(DepCodeTextBox.Text);
            InfoDepCodeComboBox.Items.Add(DepCodeTextBox.Text);

            DepNameTextBox.Clear();
            DepCodeTextBox.Clear();
        }

        private void AdmitButton_Click(object sender, EventArgs e)
        {
            Student temp = new Student(Convert.ToInt32(SIdTextBox.Text), SNameTextBox.Text, SectionTextBox.Text, Convert.ToInt32(SDepCodeComboBox.Text));

            foreach(Department dept in departments) 
            {
                if (dept.GetCode() == temp.GetDepCode())
                {
                    dept.Students.Add(temp);
                }
            }

            MessageBox.Show("Student Admitted Successfully");
            
            SIdTextBox.Clear();
            SNameTextBox.Clear();   
            SectionTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowStudentsListBox.Items.Clear();
            Department temp=new Department();
            
            foreach(Department dept in departments) 
            {
                if(dept.GetCode()==Convert.ToInt32(InfoDepCodeComboBox.Text)) 
                { 
                  temp= dept;
                }
            }

            foreach(Student S in temp.Students)
            {
                int id = S.GetId();
                string name = S.GetName();
                string Dep = temp.GetName();
                string section = S.GetSection();

                string Info = $"{id}\t{name}\t{Dep}\t\t{section}";

                ShowStudentsListBox.Items.Add("ID\tName\tDepartment\tSection");
                ShowStudentsListBox.Items.Add(Info);
            }
        }
    }
}
