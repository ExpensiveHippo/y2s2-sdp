using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity1.Quests;

namespace activity1.QuestGenerators
{
    internal abstract class QuestGenerator
    {
        public Quest LaunchQuest(string type)
        {
            Quest quest = CreateQuest(type);
            Console.WriteLine(quest.GetDescription());
            return quest;
        }

        public abstract Quest CreateQuest(string type);

    }
}
