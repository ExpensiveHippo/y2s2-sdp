using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon
{
    internal class Sword : Weapon
    {
        public Sword()
        {
            base.name = "Sword";
        }

        public override int Damage()
        {
            return 6;
        }
        
    }
}
