using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
   public class Photo : AMedia
   {
      public override bool Forward()
      {
         throw new System.NotImplementedException();
      }

      public override bool Rewind()
      {
         throw new System.NotImplementedException();
      }
   }
}