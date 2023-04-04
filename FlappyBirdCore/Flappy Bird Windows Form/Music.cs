using System.IO;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Flappy_Bird_Windows_Form
{
    static class Music
    {
        private static WindowsMediaPlayer windowsMedia = new WindowsMediaPlayer();
        private static string pathToMusicFolder = Path.Combine(Application.StartupPath, "Music");
        private static string pathToBackgroundMusic = Path.Combine(pathToMusicFolder, "music_background.wav");
        private static string urlMusicEndGame = Path.Combine(pathToMusicFolder, "end_game_sound.wav");
        private static string urlMusicDuringPlay = Path.Combine(pathToMusicFolder, "music_during_play.wav");

        private static SoundPlayer player;
        public static void Play()
        {
            player = new SoundPlayer(pathToBackgroundMusic);
            player.Play();
        }

        public static void Stop()
        {
            player = new SoundPlayer(pathToBackgroundMusic);
            player.Stop();
        }

        public static void PlayEndGame()
        {
            windowsMedia.URL = (urlMusicEndGame);
            windowsMedia.controls.play();
        }
        public static void DuringPlayGame()
        {
            windowsMedia.URL = (urlMusicDuringPlay);
            windowsMedia.controls.play();
        }


    }
}
