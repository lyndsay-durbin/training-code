using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Factories;
using System.Collections.Generic;

namespace MediaWorld.Storing.Repositories
{
   public class MediaRepository
   {
      private List<AMedia> _mediaLibrary;
      //or do
      //private List<AMedia> _mediaLibrary =  = new List<AMedia>();
      //but then the if statement in Initialize must be different from the null
      //it must be something that checks the length of the List to be equal to 0

      public List<AMedia> MediaLibrary
      {
         get 
         {
            return _mediaLibrary;
         }
      }
      public MediaRepository()
      {
         Initialize();
      }      

      private List<AMedia> Initialize()
      {
         var audioFactory = new AudioFactory();
         var videoFactory = new VideoFactory();
         if (_mediaLibrary == null)
         {
            _mediaLibrary = new List<AMedia>();
            _mediaLibrary.AddRange(new AMedia[]
            {
               audioFactory.Create<Book>(),
               audioFactory.Create<Song>(),
               videoFactory.Create<Movie>(),
               videoFactory.Create<Photo>()
            });
         }

         return _mediaLibrary;
      }
   }
}