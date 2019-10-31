using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Domain.Factories
{
   public class VideoFactory : IVideoFactory
   {

      public AVideo Create<T>() where T : AVideo, new()
      {
         /*switch (type)
         {
            case "book":
               return new Book();
            case "song":
               return new Song();
            default:
               return null;
         }*/

         return new T();
      }
   }
}