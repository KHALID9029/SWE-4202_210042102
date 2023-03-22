using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab_09
{
    public partial class Log_In_Form : Form
    {
        public Log_In_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = LUsernameTB.Text;
            string password = LPasswordTB.Text;
            //int flag = 0;
            string file = "Info.txt";

            if (File.Exists(file))
            {
                // Reads file line by line
                StreamReader Textfile = new StreamReader(file);
                string line;
                int flag = 0;
                while ((line = Textfile.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');
                    string Eusername = s[0];
                    string Epassword = s[1];
                    string Ename = s[2];

                    if (Eusername == name && Epassword == password)
                    {
                        UtilityClass.Name(name);
                        flag++;
                        break;
                    }
                    
                }
                if(flag==1)
                {
                    Dashboard_Form d1 = new Dashboard_Form();
                    d1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

                Textfile.Close();
            }
        }

        private void PCSignUpbutton_Click(object sender, EventArgs e)
        {
            Sign_Up_Page_Form s1 = new Sign_Up_Page_Form();
            s1.Show();
            this.Hide();
        }
    }
}
