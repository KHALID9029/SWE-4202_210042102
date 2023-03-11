using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Book
    {
        private int Id;
        private string Title;
        private string Author;
        private string Publisher;
        private int Quantity;

        public Book(int id, string title, string author, string publisher, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            Quantity = quantity;
        }

        public int GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }

        public string GetPublisher() { return Publisher;}
        public int GetQuantity() { return Quantity;}
        public Book() { }

        public void SetId(int id) { Id= id; }
        public void SetTitle(string title) { Title= title; }
        public void SetAuthor(string author) { Author= author; }
        public void SetPublisher(string publisher) { Publisher= publisher; }
        public void SetQuantity(int quantity) { Quantity= quantity; }
    }
}
