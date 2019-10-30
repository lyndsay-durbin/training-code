using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
   public class Movie : AVideo
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