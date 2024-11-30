using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Spells
{
    internal abstract class Spell
    {
        private string name;
        private int cost;

        public string Name { get => name; }
        public int Cost { get => cost; }
        public Spell(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
