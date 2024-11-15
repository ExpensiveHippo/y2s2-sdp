using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon.Suffix
{
    internal class Pain : Suffix
    {
        private Weapon weapon;
        public Pain(Weapon weapon) 
        {
            this.weapon = weapon;
        }

        public override int Damage()
        {
            return this.weapon.Damage() + 2;
        }

        public override string GetName()
        {
            return this.weapon.GetName() + " of Pain";
        }
    }
}
