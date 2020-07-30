using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Mp4Player : AdvanceMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing MP4 file . Name " + fileName);

        }
        public void playVlc(string fileName)
        {

        }
    }
}
