using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;
        public void play(string AudioType,string fileName)
        {
            if (AudioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Playing mp3 file.Name: "+fileName);
            }
            else if (AudioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || AudioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(AudioType);
                mediaAdapter.play(AudioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid Media"+ AudioType+"Format not supported"
                    );
            }

        }

    }
}
