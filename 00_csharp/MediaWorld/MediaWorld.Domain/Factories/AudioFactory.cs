using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Domain.Factories
{
   public class AudioFactory : IAudioFactory
   {

      public AAudio Create<T>() where T : AAudio, new()
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