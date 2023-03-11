using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_Banking_System
{
    public partial class Form1 : Form
    {
        List<Bank_Account> AccountsArray=new List<Bank_Account>();
        public int count = 1;
        public Form1()
        {
            InitializeComponent();
            int x= AccountsArray.Count;
            ShowAccNoLabel.Text = Convert.ToString(x+1);

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            Bank_Account acc = new Bank_Account(Convert.ToInt32(ShowAccNoLabel.Text), NameTextBox.Text, BranchComboBox.Text, TypeComboBox.Text,Convert.ToDouble(IniDepTextBox.Text),false);
            MessageBox.Show("Account Created Successfully");
            
           

            AccountsArray.Add(acc);

            int x = AccountsArray.Count;
            ShowAccNoLabel.Text = Convert.ToString(x + 1);

            NameTextBox.Clear();
            IniDepTextBox.Clear();

            InfolistBox.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            int info= Convert.ToInt32(InfoAccNoTextBox.Text)-1;
            int num = info+1;
            string name = AccountsArray[info].GetName();
            string branch = AccountsArray[info].GetBranch();
            string type = AccountsArray[info].Gettype();
            double balance = AccountsArray[info].GetBalance();
            bool suspended = AccountsArray[info].GetIsSuspended();

            
            InfolistBox.Items.Add($"Account No:{num}");
            InfolistBox.Items.Add($"Name: {name}");
            InfolistBox.Items.Add($"Branch: {branch}");
            InfolistBox.Items.Add($"Account Type: {type}");
            InfolistBox.Items.Add($"Balance: BDT {balance}");
            InfolistBox.Items.Add($"Suspended? {suspended}");

            InfoAccNoTextBox.Clear();

        }

        private void SuspendButton_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(InfoAccNoTextBox.Text) - 1;
            int num = info + 1;

            AccountsArray[info].SetIsSuspended(true);
            MessageBox.Show($"Account No:{AccountsArray[info].GetAccNo()} is suspended");

            InfolistBox.Items.Clear();

            InfoAccNoTextBox.Clear();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(TrnxAccNoTextBox.Text);
            
            int num = info;

            double amount=Convert.ToDouble(AmountTextBox.Text);

            AccountsArray[info-1].Deposit(amount);

            InfolistBox.Items.Clear();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(TrnxAccNoTextBox.Text) - 1;
            int num = info + 1;

            double amount = Convert.ToDouble(AmountTextBox.Text);

            AccountsArray[info].Withdraw(amount);

            InfolistBox.Items.Clear();
        }

        private void ShowBalanceButton_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(TrnxAccNoTextBox.Text) - 1;
            int num = info + 1;

            double balance = AccountsArray[info].GetBalance();

            MessageBox.Show($"Account No:{AccountsArray[info].GetAccNo()} current balance is {balance}");
        }

        private void ListBoxClearButton_Click(object sender, EventArgs e)
        {
            InfolistBox.Items.Clear();
        }
    }
}
