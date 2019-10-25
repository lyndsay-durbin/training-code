namespace   MediaWorld.Domain.Models
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
      public static MediaSingleton GetInstance()
      {
         return _instance;
      }
   }
}