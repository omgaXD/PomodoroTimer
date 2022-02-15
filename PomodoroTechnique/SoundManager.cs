using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTechnique
{
    public interface SoundManager
    {
        void SetPlayFile(string url);
        void SetFile(string url);
        void PlayFile();
        void Stop();
    }
    public class SoundManagerSP : SoundManager
    {
        SoundPlayer player = new SoundPlayer();
        public void SetPlayFile(string url)
        {
            player.SoundLocation = url;
            player.PlayLooping();
        }
        public void SetFile(string url)
        {
            player.SoundLocation = url;
        }
        public void PlayFile()
        {
            if (player.SoundLocation != null)
            {
                player.PlayLooping();
            }
        }
        public void Stop()
        {
            if (player != null && player.SoundLocation != null && player.Stream != null)
                player.Stop();
            
        }
        public SoundManagerSP(string url)
        {
            player.SoundLocation = url;
        }
    }
    public class SoundManagerWMP : SoundManager
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
        public SoundManagerWMP(string url)
        {
            player.URL = url;
            player.controls.stop();
            player.settings.setMode("loop", true);
        }
    }
}
