using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 99;
            double myDouble = 70.50;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32 (myDouble));
            Console.WriteLine(Convert.ToString(myBool));
            Console.ReadKey();

        }
        
    }
}
