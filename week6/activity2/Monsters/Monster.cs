using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2.Monsters
{
    internal class Monster
    {
        private string name;
        private int difficulty;

        public Monster(string name, int difficulty)
        {
            this.name = name;
            this.difficulty = difficulty;
        }

        public string GetName()
        {
            return name;
        }

        public int GetDifficulty()
        {
            return difficulty;
        }
    }
}
