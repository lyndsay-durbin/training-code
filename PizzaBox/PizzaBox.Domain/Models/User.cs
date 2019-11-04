namespace PizzaBox.Domain.Models
{
   public class Users
   {
      //should view order history
      //should order from 1 location/24 hours
      //should only order is account exists
      //should be able to sign in
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
      public bool signedin = false;
      public void History()
      {
         //will return a list of previous order totals, and the number of pizzas with them
      }

      public bool HaveOrdered()
      {
         //if returns true, don't allow the user to order, if false, order goes through
         return false;
      }

      public bool AccExist()
      {
         //checks if the user's account exists
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