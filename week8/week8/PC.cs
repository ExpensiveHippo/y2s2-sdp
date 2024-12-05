using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal class PC : GameEntity
    {
        private string name;
        private string profession;

        public override string Name { get => name; }

        public PC(string name, string profession)
        {
            this.name = name;
            this.profession = profession;
        }

        public override string GetDescription()
        {
            return $"{name} the {profession}";
        }

        public override void Print(int level)
        {
            Console.WriteLine($"{new String(' ', level * 4)}{name} the {profession}");
        }
    }
}
