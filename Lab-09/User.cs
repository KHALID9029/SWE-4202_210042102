﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    internal class User
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public User(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }
    }
}
