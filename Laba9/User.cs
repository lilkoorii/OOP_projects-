﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class User
    {
        public string Name;
        public User(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
