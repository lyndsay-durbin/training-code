using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singleton
{
   public class VideoSingleton : IPlayer
   {
      public static readonly VideoSingleton _instance = new VideoSingleton();

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