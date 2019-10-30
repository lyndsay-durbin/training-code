using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace   MediaWorld.Domain.Singleton
{
   /// <summary>
   /// contains the singleton design pattern
   /// </summary>
   public class AudioSingleton : IPlayer
   {

      private static readonly AudioSingleton _instance = new AudioSingleton();

      /// <summary>
      /// contains the constructor
      /// </summary>
      private AudioSingleton(){}

      /// <summary>
      /// returns an instance of MediaSingleton
      /// </summary>
      /// <returns></returns>
      // this was a method and now it is a property
      public static AudioSingleton Instance
      {
         get
         {
            return _instance;
         }
      }

      public void Execute(string command, AMedia media)
      {
         Console.WriteLine(media);
      }

      public bool PowerDown()
      {
         throw new NotImplementedException();
      }

      public bool Powerup()
      {
         throw new NotImplementedException();
      }

      public bool VolumeDown()
      {
         throw new NotImplementedException();
      }

      public bool VolumeMute()
      {
         throw new NotImplementedException();
      }

      public bool VolumeUp()
      {
         throw new NotImplementedException();
      }
   }
}