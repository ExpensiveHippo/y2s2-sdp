using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity1
{
    internal abstract class Character
    {
        private Weapon? _weapon;
        public Weapon? weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public Character()
        {
            _weapon = null;
        }

        public Character(Weapon weapon)
        {
            _weapon = weapon;
        }

        public abstract void fight();
    }
}
