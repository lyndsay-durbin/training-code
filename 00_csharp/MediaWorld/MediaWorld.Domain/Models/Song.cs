namespace MediaWorld.Domain.Models
{
   public class Song : Music
   {
      public string Lyrics { get; set; }

      public override string ToString()
      {
         return $"{Artist} {Title}";
      }

   }
}