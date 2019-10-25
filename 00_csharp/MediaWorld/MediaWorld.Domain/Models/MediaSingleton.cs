namespace   MediaWorld.Domain.Models
{
   public class MediaSingleton
   {

      private static readonly string _instance = "mediaplayer";

      /// <summary>
      /// this is a singleton, i want something that everyone can acces only once. this is a constructor
      /// </summary>
      private MediaSingleton(){}

      /// <summary>
      /// this returns an instance of Mediaplayer
      /// </summary>
      /// <returns></returns>
      public static string GetInstance()
      {
         return _instance;
      }
   }
}