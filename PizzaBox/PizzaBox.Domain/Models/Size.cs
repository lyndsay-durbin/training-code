using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
   public abstract class Size
   {

      string Large = "Large";
      string Medium = "Medium";
      string Small = "Small";

      public string PizzaSize { get; set; }
      public double PizzaPrice { get; set; }
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

      public void PizzaPricing()
      {
         if (PizzaSize==Small)
            PizzaPrice = 6.00;
         else if (PizzaSize ==Medium)
            PizzaPrice = 7.50;
         else if(PizzaSize == Large)
            PizzaPrice = 9.00;

         int num = PizzaType.NumToppings.get;

         PizzaPrice = PizzaPrice + (double)num;
      }
   }
}