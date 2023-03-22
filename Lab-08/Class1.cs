using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_08_B
{
    internal class Store
    {
        public List<Product> products = new List<Product>();
        public Store() 
        {
            Console.WriteLine("-----Store has been generated successfully");
        }

        Manager M;

        public List<Salesassociate> Salesassociates = new List<Salesassociate>();

        public void showStoreDetails()
        {
            Console.WriteLine("Inventory Details");
            foreach(Product p in products) 
            {
                string s = $"ID: {p.Id}\t Product name: {p.Name}\t Price: {p.Price}\t Qty: {p.Quantity}\t Min.Qty: {p.MinQuantity}\t Req.Amt: {p.ReqAmount}";
                Console.WriteLine(s);
            }
        }
    }
}
