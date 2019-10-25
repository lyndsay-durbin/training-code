using System;
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
            var mediaPlayer = MediaSingleton.GetInstance();          
            Music s = new Song();
            Music a = new Audible();

            mediaPlayer.Play(s);
            mediaPlayer.Play(a); 
        }
    }
}
