using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public class Crust
   {
      string Thin = "thin";
      string Thick = "thick";
      string Deep = "Deep Dish";
      public string Crust()
      {
         //string CrustType = Large;
         return Thick;
      }

      public string Crust(string type)
      {
         string CrustType;

         //parses through to check if the type of crust matches a correct input
         if (string.Equals(type, Thin))
            CrustType = Thin;
         else if (string.Equals(type, Deep))
            CrustType = Deep;
         else CrustType = Thick;

         return CrustType;
      }
   }
}