using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.QuestFactories;
using activity2.Quests;

namespace activity2.QuestGenerators
{
    internal class RivendellQuestGenerator : QuestGenerator
    {
        private RivendellQuestFactory factory;

        public RivendellQuestGenerator()
        {
            factory = new RivendellQuestFactory();
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
