using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTechnique
{
    public class SoundManager
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public void SetPlayFile(string url)
        {
            player.URL = url;
            player.controls.play();
        }

        public void SetFile(string url)
        {
            player.URL = url;
        }
        
        public void PlayFile()
        {
            if (player.URL != null)
            {
                player.controls.play();
            }
        }
        public void Stop()
        {
            player.controls.stop();
        }
        public SoundManager(string url)
        {
            player.URL = url;
            player.controls.stop();
            player.settings.setMode("loop", true);
        }
    }
}
