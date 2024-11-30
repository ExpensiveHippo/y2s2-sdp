using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week7.Spells;

namespace week7.Commands
{
    internal class CastFireballCommand : Command
    {
        private FireballSpell fireballSpell;

        public CastFireballCommand(FireballSpell fireballSpell)
        {
            this.fireballSpell = fireballSpell;
        }
        public void Execute()
        {
            fireballSpell.Effect();
        }

        public void Undo()
        {
            fireballSpell.UndoEffect();
        }
    }
}
