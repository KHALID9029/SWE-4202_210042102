using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_09
{
    public partial class Sign_Up_Page_Form : Form
    {
        public Sign_Up_Page_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_In_Form l1 = new Log_In_Form();
            l1.Show();
            this.Hide();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            string name = SNameTB.Text;
            string username = SUsernameTB.Text;
            string password = PasswordTB.Text;
            string re_password = Sre_passTB.Text;

            string file ="Info.txt";

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
                    string Ename= s[2];

                    if(Eusername==username)
                    {
                        flag++;
                        //Textfile.Close();
                        break;
                    }
                }
                Textfile.Close();
                if (flag==0)
                {
                    if (username.Length >= 6 && password.Length >= 6)
                    {
                        if (password == re_password)
                        {
                            User u1 = new User(name, username, password);
                            UtilityClass.users.Add(u1);
                            string text = $"{username},{password},{name}";
                            StreamWriter sw = new StreamWriter("Info.txt",true);
                            sw.WriteLine(text);
                            sw.Close();

                            Log_In_Form L1 = new Log_In_Form();
                            L1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password do not match");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Username and Password must be at least six characters");
                    }
                }
                else 
                {
                    MessageBox.Show("A User With the same user name already exists");
                }
            }
            else
            {
                User u1 = new User(name, username, password);
                UtilityClass.users.Add(u1);
                string text = $"{username},{password},{name}";
                StreamWriter sw = new StreamWriter("Info.txt",true);
                sw.WriteLine(text);
                sw.Close();

                Log_In_Form L1 = new Log_In_Form();
                L1.Show();
                this.Hide();
            }

        }
    }
}
