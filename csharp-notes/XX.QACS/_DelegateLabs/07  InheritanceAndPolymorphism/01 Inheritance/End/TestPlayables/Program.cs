using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMediaLibrary;

namespace TestPlayables {
    class Program {
        static void Main(string[] args) {
            MediaLibrary library = new MediaLibrary();
            library.MediaItems.Add(new Movie("Jaws", "Spielberg"));
            library.MediaItems.Add(new Song("Shreveport Stomp", "Jelly-Roll Morton"));
            library.MediaItems.Add(new Picture("The Royal Family", "David Bailey"));
            library.MediaItems.Add(new RadioShow("I'm sorry I'll read that again", "John Cleese"));


            foreach (MediaItem mi in library.MediaItems) {
                // TODO 1 use the dollar style of string.Format to Console.WriteLine : Title, MainPerson and MainPersonRole
                Console.WriteLine($"Title={ mi.Title}, Person={mi.MainPerson}, Role={mi.MainPersonRole}");

                PlayableMediaItem pmi = mi as PlayableMediaItem;
                // TODO 2 use the Elvis operator to call IsAuthorized, Play(), Pause() and Stop()
                bool? isAuth = pmi?.IsAuthorized;
                pmi?.Play();
                pmi?.Pause();
                pmi?.Stop();
                Console.WriteLine();
            }

        }
    }
}
