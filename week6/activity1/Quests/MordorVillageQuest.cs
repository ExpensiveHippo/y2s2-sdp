using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity1.Quests;
using week6.Monsters;

namespace week6.Quests
{
    internal class MordorVillageQuest : Quest
    {
        public MordorVillageQuest() : base(10, 5, 6, new GiantRat()) { }

    }
}
