using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Factories;
using System.Collections.Generic;
using MediaWorld.Domain;

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

      public void Save()
      {
         var fs = new FileSystemConnector();
         fs.WriteXml(_mediaLibrary);
      }

      public void Add(AMedia media)
      {
         _mediaLibrary.Add(media);
      }

      public void Update(AMedia media)
      {
         var mi = _mediaLibrary.Find(m => m.Title == media.Title);
         mi  = media;
         Save();
      }

      private List<AMedia> Initialize()
      {
         var audioFactory = new AudioFactory();
         var videoFactory = new VideoFactory();
         if (_mediaLibrary == null)
         {
            _mediaLibrary = new List<AMedia>();
            
            _mediaLibrary.AddRange(new FileSystemConnector().ReadXml());
         }

         return _mediaLibrary;
      }
   }
}