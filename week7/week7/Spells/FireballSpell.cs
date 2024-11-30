using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Spells
{
    internal class FireballSpell : Spell
    {
        private Player caster;
        
        public FireballSpell(Player caster, int cost) : base("Fireball", cost) {
            this.caster = caster;
        }

        public void Effect()
        {
            if (caster.Mp < Cost)
            {
                Console.WriteLine($"Player does not have enough mana to cast {Name}.");
            }
            else
            {
                caster.Mp -= Cost;
                Console.WriteLine($"Player casted {Name} and dealt {caster.MagicPower * 2} damage.");
            }
        }     
        
        public void UndoEffect()
        {
            caster.Mp += Cost;
            Console.WriteLine($"Undoing casting {Name} spell for {caster.MagicPower * 2} damage.");
            Console.WriteLine($"\tPlayer now has ${caster.Mp} MP.");
        }
    }
}
