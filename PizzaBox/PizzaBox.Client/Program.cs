using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Enums;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            usernames.Add("lyndsaydurbin@yahoo.com");
            //Users customer = new Users();
            Order p;
            Store s;
            

            Console.WriteLine("Please enter your email: ");
            string username = Console.ReadLine();

            if (usernames.Contains(username))
            {
               //begin an order
               //customer.signedin = true;
               Console.WriteLine("Welcome! Would you like to create an order? y/n");
               string response  = Console.ReadLine();
               if (response == "y"){
                  p = new Order();
                  //s.Orders().Add(p);
               }
               //else {Console.WriteLine("Thank you! Come Again!");}
               
               //Store sending = new Store();
               Console.WriteLine("Your order has been received! Which store would you like to send it to?");
               Console.WriteLine();
               string answer = Console.ReadLine();

            }
            else System.Console.WriteLine("error");
        }
      }
}