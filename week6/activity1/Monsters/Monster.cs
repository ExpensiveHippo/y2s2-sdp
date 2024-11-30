using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity1.Monsters
{
    internal class Monster
    {
        private string name;

        public Monster(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
