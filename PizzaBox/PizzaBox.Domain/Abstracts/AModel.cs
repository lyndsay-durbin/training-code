using System;

namespace PizzaBox.Domain.Abstracts
{
   public abstract class AModel
   {
      public long id {get;}
      public string name {get; set;}

      //the datetime will rpovide the time of the login?
      public AModel()
      {
         id = DateTime.Now.Ticks;
      }
   }
}