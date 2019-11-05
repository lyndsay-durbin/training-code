using System.Collections.Generic;
using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public class Users :AUser
   {
      //should order from 1 location/24 hours
      //should only order is account exists
      //should be able to see a list of locations
      //should be able to select a location
      //should be able to make an order
      //should be able to choose a preset pizza
      //should be able to select a crust
      //should be able to seelct a size
      //should be able to sign out
      //could be able to create a custom pizza
      //could be able to choose toppings
      //could be able to preview the order
      //could be able to confirm the order
      //could be able to register
      //could only order 1 time per 2 hours

      //remains true when signed in, false when user is not signed in
      public bool signedin { get{
         return signedin;
      } set{
         signedin=true;
      }}
      public string UN = "lyndsaydurbin";
      public List<Pizza> CurrentOrders { get; set; }
      public List<Order> PastOrder {get; set;}
      //var datestamp = Date.Now(); id in AModel takes care of this
      public Users(List<Pizza> pizzas)
      {
         CurrentOrders = pizzas;
      }

      //the Orders List in AUser takes care of this
      public void History()
      {
         //will return a list of previous order totals, and the number of pizzas with them
         System.Console.WriteLine("Your past orders are: ");
         System.Console.WriteLine(PastOrder);

      }

      public void Current(){
         foreach(Pizza item in CurrentOrders)
         {
            Console.WriteLine("Pizza size: " + item.size + "\nPizza Price: $" + item.price + "\n");
         }
      }

      public bool HaveOrdered()
      {
         //if returns true, don't allow the user to order, if false, order goes through
         return false;
      }

      public bool AccExist()
      {
         //checks if the user's account exists
         System.Console.WriteLine("Enter your username:");
         string user = System.Console.ReadLine();
         if(user == UN){
            SignIn();
            //return true;
         }
         else{
            System.Console.WriteLine("Wrong username. Try again.");
            AccExist();
         }

         return true;
      }

      public void SignIn()
      {
         signedin = true;
      }

      public void SignOut()
      {
         signedin = false;
      }

      


      //OPTIONALS
      public void PreviewOrder()
      {
         //prints out the prebuilt pizzas ordered, and the prices of each for the current order
      }



   }
}