using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon.Suffix
{
    internal class Justice : Suffix
    {
        private Weapon weapon;

        public Justice(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage()
        {
            return this.weapon.Damage() + 4;
        }

        public override string GetName()
        {
            return weapon.GetName() + " of Justice";
        }
    }
}
