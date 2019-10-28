using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts
{
//using AMedia here instead of IControl because of dependency inversion, when we create AMedia we know it will work and Audio and Video are parts of Media
   public abstract class AVideo : AMedia {}

}