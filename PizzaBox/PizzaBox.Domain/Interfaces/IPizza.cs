using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
   public interface IPizza
   {
      Crust PizzaCrust();
      string PizzaSize(string size);
      Pizza PizzaType();
   }
}