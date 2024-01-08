using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class NotBorrowed:Exception
    {
        //public NotBorrowed() { }

        public NotBorrowed() : base("Book Was Not Borrowed.")
        { }
        
    }
}
