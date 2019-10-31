using System;
using MediaWorld.Domain.Abstracts;
//using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Singleton;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Factories;
using MediaWorld.Storing.Repositories;

namespace MediaWorld.Client
{
   /// <summary>
   /// contains the start point
   /// </summary>
    internal class Program
    {

       private static MediaRepository _repository = new MediaRepository();

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
            /*var audioFactory = new AudioFactory();  
            var videoFactory = new VideoFactory();      
            AMedia song = audioFactory.Create<Song>();
            AMedia book = audioFactory.Create<Book>();
            AMedia movie = new Movie();*/

            foreach (var item in _repository.MediaLibrary)
            {
               mediaPlayer.Execute(item.Play);
            }

            //mediaPlayer.Execute("play", song);
            //mediaPlayer.Execute("play", movie); 
        }
    }
}
