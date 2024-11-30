using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity1.QuestGenerators;
using activity1.Quests;
using week6.Quests;

namespace week6.QuestGenerators
{
    internal class RivendellQuestGenerator : QuestGenerator
    {
        public override Quest CreateQuest(string type)
        {
            type = type.ToLower();
            if (type == "village")
            {
                return new RivendellVillageQuest();
            }
            else if (type == "city")
            {
                return new RivendellCityQuest();
            }
            else
            {
                throw new Exception("Invalid quest type");
            }
        }
    }
}
