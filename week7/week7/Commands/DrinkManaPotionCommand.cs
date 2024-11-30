using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week7.Potions;

namespace week7.Commands
{
    internal class DrinkManaPotionCommand : Command
    {
        private ManaPotion manaPotion;

        public DrinkManaPotionCommand(ManaPotion manaPotion)
        {
            this.manaPotion = manaPotion;
        }
        public void Execute()
        {
            manaPotion.Drink();
        }

        public void Undo()
        {
            manaPotion.UndoDrink();
        }
    }
}
