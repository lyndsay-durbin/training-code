using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Enums;

namespace PizzaBox.Domain.Models
{
   public class Pizza : AModel
   {
      //should have a crust
      //should have a size
      //can have 2 default toppings (crust and chesse)
      //can limit toppings to 5
      List<EToppings> CurrentToppings;
      public ECrust crust { get; set; }
      public ESize size { get; set; }
      public ECheese cheese { get; set;}
      public ESauce sauce { get; set; }
      public decimal price { get; set; }
      public int PizzaCount { get{
         return PizzaCount;
      } set{
         PizzaCount=0;
      }}
      public decimal totprice {get; set;}

      public Pizza()
      {
         PizzaType p = new PizzaType();
         CurrentToppings = new List<EToppings>(5);


         Console.WriteLine("What kind of pizza would you like? \n" + 
         "1: Meat Pizza\n2: Veggie Pizza\n3: Cheese Pizza");
         string response = Console.ReadLine();

         if(response == "1")
         {
            CurrentToppings = p.MeatP();
         }
         else if(response == "2")
         {
            CurrentToppings = p.VeggieP();
         }
         else if(response == "3")
         {
            CurrentToppings = p.CheeseP();
         }
         else {Console.WriteLine("Error: Not a Pizza Option\nGiven Cheese Pizza");
         CurrentToppings = p.CheeseP();}

         Console.WriteLine("What kind of crust would you like?\nthick, thin, garlic");
         string resp = Console.ReadLine();
         if(resp == "thick"){
            crust = ECrust.thick;
         }
         else if(resp == "thin"){
            crust = ECrust.thin;
         }
         else if(resp == "garlic"){
            crust = ECrust.garlic;
         }
         else{Console.WriteLine("Error: Not a Crust Option\nGiven Thick Crust");
         crust = ECrust.thick;}

         Console.WriteLine("What size would you like your pizza to be?\nSmall (s), Medium (m), Large(l)");
         string ans = Console.ReadLine();
         if(ans == "s"){
            size = ESize.small;
         }
         else if(ans == "m")
         {
            size = ESize.medium;
         }
         else if(ans == "l")
         {
            size = ESize.large;
         }
         else{Console.WriteLine("Error: Not a Size Option\nGiven Medium Pizza");
         size = ESize.medium;}

         decimal pizzaPrice = Price();
         Console.WriteLine("This pizza costs $" + price);
         //totprice += price;
         //PizzaCount++;
      }

      private decimal Price()
      {
         if(size == ESize.large)
            price = 8.99M;
         if(size == ESize.medium)
            price = 7.49M;
         if(size == ESize.small)
            price = 5.99M;
         
         foreach(EToppings item in CurrentToppings)
         {
            price += .99M;
         }

         return price;
      }

      //keeps track of the number of pizzas per order
      public int NumPizzas()
      {
         PizzaCount++;
         return PizzaCount;
      }
   }
}