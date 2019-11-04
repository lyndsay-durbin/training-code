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
      }

      //optional
      public int PizzaCount()
      {
         //increment for each pizza in the order
         int count = 0;
      }
   }
}