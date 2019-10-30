using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
   public class Book : AAudio
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