using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Singleton;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client
{
   /// <summary>
   /// contains the start point
   /// </summary>
    internal class Program
    {
       /// <summary>
       /// starts the application
       /// </summary>
        private static void Main()
        {
            Play();
        }

        private static void Play()
        {
            var mediaPlayer = MediaSingleton.Instance;          
            AMedia song = new Song();
            AMedia movie = new Movie();

            mediaPlayer.Execute("play", song);
            mediaPlayer.Execute("play", movie); 
        }
    }
}
