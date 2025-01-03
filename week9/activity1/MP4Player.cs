using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    internal class MP4Player
    {
        public void playMP4(MP4File mP4File)
        {
            decompress(mP4File);
            Console.WriteLine($"Playing MP4 File: {mP4File.Name}");
        }

        public void decompress(MP4File mP4File)
        {
            Console.WriteLine($"Decompressing MP4 File: {mP4File.Name}");
        }
    }
}
