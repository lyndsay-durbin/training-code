using System;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts
{

   public abstract class AMedia : IControl
   {

      public virtual bool Pause()
      {
         throw new System.NotImplementedException();
      }

      public virtual bool Play()
      {
         throw new System.NotImplementedException();
      }

      public bool Stop()
      {
         throw new System.NotImplementedException();
      }

      public override string ToString()
      {
         return $"{this}";
      }

      public abstract bool Rewind();

      public abstract bool Forward();

      public TimeSpan Duration { get; set; }

      public string Title {get; set;}

   }

}