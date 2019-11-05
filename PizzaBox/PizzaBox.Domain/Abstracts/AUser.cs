using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
   public abstract class AUser : AModel
   {
      public string Address {get; set;}
      public List<Order> Orders { get; set; }

      //this will keep track of the orders, either by th ecustomer or the manager
      public AUser()
      {
         Orders = new List<Order>();
      }
   }
}