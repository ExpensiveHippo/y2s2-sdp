using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using activity2.Monsters;
using activity2.QuestFactories;

namespace activity2.Quests
{
    internal abstract class Quest
    {
        protected float reward;
        protected int timeLimit;
        protected int number;
        protected Monster monster;

        public virtual string GetDescription()
        {
            return $"Kill {number} {monster.GetName()} in {timeLimit} days for {reward} gold pieces.";
        }

        public abstract void prepare();

        public float calculateReward()
        {
            return monster.GetDifficulty() * number - timeLimit;
        }
    }
}
