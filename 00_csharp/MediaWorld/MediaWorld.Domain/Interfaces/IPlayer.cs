namespace MediaWorld.Domain.Interfaces
{

   public interface IPlayer : IVolume 
   {

      bool Powerup();

      bool PowerDown();
      
   }   
}