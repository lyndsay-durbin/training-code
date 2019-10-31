using MediaWorld.Domain.Abstracts;
using System;

namespace MediaWorld.Domain.Models
{
   public class Movie : AVideo
   {

      public Movie()
      {
         Initialize();
      }

      public Movie (string title, TimeSpan duration, int framerate)
      {
         Initialize(title, duration, framerate);
      }

      private void Initialize (string title="Untitled", TimeSpan duration=new TimeSpan(), int framerate=24)
      {
         Title = title;
         Duration = duration;
         FrameRate = framerate;
      }
   }
}