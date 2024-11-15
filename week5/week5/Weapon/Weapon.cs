using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Weapon
{
    internal abstract class Weapon
    {
        protected string name = "Unarmed";

        public abstract int Damage();

        public virtual string GetName() { return name; }
    }
}
