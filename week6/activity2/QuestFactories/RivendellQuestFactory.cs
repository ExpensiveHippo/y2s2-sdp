using activity2.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2.QuestFactories
{
    internal class RivendellQuestFactory : QuestFactory
    {
        public override Monster CreateMonster(string questType)
        {
            questType = questType.ToLower();
            if (questType == "village")
            {
                return new Pixie();
            }
            else if (questType == "city")
            {
                return new Thief();
            }
            else
            {
                throw new Exception("No monster in this area");
            }
        }

        public override int GetTimeLimit()
        {
            return 5;
        }

        public override int GetNumber()
        {
            return 3;
        }
    }
}
