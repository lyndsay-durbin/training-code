using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
   public class Pizza
   {
      //should have a crust
      //should have a size
      //should compute the cost
      //can have 2 default toppings (crust and chesse)
      //can limit toppings to 5
      List<string> toppings = new List<string>() 
      {"sauce", "cheese", "pepperoni", "sausage", 
      "bacon", "olives", "pepper", "onion", 
      "extra cheese"};
      List<string> CurrentToppings = new List<string>();

      string Crust;

      public Pizza(string crust)
      {
         Crust = crust;
      }

      /// <summary>
      /// adds a topping to the pizza's current toppings and prints a list of these
      /// </summary>
      /// <param name="topping"></param>
      public void AddTopping(string topping)
      {
         foreach(string item in toppings)
         {
            if (string.Equals(item, topping))
            {
               CurrentToppings.Add(item);
            }
         }

         System.Console.WriteLine("This pizza has: ");

         foreach(string item in CurrentToppings)
         {
            System.Console.WriteLine(item);
         }
      }


   }
}