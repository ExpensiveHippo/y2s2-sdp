using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week7.Spells;

namespace week7.Commands
{
    internal class CastHealingCommand : Command
    {
        private HealingSpell healingSpell;

        public CastHealingCommand(HealingSpell healingSpell)
        {
            this.healingSpell = healingSpell;
        }
        public void Execute()
        {
            healingSpell.Effect();
        }

        public void Undo()
        {
            healingSpell.UndoEffect();
        }
    }
}
