using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace   MediaWorld.Domain.Singleton
{
   /// <summary>
   /// contains the singleton design pattern
   /// </summary>
   public class MediaSingleton
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

      public void Execute(string command, AMedia media)
      {
         Console.WriteLine(media);
      }
   }
}