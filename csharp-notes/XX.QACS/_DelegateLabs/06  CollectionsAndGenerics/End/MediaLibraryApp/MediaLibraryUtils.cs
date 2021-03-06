﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp {
    class MediaLibraryUtils {

        private const string imagesFolder = "images";

        internal static void PopulateLibrary(MediaLibrary myMediaLibrary) {
            //incomplete list, feel free to add more!
            myMediaLibrary.Items.Add(
            new MediaItem(
                "Shreveport Stomp",
                "Jelly Roll Morton",
                Path.Combine(imagesFolder, "ShreveportStomp.jpg"),
                "Song",
                TimeSpan.FromSeconds(180)) { Rating = Rating.Fantastic});
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Jaws",
                    "Steven Spielberg",
                    Path.Combine(imagesFolder, "JAWS.jpg"),
                    "Movie",
                    TimeSpan.FromMinutes(124)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
            new MediaItem(
                "Jurassic Park",
                "Steven Spielberg",
                Path.Combine(imagesFolder, "JurassicPark.jpg"),
                "Movie",
                TimeSpan.FromMinutes(127)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
            new MediaItem(
                "War Horse",
                "Steven Spielberg",
                Path.Combine(imagesFolder, "WarHorse.jpg"),
                "Movie",
                TimeSpan.FromMinutes(146)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Under The Bridge",
                    "Red Hot Chilli Peppers",
                    Path.Combine(imagesFolder, "UnderTheBridge.jpg"),
                    "Song",
                    TimeSpan.FromSeconds(264)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Star Wars",
                    "George Lucas",
                    Path.Combine(imagesFolder, "StarWars.jpg"),
                    "Movie",
                    TimeSpan.FromMinutes(125)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Agadoo",
                    "Black Lace",
                    Path.Combine(imagesFolder, "Agadoo.jpg"),
                    "Song",
                    TimeSpan.FromSeconds(186)) { Rating = Rating.Rubbish });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Dirty Harry",
                    "Don Siegel",
                    Path.Combine(imagesFolder, "DirtyHarry.jpg"),
                    "Movie",
                    TimeSpan.FromMinutes(102)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "A Million Love Songs",
                    "Take That",
                    Path.Combine(imagesFolder, "AMillionLoveSongs.jpg"),
                    "Song",
                    TimeSpan.FromSeconds(232)) { Rating = Rating.Unrated });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "The Shawshank Redemption",
                    "Frank Darabont",
                    Path.Combine(imagesFolder, "ShawshankRedemption.jpg"),
                    "Movie",
                    TimeSpan.FromMinutes(142)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Shaddap You Face",
                    "Joe Dolce Music Theatre",
                    Path.Combine(imagesFolder, "JoeDolceSYF.jpg"),
                    "Song",
                    TimeSpan.FromSeconds(180)) { Rating = Rating.Rubbish });
            myMediaLibrary.Items.Add(
                new MediaItem(
                    "Winin' Boy Blues",
                    "Jelly Roll Morton",
                    Path.Combine(imagesFolder, "WininBoyBlues.jpg"),
                    "Song",
                    TimeSpan.FromSeconds(180)) { Rating = Rating.Fantastic });
        }

    }
}
