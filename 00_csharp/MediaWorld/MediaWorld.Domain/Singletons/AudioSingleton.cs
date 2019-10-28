using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace   MediaWorld.Domain.Singleton
{
   /// <summary>
   /// contains the singleton design pattern
   /// </summary>
   public class AudioSingleton
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
   }
}