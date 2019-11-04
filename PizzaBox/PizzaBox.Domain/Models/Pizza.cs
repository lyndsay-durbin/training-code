using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

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

      int PizzaCount = 0;

      public Pizza(string crust)
      {
         Crust(crust);
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

      public void NumPizzas()
      {
         PizzaCount++;
         //return PizzaCount;
      }

   }


   /*
   public Pizza(){
      Toppings = new List<ETopping>();
      SetPrice();
   }

   private void SetPrice(){
      switch (Size)
      {
         case ESize.Large:
            Price = 12.99M;
            break;
         case ESize.Medium:
            Price = 9.99M;
            break;
         case ESize.Small:
            Price = 6.99M;
            break;
         default:
            Price = 16.99M;
            break;
      }
   }

   public decimal Price{get;set}
   public ECrust Crust {get;set;}
   public ESauce Sauce {get;set;}
   public ESize Size {get;set;}
   public ECheese Cheese {get;set;}
   public List<ETopping> Toppings {get;set;}


   
   
   
    */
}