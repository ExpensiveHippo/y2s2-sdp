using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal abstract class GameEntity
    {
        public virtual string Name { get => throw new NotSupportedException(); }

        public virtual void Add(GameEntity entity)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(GameEntity entity)
        {
            throw new NotSupportedException();
        }

        public virtual GameEntity GetChild(int position)
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual void Print(int level)
        {
            throw new NotSupportedException();
        }
    }
}
