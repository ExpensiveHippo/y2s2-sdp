using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity2.Monsters;

namespace activity2.QuestFactories
{
    internal class MordorQuestFactory : QuestFactory
    {
        public override Monster CreateMonster(string questType)
        {
            questType = questType.ToLower();
            if (questType == "village")
            {
                return new GiantRat(); 
            } 
            else if (questType == "city")
            {
                return new Bandit();
            } else
            {
                throw new Exception("No monster for this type");
            }
        }

        public override int GetTimeLimit()
        {
            return 3;
        }

        public override int GetNumber()
        {
            return 5;
        }
    }
}
