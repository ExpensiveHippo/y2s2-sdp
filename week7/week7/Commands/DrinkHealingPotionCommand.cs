using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week7.Potions;

namespace week7.Commands
{
    internal class DrinkHealingPotionCommand : Command
    {
        private HealingPotion healingPotion;

        public DrinkHealingPotionCommand(HealingPotion healingPotion)
        {
            this.healingPotion = healingPotion;
        }
        public void Execute()
        {
            healingPotion.Drink();
        }

        public void Undo()
        {
            healingPotion.UndoDrink();
        }
    }
}
