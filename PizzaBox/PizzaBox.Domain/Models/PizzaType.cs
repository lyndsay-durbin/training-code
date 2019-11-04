using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
   public class PizzaType
   {
      /// <summary>
      /// creates a meat pizza
      /// </summary>
      public void MeatP()
      {
         Pizza p = new Pizza("thick");
         AddTopping("pepperoni");
         AddTopping("sausage");
         AddTopping("bacon");
      }

      /// <summary>
      /// creates a veggie pizza
      /// </summary>
      public void VeggieP()
      {
         Pizza p = new Pizza("thick");
         AddTopping("pepper");
         AddTopping("onion");
         AddTopping("olives");
      }

      /// <summary>
      /// creates a cheese pizza
      /// </summary>
      public void CheeseP()
      {
         Pizza p = new Pizza("thick");
         AddTopping("extra cheese");
      }
   }
}