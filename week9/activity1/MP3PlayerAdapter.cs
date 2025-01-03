using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    internal class MP3PlayerAdapter : MediaPlayer
    {
        private MP3Player mp3Player;

        public MP3PlayerAdapter(MP3Player mp3Player)
        {
            this.mp3Player = mp3Player;
        }

        public void play(MediaFile mediaFile)
        {
            mp3Player.playMP3(mediaFile.Name);
        }
    }
}
