using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Form1 : Form
    {
        List<RegularUser> regularUsers= new List<RegularUser>();
        List<SpecialUser> specialUsers= new List<SpecialUser>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            ShowListBox.Items.Add("Id\tTitle\tAuthor\tQuantity");
            foreach(Book b in books)
            {
                if (b.GetQuantity() > 1)
                { RentBookIdComboBox.Items.Add(b.GetTitle()) ; }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            string name = NameTextBox.Text;
            string address= AddressTextBox.Text;
            if (TypeComboBox.Text == "Regular")
            {
                RegularUser r1 = new RegularUser(id, name, address);
                
                regularUsers.Add(r1);
                UserComboBox.Items.Add(r1.Name);
                RBUSerIdComboBox.Items.Add(r1.Id);
            }

            else 
            {
              SpecialUser s1 = new SpecialUser(id, name, address);

               specialUsers.Add(s1);
               UserComboBox.Items.Add(s1.Name);
            }

            MessageBox.Show("User Added Successfully");

            IdTextBox.Clear();
            NameTextBox.Clear();
            AddressTextBox.Clear(); 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string name = UserComboBox.Text;
            int flag = 0;
            SpecialUser s = new SpecialUser();
            foreach(SpecialUser s1 in specialUsers) { if (s1.Name == name) { s = s1; flag++; } }

            if (flag == 0) { MessageBox.Show("Insufficient Rights"); }

            else 
            {
                int id = Convert.ToInt32(BookIdTextBox.Text);
                string title = BookTitleTextBox.Text;
                string author = AuthorTextBox.Text;
                string publisher = PublisherTextBox.Text;
                int quantity = Convert.ToInt32(QuantityTextBox.Text);
                Book b1 = new Book(id,title,author,publisher,quantity);
                
                s.DeleteBook(b1);
                books.Remove(b1);
                Library.maxbook -= quantity;
                

                MessageBox.Show("Book Deleted Successfully");

                BookIdTextBox.Clear();
                BookTitleTextBox.Clear();
                AuthorTextBox.Clear();
                PublisherTextBox.Clear();
                QuantityTextBox.Clear();
            }

            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = UserComboBox.Text;
            int flag = 0;
            SpecialUser s = new SpecialUser();
            foreach (SpecialUser s1 in specialUsers) { if (s1.Name == name) { s = s1; flag++; } }

            if (flag == 0) { MessageBox.Show("Insufficient Rights"); }

            else
            {
                int id = Convert.ToInt32(BookIdTextBox.Text);
                string title = BookTitleTextBox.Text;
                string author = AuthorTextBox.Text;
                string publisher = PublisherTextBox.Text;
                int quantity = Convert.ToInt32(QuantityTextBox.Text);
                Book b1 = new Book(id, title, author, publisher, quantity);

                if (Library.maxbook <= 1000)
                {
                    s.AddBook(b1);
                    books.Add(b1);
                    Library.maxbook+=quantity;
                    RentBookIdComboBox.Items.Add(id);
                }
                MessageBox.Show("Book Added Successfully");

                BookIdTextBox.Clear();
                BookTitleTextBox.Clear();
                AuthorTextBox.Clear();
                PublisherTextBox.Clear();
                QuantityTextBox.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowListBox.Items.Clear();
            ShowListBox.Items.Add("Id\tTitle\tAuthor\tQuantity");
            foreach (Book b in books)
            {
                string info = $"{b.GetId()}\t{b.GetTitle()}\t{b.GetAuthor()}\t{b.GetQuantity()}";
                ShowListBox.Items.Add(info);
            }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(RentBookIdComboBox.Text);
            int uid = Convert.ToInt32(RBUSerIdComboBox.Text);
            string date = DuratioComboBox.Text;

            foreach(Book b in books) 
            {
                if(b.GetId()==id)
                {
                    foreach(RegularUser r in regularUsers) 
                    {
                        if(r.Id==uid)
                        { 
                            r.borrowbook(b,date);
                            MessageBox.Show($"{r.Name} borrowed the book.");
                        }
                    }
                }
            }
            
        }
    }
}
