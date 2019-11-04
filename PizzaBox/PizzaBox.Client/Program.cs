using System;
using PizzaBox.Domain.Models;


namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your email: \n");
            string username = Console.ReadLine();

            if (List<string>.Contains(username))
            {
               //begin an order
            }
        }
    }

    /*
    within maiin
    PointOfSale();

    outside main:
    private static void PointOfSale()
    {
       var customer = new Customer();
       var order = new Order();
       var store = new Store();

       MakeSale(customer, order, store);
    }

    private static void MakeSale(AUser user, Order o, Store s)
    {
       var pizzas = SelectPizzas();
       o.Pizzas.AddRange(pizzas);
       u.Orders.Add(o);
       s.Orders.Add(o);
    }

    private static List<Pizza> SelectPizzas()
    {
       this is where the readlines/writelines will occur to figure out which pizzas would be added and how many pizzas are wanted by the user
       
       return new list<Pizzas>(){
          new Pizza(),
          new Pizza()
       };
    }
    
     */
}
