using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Spells
{
    internal class HealingSpell : Spell
    {
        private Player caster;
        private int amountHealed;

        public HealingSpell(Player caster, int cost) : base("Healing", cost)
        {
            this.caster = caster;
            this.amountHealed = 0;
        }

        public void Effect()
        {
            if (caster.Mp < Cost)
            {
                Console.WriteLine($"Player does not have enough mana to cast {Name}.");
                return;
            }

            int previousHP = caster.Hp;
            if (caster.Hp + caster.MagicPower > caster.MaxHp)
            {
                caster.Hp = caster.MaxHp;
            }
            else
            {
                caster.Hp += caster.MagicPower;
            }
            amountHealed = caster.Hp - previousHP;
            caster.Mp -= Cost;
            

            Console.WriteLine($"Player casted {Name} and healed {amountHealed} HP.");
        }

        public void UndoEffect()
        {
            caster.Mp += Cost;
            caster.Hp -= amountHealed;
            Console.WriteLine($"Undoing casting {Name} spell for {amountHealed} HP.");
            Console.WriteLine($"\tPlayer now has {caster.Hp} HP and {caster.Mp} MP.");
        }
    }
}
