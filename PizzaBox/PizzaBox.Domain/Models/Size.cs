using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public abstract class Size : IPizza
   {

      string Large = "Large";
      string Medium = "Medium";
      string Small = "Small";

      public string Size()
      {
         return Medium;
      }

      public string Size(string type)
      {
         string PSize;

         //parses through to cheeck if the type of crust matches a correct input
         if (string.Equals(type, Small))
            PSize = Small;
         else if (string.Equals(type, Large))
            PSize = Large;
         else PSize = Medium;

         return PSize;
      }
   }
}