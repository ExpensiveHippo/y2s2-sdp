using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon
{
    internal class Mace : Weapon
    {
        public Mace()
        {
            base.name = "Mace";
        }

        public override int Damage()
        {
            return 5;
        }
    }
}
