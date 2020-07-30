using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdvanceMediaPlayer ad = new VlcPlayer();
            //ad.playVlc("music");

            AudioPlayer aud = new AudioPlayer();
            aud.play("mp3","Allah Ho.mp3");
            aud.play("mp4", "Pakistan.mp4");
            aud.play("vlc", "Ye Zammen.vlc");
            aud.play("avi", "Ho.avi");

            Console.ReadLine();
        }
    }
}
