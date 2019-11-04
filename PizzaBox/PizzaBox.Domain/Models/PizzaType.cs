using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
   public class PizzaType
   {
      public int NumToppings { get; set; }
      
      /// <summary>
      /// creates a meat pizza
      /// </summary>
      public void MeatP()
      {
         Pizza p = new Pizza("thick");
         p.AddTopping("pepperoni");
         p.AddTopping("sausage");
         p.AddTopping("bacon");
         NumToppings =3;
      }

      /// <summary>
      /// creates a veggie pizza
      /// </summary>
      public void VeggieP()
      {
         Pizza p = new Pizza("thick");
         p.AddTopping("pepper");
         p.AddTopping("onion");
         p.AddTopping("olives");
         NumToppings =3;
      }

      /// <summary>
      /// creates a cheese pizza
      /// </summary>
      public void CheeseP()
      {
         Pizza p = new Pizza("thick");
         p.AddTopping("extra cheese");
         NumToppings =1;
      }
   }
}