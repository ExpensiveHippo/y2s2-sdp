using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity1
{
    internal class Barbarian : Character
    {
        public Barbarian() : base() { }
        public Barbarian(Weapon weapon) : base(weapon)
        {
        }

        public override void fight()
        {
            Console.Write("Barbarian: ");
            if (weapon != null)
            {
                weapon.attack();
            }
            else
            {
                Console.WriteLine("No weapon equipped.");
            }
        }
    }
}
