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
}
