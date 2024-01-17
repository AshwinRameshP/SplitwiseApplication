using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication.Models
{
    internal class User
    {
        private String name;
        public User(String name) { this.name = name; }
        public String getName() { return name; }

    }
}
