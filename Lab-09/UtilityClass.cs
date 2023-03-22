using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    internal static class UtilityClass
    {
        static string name;
        internal static List<User> users= new List<User>();
        public static void Name(string n)
        { name=n; }
        public static string Name() { return name; }

        //public string name = "";
    }
}
