using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public class Crust
   {
      string Thin = "thin";
      string Thick = "thick";
      string Deep = "deep dish";
      public string CrustType { get; set; }
      public Crust()
      {
         CrustType = Thick;
      }

      public Crust(string type)
      {
         string temp;

         //parses through to check if the type of crust matches a correct input
         if (string.Equals(type, Thin))
            temp = Thin;
         else if (string.Equals(type, Deep))
            temp = Deep;
         else temp = Thick;

         CrustType = temp;
      }
   }
}