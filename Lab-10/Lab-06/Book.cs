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
        private string Genre;
        private int Quantity;

        public Book(int id, string title, string author, string genre, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;
        }

        public int GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }

        public string GetGenre() { return Genre;}
        public int GetQuantity() { return Quantity;}
        public Book() { }

        public void SetId(int id) { Id= id; }
        public void SetTitle(string title) { Title= title; }
        public void SetAuthor(string author) { Author= author; }
        public void SetPublisher(string genre) {Genre = genre; }
        public void SetQuantity(int quantity) { Quantity= quantity; }
    }
}
