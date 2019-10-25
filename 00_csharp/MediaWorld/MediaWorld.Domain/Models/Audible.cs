namespace MediaWorld.Domain.Models
{
   public class Audible : Music
   {
      public string Narrator { get; set; }

      public override string ToString()
      {
         return $"{BookSpeaker}";
      }


   }

}