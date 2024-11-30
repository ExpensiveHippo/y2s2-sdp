using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.QuestFactories;

namespace activity2.Quests
{
    internal class VillageQuest : Quest 
    {
        QuestFactory factory;

        public VillageQuest(QuestFactory factory) : base()
        {
            this.factory = factory;
        }

        public override void prepare()
        {
            base.monster = factory.CreateMonster("village");
            base.timeLimit = factory.GetTimeLimit();
            base.number = factory.GetNumber();
            base.reward = base.calculateReward();
        }
    }
}
