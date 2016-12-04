using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Pirates_Bay.CreationalPatterns
{
    public class SoundsGenerator
    {
        private readonly MediaPlayer _canonShotPlayer;
        private readonly MediaPlayer _swimSoundPlayer;
        private readonly MediaPlayer _musicPlayer;
        private readonly MediaPlayer _coinsDropPlayer;
        private readonly MediaPlayer _victorySongPlayer;

        private SoundsGenerator()
        {
            _canonShotPlayer = new MediaPlayer() ;
            _musicPlayer = new MediaPlayer();
            _swimSoundPlayer = new MediaPlayer();
            _coinsDropPlayer = new MediaPlayer();
            _victorySongPlayer = new MediaPlayer();

            _canonShotPlayer.Open(new Uri(@"Resources\Sounds\DepthCharge.mp3", UriKind.Relative));
            _swimSoundPlayer.Open(new Uri(@"Resources\Sounds\Wave.mp3", UriKind.Relative));
            _coinsDropPlayer.Open(new Uri(@"Resources\Sounds\CoinsDrop.mp3", UriKind.Relative));
            _victorySongPlayer.Open(new Uri(@"Resources\Sounds\MOBY - Lift Me Up.mp3", UriKind.Relative));
        }

        public void PlayCanonShot()
        {
            _canonShotPlayer.Position = new TimeSpan(0,0,0,0);
            _canonShotPlayer.Play();
        }

        public void PlayMusic()
        {
            _musicPlayer.Play();
        }

        public void PauseMusic()
        {
            _musicPlayer.Pause();
        }

        public void PlayWavesSound()
        {
            _swimSoundPlayer.Position = new TimeSpan(0,0,0,0);
            _swimSoundPlayer.Play();
        }

        public void PlayCoinsDrop()
        {
            _coinsDropPlayer.Position = new TimeSpan(0,0,0,0);
            _coinsDropPlayer.Play();
        }

        public void PlayVictorySound()
        {
            _victorySongPlayer.Position = new TimeSpan(0,0,0,0);
            _victorySongPlayer.Play();
        }

        public void StopVictorySound()
        {
            _victorySongPlayer.Stop();
        }

        private static SoundsGenerator _instance;

        public void SetVolume(double volume)
        {
            _canonShotPlayer.Volume = volume;
            _musicPlayer.Volume = volume;
            _swimSoundPlayer.Volume = volume;
            _coinsDropPlayer.Volume = volume;
            _victorySongPlayer.Volume = volume;
        }

        public static SoundsGenerator Instance
        {
            get
            {
                return _instance;
            }
        }

        static SoundsGenerator()
        {
            _instance = new SoundsGenerator();
        }
    }
}
