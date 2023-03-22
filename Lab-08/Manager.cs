using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_B
{
    internal class Manager : Employee
    {
        private string Name;
        private int Age;
        private double BaseSalary;

        public void setname(string name) { Name = name; }
        public void setage(int age) { Age = age; }
        public void setsalary(double salary) { BaseSalary = salary; }
        
        public Manager (string name, int age, double salary) 
        {
            this.Name = name;
            this.Age = age;
            this.BaseSalary = salary;

            Console.WriteLine("----Manager has been added!");
            string s = $"Name: {Name}\t Age: {Age}\t  Base Salary: {BaseSalary}";
            Console.WriteLine(s);
        }

        public string getname() { return Name; }
        public int getage() { return Age;}
        public double getbaseSalary() { return BaseSalary;}

        public void addExistingProduct(int id, int amount , Store s)
        {
            foreach(Product p in s.products) 
            {
              if(p.Id==id)
                {
                    p.Quantity += amount;
                    string ss = $"Added {amount} pieces of {p.Name}";
                    Console.WriteLine(ss);
                }
            }
        }

        public void sendRequisition(Store s)
        {
            foreach(Product p in s.products)
            {
                p.Quantity += p.ReqAmount;
                Console.WriteLine($"Added {p.ReqAmount} pieces of {p.Name}");
            }
        }

        public override void showinfo()
        {
            string s = $"Name: {Name}\t Age: {Age}\t  Base Salary: {BaseSalary}";
            Console.WriteLine(s);
        }

        public void addProduct(int id, string name, double price, int qty, int minqty, int req, Store s)
        {
            Product p = new Product( id,  name,  price,  qty,  minqty,  req);
            s.products.Add(p);
        }
    }
}
