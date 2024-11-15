using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon.Suffix
{
    internal class Vengeance : Suffix
    {
        private Weapon weapon;

        public Vengeance(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int Damage()
        {
            return this.weapon.Damage() + 6;
        }

        public override string GetName()
        {
            return this.weapon.GetName() + " of Vengeance";
        }
    }
}
