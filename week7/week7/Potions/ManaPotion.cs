using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace week7.Potions
{
    internal class ManaPotion : Potion
    {
        private Player player;
        private int amountHealed;
        private int actualAmountHealed; 
        public ManaPotion(Player player, int amountHealed, int doses) : base("Mana Potion", doses)
        {
            this.player = player;
            this.amountHealed = amountHealed;
            this.actualAmountHealed = 0;
        }

        public int Drink()
        {
            if (Doses == 0)
            {
                Console.WriteLine($"{Name} has ran out of doses.");
                return 0;
            }

            Doses--;
            int previous = player.Mp;
            if (player.Mp + amountHealed > player.MaxMp)
            {
                player.Mp = player.MaxMp;
            }
            else
            {
                player.Mp += amountHealed;
            }
            actualAmountHealed = player.Mp - previous;
            Console.WriteLine($"Player is healed for {actualAmountHealed} MP and now has {player.Mp} MP.");
            return actualAmountHealed;
        }

        public void UndoDrink()
        {
            player.Mp -= actualAmountHealed;
            Doses++;
            Console.WriteLine($"Undoing drinking {Name} for {actualAmountHealed} MP.");
            Console.WriteLine($"\tPlayer now has {player.Mp} MP and {Name} has {Doses} doses left.");
        }
    }
}
