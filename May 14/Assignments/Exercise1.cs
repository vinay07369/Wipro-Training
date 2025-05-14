using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IMusicPlayer
    { 
        public void Play(string song);
        public void Pause();
        public void Stop();
    }

    class SpotifyPlayer : IMusicPlayer
    {
        public void Play(string song) => Console.WriteLine($"Playing {song} on Spotify");
        public void Pause() => Console.WriteLine("Spotify playback paused");
        public void Stop() => Console.WriteLine("Spotify playback stopped");
    }

    class AppleMusicPlayer : IMusicPlayer
    {
        public void Play(string song) => Console.WriteLine($"Playing {song} on AppleMusic");
        public void Pause() => Console.WriteLine("AppleMusic playback paused");
        public void Stop() => Console.WriteLine("AppleMusic playback stopped");
    }

    class Program
    {
        static void Main()
        {
            IMusicPlayer player;

            Console.WriteLine("Spotify App");
            Console.WriteLine("-----------------");
            player = new SpotifyPlayer();
            player.Play("Naa Ready");
            player.Pause();
            player.Stop();

            Console.WriteLine("AppleMusic Player App");
            Console.WriteLine("------------------------");
            player = new AppleMusicPlayer();
            player.Play("TVK Anthem");
            player.Pause();
            player.Stop();
        }
    }
}