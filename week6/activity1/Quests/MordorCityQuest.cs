using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity1.Quests;
using week6.Monsters;

namespace week6.Quests
{
    internal class MordorCityQuest : Quest
    {
        public MordorCityQuest() : base(20, 7, 4, new Bandit()) { }
    }
}
