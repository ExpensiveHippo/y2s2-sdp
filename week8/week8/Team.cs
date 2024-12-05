using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal class Team : GameEntity
    {
        private string name;
        private List<GameEntity> teamEntities;

        public override string Name { get => name; }

        public Team(string name)
        {
            this.name = name;
            teamEntities = new List<GameEntity>();
        }

        public override void Add(GameEntity entity)
        {
            teamEntities.Add(entity);
            Console.WriteLine($"{entity.GetDescription()} joins {Name}");
        }

        public override void Remove(GameEntity entity) {
            teamEntities.Remove(entity);
            Console.WriteLine($"{entity.GetDescription()} leaves {Name}");
        }

        public override GameEntity GetChild(int position)
        {
            return teamEntities[position];
        }

        public override void Print(int level)
        {
            if (level > 0)
            {
                Console.WriteLine($"{new String(' ', level * 4)}Team {name}:");
            }
            
            foreach (GameEntity entity in teamEntities)
            {
                entity.Print(level + 1);
            }
        }

        public override string GetDescription()
        {
            return $"Team {Name}";
        }
    }
}
