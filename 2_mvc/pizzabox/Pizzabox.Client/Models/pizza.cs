using System.Collections.Generic;

namespace Pizzabox.Client.Models
{
   public class pizza{
      [Required]
      public string Crust { get; set; }
      [Required]
      public string Size { get; set; }
      [Range(1, 10)]
      public int Quantity { get; set; }
      [NameAttribute(ErrorMessage = "the name must be letters only")]
      [StringLength(50)]
      public string Name { get; set; }
      public List<string> Crusts { get; set; }
      public List<string> Sizes { get; set; }

      public pizza()
      {
         Crusts = new List<string> {"thin", "nystyel", "deepdish"};
         Sizes = new List<string> {"small", "medium", "large"};
      }
   }
}