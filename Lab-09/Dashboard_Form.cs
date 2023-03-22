using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
            string s = UtilityClass.Name();
            WelcomeLabel.Text ="Welcome" + " " +s + " " + "!";  
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            Log_In_Form l1 = new Log_In_Form();
            l1.Show();
            this.Hide();
        }
    }
}
