using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class Buyer
    {
        private string _name;
        public string name { 
            get { return _name; } 
            set { _name = value; } 
        }
        public Buyer()
        {
            _name = "Anonymous";
        }
        public Buyer(string name)
        {
            _name = name;
        }
    }
}
