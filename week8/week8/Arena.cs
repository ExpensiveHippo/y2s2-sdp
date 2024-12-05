using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week8
{
    internal class Arena
    {
        private GameEntity allEntities;
        public Arena(GameEntity entity)
        {
            allEntities = entity;
        }

        public void AddEntity(GameEntity entity)
        {
            allEntities.Add(entity);
        }

        public void RemoveEntity(GameEntity entity)
        {
            allEntities.Remove(entity);
        }

        public void Print()
        {
            Console.WriteLine("Arena: ");
            allEntities.Print(0);
        }
    }
}
