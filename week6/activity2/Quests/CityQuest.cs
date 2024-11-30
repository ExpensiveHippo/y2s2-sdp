using activity2.QuestFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2.Quests
{

    internal class CityQuest : Quest
    {
        QuestFactory factory;
        public CityQuest(QuestFactory fac) : base()
        {
            this.factory = fac;
        }

        public override void prepare()
        {
            base.monster = factory.CreateMonster("city");
            base.timeLimit = factory.GetTimeLimit();
            base.number = factory.GetNumber();
            base.reward = base.calculateReward();
        }
    }
}
