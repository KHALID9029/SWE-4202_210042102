using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_B
{
    internal class Salesassociate : Employee
    {

        private string Name;
        private int Age;
        private double BaseSalary;
        private double Bonus = 0.00;
        private double TotalSalary;

        public void setname(string name) { Name = name; }
        public void setage(int age) { Age = age; }
        public void setsalary(double salary) { BaseSalary = salary; }
        public void setbonus(double amount) { Bonus = amount; }
        public void setTotalSalary(double amount) { TotalSalary = amount; }

        public Salesassociate(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.BaseSalary = salary;
            this.TotalSalary = BaseSalary + Bonus;

            Console.WriteLine("---Sales Associate has been added!");
            string s = $"Name: {Name}\t Age: {Age}\t  Base Salary: {BaseSalary}\t Bonus: {Bonus}\t Total Salary : {TotalSalary}";
            Console.WriteLine(s);
        }

        public string getname() { return Name; }
        public int getage() { return Age; }
        public double getbaseSalary() { return BaseSalary; }
        public double getbonus() { return Bonus; }
        public double getTotalSalary() { return TotalSalary; }

        public void sellProduct (int id, int amount, Store s)
        {
            foreach (Product p in s.products)
            {
                if(p.Id==id) 
                {
                    if (p.Quantity >= amount)
                    {
                        p.Quantity -= amount;
                        double x = p.Price * (1.0f / 100.0f);
                        double y = amount * x;
                        y = Convert.ToDouble(y.ToString("N3"));
                        Bonus += y;
                        TotalSalary+= y;

                        string ss = $"{p.Name} has been sold and {Name} has received a bonus of BDT {y}";
                        Console.WriteLine(ss);
                    }
                    else
                    {
                        Console.WriteLine($"Not enough amount of {p.Name}. Contact your manager!");
                    }
                }
            }

        }

        public override void showinfo()
        {
            string s = $"Name: {Name}\t Age: {Age}\t  Base Salary: {BaseSalary}\t Bonus: {Bonus}\t Total Salary : {TotalSalary}";
            Console.WriteLine(s);
        }
    }
}
