using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System;

namespace PizzaBox.Domain.Models
{
   public class Order : AModel
   {
      public DateTime orderdate { get; }
      public List<Pizza> Pizzas = new List<Pizza>();
      public decimal CalcPrice { get{
         decimal sum = 0;
         foreach (Pizza item in Pizzas)
         {
            sum += item.price;
         }
         return sum;
      }}

      public decimal TotalPrice =0;
      //public Pizza p = new Pizza();

      public bool custIn = true;
      public Users customer;
      public void ViewOrder()
      {
         //run through each pizza object in the user's order
         foreach(Pizza item in Pizzas)
         {
            Console.WriteLine(item);
         }
      }

      public Order()
      {
         Console.WriteLine("Your order id is: " + id);
         while(custIn == true){
            Pizzas.Add(new Pizza());
            Console.WriteLine("Would you like to add another pizza? y/n");
            if(Console.ReadLine() == "n")
            {
               break;
            }
         }

         Console.WriteLine("Thank you for your order. Your order contains:");
         customer = new Users(Pizzas);
         customer.Current();

         Console.WriteLine("Your order total will be $" + CalcPrice);
      }

      //optional
      public int PizzaCount()
      {
         //increment for each pizza in the order
         Pizza count = new Pizza();
         int num = count.NumPizzas();
         return num;
      }
   }
}