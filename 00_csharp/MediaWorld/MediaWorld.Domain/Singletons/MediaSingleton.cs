using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace   MediaWorld.Domain.Singleton
{
   /// <summary>
   /// contains the singleton design pattern
   /// </summary>
   public class MediaSingleton : IPlayer
   {

      private static readonly MediaSingleton _instance = new MediaSingleton();



      /// <summary>
      /// contains the constructor
      /// </summary>
      private MediaSingleton(){}

      /// <summary>
      /// returns an instance of MediaSingleton
      /// </summary>
      /// <returns></returns>
      // this was a method and now it is a property
      public static MediaSingleton Instance
      {
         get
         {
            return _instance;
         }
      }

      public void Execute(ButtonDelegate button)
      {
         button();
         button();
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
         return true;
      }

      public bool VolumeMute()
      {
         return true;
      }

      public bool VolumeUp()
      {
         return true;
      }
   }
}