using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    internal abstract class MediaFile
    {
        private string name;

        public string Name { get => name; }

        public MediaFile(string name)
        {
            this.name = name;
        }
    }
}
