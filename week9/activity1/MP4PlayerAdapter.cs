using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    internal class MP4PlayerAdapter : MediaPlayer
    {
        private MP4Player mp4Player;

        public MP4PlayerAdapter(MP4Player mp4Player)
        {
            this.mp4Player = mp4Player;
        }

        public void play(MediaFile mediaFile)
        {
            mp4Player.playMP4((MP4File)mediaFile);
        }
    }
}
