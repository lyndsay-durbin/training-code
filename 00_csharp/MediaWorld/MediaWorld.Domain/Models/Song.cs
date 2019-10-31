using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
   public class Song : AAudio
   {

      public Song()
      {
         Initialize();
      }

      public Song(string title, TimeSpan duration, int bitrate)
      {
         Initialize(title, duration, bitrate);
      }

      private void Initialize(string title="Untitled", TimeSpan duration=new TimeSpan(), int bitrate=256)
      {
         Title = title;
         Duration = duration;
         BitRate = bitrate;
      }
   }
}