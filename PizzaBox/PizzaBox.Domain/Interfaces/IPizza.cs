using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
   public interface IPizza
   {
      Crust PizzaCrust();
      Size PizzaSize();
      Pizza PizzaType();
   }
}