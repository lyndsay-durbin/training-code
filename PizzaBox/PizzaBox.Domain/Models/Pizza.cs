namespace PizzaBox.Domain.Models
{
   public class Pizza
   {
      //should have a crust
      //should have a size
      //should compute the cost
      //can have 2 default toppings (crust and chesse)
      //can limit toppings to 5
      List<string> toppings = new List<string>();
      //sauce, cheese, pepperoni, sausage, bacon, olives, pepper, onion, extra cheese
      List<string> CurrentToppings = new List<string>();

      string Crust;
      bool Sauce = true;
      bool Cheese = true;

      public void MeatP()
      {
         Pizza p = new Pizza("thick", "sauce", "cheese");
         AddTopping("Pepperoni");
         AddTopping("Sausage");
         AddTopping("Bacon");
      }

      public void VeggieP()
      {
         Pizza p = new Pizza("thick", "sauce", "cheese");
         AddTopping("Pepper");
         AddTopping("Onion");
         AddTopping("Olives");
      }

      public void CheeseP()
      {
         Pizza p = new Pizza("thick", "sauce", "cheese");
         AddTopping("extracheese");
      }


      public Pizza(string crust)
      {
         Crust = crust;
      }

      public void AddTopping(string topping)
      {
         foreach(string item in toppings)
         {
            if (string.Equals(item, topping))
            {
               CurrentToppings.Add(item);
            }
         }

         System.Console.WriteLine("This pizza has: ");

         foreach(string item in CurrentToppings)
         {
            System.Console.WriteLine(item);
         }
      }


   }
}