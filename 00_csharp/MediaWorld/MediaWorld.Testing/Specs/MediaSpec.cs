using MediaWorld.Domain.Singleton;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using Xunit;
using Moq;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Testing.Specs
{
   public class MediaSpec
   {
      AudioFactory af = new AudioFactory();
      VideoFactory vf = new VideoFactory();
      Mock<AMedia> mock;

      public MediaSpec()
      {
         mock = new Mock<AMedia>();
         mock.Setup(am => am.Play()).Returns(false);
      }

      [Fact]

      public void Test_AudioObject()
      {
         //arrange
         var sut = af;
         var expected = typeof(Song);

         //act
         var actual = af.Create<Song>() as Song;

         //assert
         Assert.True(expected == actual.GetType());
      }


      [Fact]

      public void Test_VideoObject()
      {
         //arrange
         var sut = vf;
         var expected = typeof(Movie);

         //act
         var actual = vf.Create<Movie>() as Movie;

         //assert
         Assert.True(expected == actual.GetType());
      } 

      public void Test_VideoPlay()
      {
         var sut = MediaSingleton.Instance;
         var mm = mock.Object;

         sut.Execute(mm.Play(), mm);

         //assert
         Assert.True(sut.Execute(mm.Play(), mm));
         //idea behind this is, i expect that if i create a movie at 60 fps, it should 
         //return false when trying to create the movie. however, no one has created play yet....
         //
      }
      
   }
}