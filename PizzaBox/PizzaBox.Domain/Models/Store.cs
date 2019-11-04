namespace PizzaBox.Domain.Models
{
   public class Store
   {
      //list of store locations
      //Dallas, Arlington, Fort Worth

      //should exist at least 1 store
      //should be able to see order history
      //could see sales (daily/monthly)
      //could see inventory
      //could see users list
   }


   /*
   public class Store : AModel
   {
      public string Address {get;private set;}
      public List<Order> Orders {get;private set}\
      public decimal Sales {get{
         decimal sum =0;

         foreach(var item in Orders)
         {
            sum += item.Cost;
         }
         return sum;
      }}

      public Store()
      {
         Orders = new List<Order>();
      }
   }
   
    */
}