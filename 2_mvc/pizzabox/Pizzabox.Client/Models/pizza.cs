using System.Collections.Generic;

namespace Pizzabox.Client.Models
{
   public class pizza{
      public string Crust { get; set; }
      public string Size { get; set; }
      public List<string> Crsuts { get; set; }
      public List<string> Sizes { get; set; }
   }
}