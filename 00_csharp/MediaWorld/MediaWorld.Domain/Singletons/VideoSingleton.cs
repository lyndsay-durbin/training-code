using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singleton
{
   public class VideoSingleton
   {
      public static readonly VideoSingleton _instance = new VideoSingleton();

      
   }
}