using System;
using MediaWorld.Domain.Abstracts;
//using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Singleton;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Factories;
using MediaWorld.Storing.Repositories;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace MediaWorld.Client
{
   /// <summary>
   /// contains the start point
   /// </summary>
    internal class Program
    {

       private static MediaRepository _repository = new MediaRepository();

       /// <summary>
       /// starts the application
       /// </summary>
        private static void Main()
        {
            var program = new Program();
            program.ApplicationStart();
            //ApplicationStart();
            //Play();
            //MagicThread();
            //MagicTask();
            MagicAsync().GetAwaiter().GetResult();
            Log.Warning("end of Main method");
        }

        private void ApplicationStart()
        {
           Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Debug()
           .WriteTo.Console()
           .WriteTo.File("log.txt")
           .CreateLogger();
        }

        private static void Play()
        {
            Log.Information("Play Method");

            var mediaPlayer = MediaSingleton.Instance;  
            /*var audioFactory = new AudioFactory();  
            var videoFactory = new VideoFactory();      
            AMedia song = audioFactory.Create<Song>();
            AMedia book = audioFactory.Create<Book>();
            AMedia movie = new Movie();*/

            foreach (var item in _repository.MediaLibrary)
            {
               Log.Debug("{@item}", item.Title);
               mediaPlayer.Execute(item.Play, item);
            }

            //mediaPlayer.Execute("play", song);
            //mediaPlayer.Execute("play", movie); 
        }

        private static void MagicThread()
        {
           //these are lambda functions/expressions, they are methods with no classes that we want to use as if
           //they were real methods but these only exist in the scope of our thread. bit different than anonymous methods
           var t1 = new Thread(() => {
              Run("A");
           });
           var t2 = new Thread(() => {
              Run("B");
           });

           t1.Start();
           t2.Start();

           t1.Join();
           t2.Join();

           //if(t1.IsAlive for 5 minutes)
           //then shut it down
        }
        private static void Run(string s)
        {
              for (var x=0; x < 100; x++)
              {
                 Console.Write(s);
              }
        }

        private static void MagicTask()
        {
            var t1 = new Task(() => {
              Run("A");
            });
            var t2 = new Task(() => {
              Run("B");
            });

            t1.Start();
            t2.Start();
        }

        private static async Task MagicAsync ()
        {
           await Task.Run(() => {Run("C"); });
        }
    }
}
