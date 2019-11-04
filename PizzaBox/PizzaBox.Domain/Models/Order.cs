using PizzaBox.Domain.Models;
using System;

namespace PizzaBox.Domain.Models
{
   public class Order
   {
      public void ViewOrder()
      {
         //run through each pizza object in the user's order
         Console.WriteLine();
      }

      public float TotalPrice { get; }

      public float CalcPrice()
      {
         //add up each pizza's price and return it 
         return 0;
      }

      //optional
      public int PizzaCount()
      {
         //increment for each pizza in the order
         int count = 0;
         return count;
      }
   }
}

/*
public class Order : AModel
{
   public decimal Cost {
      get{
         decimal sum = 0;
         foreach (var item in Pizzas)
         {
            sum += item.Price;
         }
         return sum;
      }
   }
   public List<Pizza> Pizzas {get;}
   public DateTime OrderDate {get;}
  
   public Order()
   {
      Pizzas = new List<Pizza>();
      OrderDate = DateTime.Now;
   }
}
 */