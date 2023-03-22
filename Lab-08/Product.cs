using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_B
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }
        public int ReqAmount { get; set; }

        public Product(int id, string name, double price, int qty, int minqty, int req) 
        { 
            Id = id;
            Name = name;
            Price = price;
            Quantity= qty;
            MinQuantity = minqty;
            ReqAmount = req;
            Console.WriteLine("--Product has been added");
            string s=$"ID: {Id}\t Product name: {Name}\t Price: {Price}\t Qty: {Quantity}\t Min.Qty: {MinQuantity}\t Req.Amt: {ReqAmount}";
            Console.WriteLine(s);
        }

    }
}
