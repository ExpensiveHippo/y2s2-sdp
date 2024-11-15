using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon.Prefix
{
    internal class Icy : Prefix
    {
        private Weapon weapon;

        public Icy(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage()
        {
            return this.weapon.Damage() + 3;
        }

        public override string GetName()
        {
            return "Icy " + this.weapon.GetName();
        }
    }
}
