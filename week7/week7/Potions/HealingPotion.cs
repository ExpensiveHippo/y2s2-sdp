using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Potions
{
    internal class HealingPotion : Potion
    {
        private Player player;
        private int healAmount;
        private int actualHealAmount;

        public HealingPotion(Player player, int healAmount, int doses) : base("Healing Potion", doses)
        {
            this.player = player;
            this.healAmount = healAmount;
        }

        public int Drink()
        {
            if (Doses == 0)
            {
                Console.WriteLine($"{Name} has ran out of doses.");
                return 0;
            }

            Doses--;
            int previous = player.Hp;
            if (player.Hp + healAmount > player.MaxHp)
            {
                player.Hp = player.MaxHp;
            }
            else
            {
                player.Hp += healAmount;
            }
            actualHealAmount = player.Hp - previous;
            Console.WriteLine($"Player is healed for {actualHealAmount} HP and now has {player.Hp} HP.");
            return actualHealAmount;
        }

        public void UndoDrink()
        {
            Doses++;
            player.Hp -= actualHealAmount;
            Console.WriteLine($"Undoing drinking {Name} for {actualHealAmount} HP.");
            Console.WriteLine($"\tPlayer now has {player.Hp} HP and {Name} has {Doses} doses left.");
        }
    }
}
