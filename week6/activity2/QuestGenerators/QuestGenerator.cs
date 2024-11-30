using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.Quests;

namespace activity2.QuestGenerators
{
    internal abstract class QuestGenerator
    {
        public Quest LaunchQuest(string type)
        {
            Quest quest = CreateQuest(type);
            quest.prepare();
            quest.calculateReward();
            Console.WriteLine(quest.GetDescription());
            return quest;
        }

        public abstract Quest CreateQuest(string type);
    }
}
