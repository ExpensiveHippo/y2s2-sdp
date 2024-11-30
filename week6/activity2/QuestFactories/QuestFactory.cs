using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.Monsters;

namespace activity2.QuestFactories
{
    internal abstract class QuestFactory
    {
        public abstract Monster CreateMonster(string questType);
        public abstract int GetTimeLimit();
        public abstract int GetNumber();
    }
}
