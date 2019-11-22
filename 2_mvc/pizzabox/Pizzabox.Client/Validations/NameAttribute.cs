namespace Pizzabox.Client.Validations
{
   public class NameAttribute : ValidationAttribute
   {
      public override bool isValid(object o)
      {
         var s = o as string;
         var regex = new Regex("[a-zA-Z]+");

         if (string.IsNullOrWhiteSpace(s))
         {
            return false;
         }

         if(!regex.Match)

         return true;
      }
   }  
}