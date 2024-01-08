using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
   
    abstract internal class User
    {
        public int Id;
        public string Name;
        public string Address;
        public string Type;
    }

    class RegularUser : User 
    {
        public List<Book> borrowedbooks= new List<Book>();
        List<string> duedates = new List<string>();
        public int borrowbooks { get; set; } = 0;
        public void borrowbook(Book book, string date)
        {
            if (borrowbooks <= 5)
            {
                borrowedbooks.Add(book);
                duedates.Add(date);
                borrowbooks++;
                book.SetQuantity(book.GetQuantity()-1);
                Library.maxbook--;
            }
            else 
            {
                MessageBox.Show("Cannot Borrow any more books");
            }
        }

        public void returnbook(Book b)
        {
            int flag = 0;
            foreach (Book book in borrowedbooks)
            {
                if (book.GetId() == b.GetId()) { flag = 1; break; }

            }
            if (flag==1) { borrowedbooks.Remove(b); }
            
            else { throw new NotBorrowed(); }


        }
        public double fine { get; set; }
        
        public void Fine(int day)
        {
            fine += (10 * day);
        }
        

        public RegularUser(int id, string name, string address)
        {
            Id= id; Name= name; Address= address; Type = "Regular";
        }
    }

    class SpecialUser : User
    {
        List<Book> books = new List<Book>();
       
        public SpecialUser(int id, string name, string address)
        {
            Id = id; Name = name; Address = address; Type = "Special";
        }

        public SpecialUser() { }

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public void DeleteBook(Book b) 
        {
            foreach (Book bb in books)
            {
                if (bb.GetId() == b.GetId())
                { b = bb; break; }
            }
            books.Remove(b);
        }
    }
}
