using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Potions
{
    internal abstract class Potion
    {
        private string name;
        private int doses;

        public string Name
        {
            get { return name; }
        }

        public int Doses
        {
            get { return doses; }
            set { doses = value; }
        }

        public Potion(string name, int doses)
        {
            this.name = name;
            this.doses = doses;
        }
    }
}
