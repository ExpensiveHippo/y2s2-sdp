using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon
{
    internal class Dagger : Weapon
    {
        public Dagger()
        {
            base.name = "Dagger";
        }

        public override int Damage()
        {
            return 4;
        }
    }
}
