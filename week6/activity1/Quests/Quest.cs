using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity1.Monsters;

namespace activity1.Quests
{
    internal abstract class Quest
    {
        protected int reward;
        protected int timeLimit;
        protected int number;
        protected Monster monster;

        public Quest(int reward, int timeLimit, int number, Monster monster)
        {
            this.reward = reward;
            this.timeLimit = timeLimit;
            this.number = number;
            this.monster = monster;
        }

        public virtual string GetDescription()
        {
            return $"Kill {number} {monster.getName()} in {timeLimit} days for {reward} gold pieces.";
        }
    }
}
