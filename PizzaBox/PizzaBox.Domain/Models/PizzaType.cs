using PizzaBox.Domain.Enums;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public class PizzaType
   {
      public int NumToppings { get; set; }

      public List<EToppings> toppingList = new List<EToppings>();

      /// <summary>
      /// creates a meat pizza
      /// </summary>
      public List<EToppings> MeatP()
      {
         toppingList.Add(EToppings.pepperoni);
         toppingList.Add(EToppings.sausage);
         toppingList.Add(EToppings.bacon);

         NumToppings =3;

         return toppingList;
      }

      /// <summary>
      /// creates a veggie pizza
      /// </summary>
      public List<EToppings> VeggieP()
      {
         toppingList.Add(EToppings.pepper);
         toppingList.Add(EToppings.olives);
         toppingList.Add(EToppings.onion);

         NumToppings =3;

         return toppingList;
      }

      /// <summary>
      /// creates a cheese pizza
      /// </summary>
      public List<EToppings> CheeseP()
      {
         toppingList.Add(EToppings.cheese);
         
         NumToppings =1;

         return toppingList;
      }
   }
}