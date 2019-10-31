using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
   public class Photo : AVideo
   {
      public Photo()
      {
         Initialize();
      }

      public Photo(string Title, TimeSpan duration, int framerate)
      {
         Initialize(Title, duration, framerate);
      }

      private void Initialize(string title="Untitled", TimeSpan duration=new TimeSpan(), int framerate=0)
      {
         Title = title;
         Duration = duration;
         FrameRate = framerate;
      }
   }
}