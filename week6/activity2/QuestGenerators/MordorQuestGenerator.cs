using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.Quests;
using activity2.QuestFactories;

namespace activity2.QuestGenerators
{
    internal class MordorQuestGenerator : QuestGenerator
    {
        private MordorQuestFactory factory;

        public MordorQuestGenerator()
        {
           factory = new MordorQuestFactory();
        }
        public override Quest CreateQuest(string type)
        {
            type = type.ToLower();
            if (type == "village")
            {
                return new VillageQuest(factory);
            }
            else if (type == "city")
            {
                return new CityQuest(factory);
            }
            else
            {
                throw new Exception("Invalid quest type");
            }
        }
    }
}
