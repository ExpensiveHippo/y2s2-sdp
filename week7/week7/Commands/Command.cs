using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7.Commands
{
    internal interface Command
    {
        public void Execute();
        public void Undo();
    }
}
