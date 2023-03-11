using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_Banking_System
{
    internal class Bank_Account
    {
        private int AccNo;
        private String Name;
        private String Branch;
        private String Type;
        private double Balance;
        private bool IsSuspended;
        

        public Bank_Account(int accNo,string name, string branch, string type, double balance, bool isSuspended)
        {
            AccNo = accNo;
            Name = name;
            Branch = branch;
            Type = type;
            Balance = balance;
            IsSuspended = isSuspended;
        }

        public int GetAccNo() { return AccNo; }
        public String GetName() { return Name; }
        public string GetBranch() { return Branch; }
        public string Gettype() { return Type; }
        public double GetBalance() { return Balance; }
        public bool GetIsSuspended() { return IsSuspended; }

        public void SetAcctNo(int accNo) { AccNo = accNo; }
        public void SetName(String name) { Name = name; }
        public void SetBranch(String branch) { Branch = branch; }
        public void SetType(String type) { Type = type; }
        public void SetBalance(Double balance) { Balance = balance; }
        public void SetIsSuspended(bool isSuspended) { IsSuspended = isSuspended; }

        public void Deposit(double amount)
        {
            if (!IsSuspended)
            {
                Balance += amount;
                MessageBox.Show("Deposit Successful");
            }
            else { MessageBox.Show("Account Suspended Deposit Unsuccessful"); }

        }

        public void Withdraw(double amount)
        {
            if(IsSuspended) { MessageBox.Show("Account Suspended Transaction Unsuccessful"); }
            else if (Balance >= amount && !IsSuspended)
            {
                Balance -= amount;
                MessageBox.Show($"Withdraw Successful. Remaining Balance{Balance}");
            }
            else if(Balance<amount) { MessageBox.Show("Not Enough Balance"); }
        }
    }
}

