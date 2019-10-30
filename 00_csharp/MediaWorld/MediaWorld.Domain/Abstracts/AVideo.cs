using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts
{
//using AMedia here instead of IControl because of dependency inversion, when we create AMedia 
//we know it will work and Audio and Video are parts of Media
   public abstract class AVideo : AMedia 
   {
      public int FrameRate { get; set; }

      public override bool Pause()
      {
         return false;
      }

      public override bool Forward()
      {
         return true;
      }

      public override bool Rewind()
      {
         return true;
      }
   
      public new bool Stop()
      {
         return true;
      }

      public override string ToString()
      {
         return $"{Title} {Duration}\nFrameRate: {FrameRate}";
      }

   }

}