using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
