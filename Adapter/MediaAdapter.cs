using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MediaAdapter : MediaPlayer
    {
        AdvanceMediaPlayer advancemusic;
        public MediaAdapter(string AudioType)
        {
            if (AudioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancemusic = new VlcPlayer();
            }
            else if (AudioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancemusic = new Mp4Player();
            }
        }
        public void play(string audiotype, string filename)
        {
            if (audiotype.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancemusic.playVlc(filename);
            }
            else if (audiotype.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancemusic.playMp4(filename);
            }
        }
    }
}
