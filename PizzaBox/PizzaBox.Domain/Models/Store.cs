using PizzaBox.Domain.Enums;
using PizzaBox.Domain.Models;
using System.Collections.Generic;
using System;

namespace PizzaBox.Domain.Models
{
   public class Store
   {
      //could see sales (daily/monthly)
      //could see inventory
      //could see users list


      //list of store locations in EStores
      List<EStores> locations = new List<EStores>();
      public EStores address {get; private set; }
      //a list of orders in the store
      public List<Order> Orders { get; private set; }
      public Order prevOrder = new Order();

      public Store(string location)
      {
         if(location == "dallas")
         {
            address = EStores.dallas;
         }
         else if(location == "arlington")
         {
            address = EStores.arlington;
         }
         else if(location == "fort worth")
         {
            address = EStores.fortWorth;
         }

         Console.WriteLine("Your order has been received by our " + address + " location");
         
      }
   }
}