using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public abstract class Size
   {

      string Large = "Large";
      string Medium = "Medium";
      string Small = "Small";

      string PizzaSize;

      public Size()
      {
         PizzaSize = Medium;
      }

      public Size(string type)
      {
         //parses through to cheeck if the type of crust matches a correct input
         if (string.Equals(type, Small))
            PizzaSize = Small;
         else if (string.Equals(type, Large))
            PizzaSize = Large;
         else PizzaSize = Medium;
      }
   }
}