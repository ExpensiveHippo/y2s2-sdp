using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Commands
{
    internal class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("No command");
        }

        public void Undo()
        {
            Console.WriteLine("No command");
        }
    }
}
