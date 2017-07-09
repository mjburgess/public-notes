using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediaLibraryApp
{
    class MediaLibraryUtils
    {

        private const string imagesFolder = "images";

        public static void SaveLibraryToXML(MediaLibrary libToSave, string filename)
        {
            //XDocument doc = new XDocument();
            //XElement root = new XElement("MediaLibrary");
            //doc.Add(root);
            //foreach (var item in libToSave.Items) {
            //    root.Add(item.ToXML());
            //}
            //doc.Save(filename); 
            // TODO : 6 filename contains illegal characters
            // TODO user doesn't have permission to write to this folder
            // TODO filename too long
            try
            {
                XDocument doc = new XDocument();
                XElement root = new XElement("MediaLibrary");
                doc.Add(root);
                foreach (var item in libToSave.Items)
                {
                    root.Add(item.ToXML());
                }
                doc.Save(filename);
            }
            catch (ArgumentException ex)
            {
                string msg = string.Format("Library not saved. Reason = {0}\nFilename={1}", ex.Message, filename);
                MessageBox.Show(msg);
            }
        }

        public static void ReadLibraryFromXML(MediaLibrary libToPopulate, string filename)
        {
            libToPopulate.Items.Clear();
            XDocument doc = XDocument.Load(filename); // TODO filename doesn't correspond to a file ?
            // TODO file is empty ?
            // TODO file contains corrupt Xml ?
            XElement root = doc.Element("MediaLibrary"); // TODO this is not the root element ?
            foreach (var item in root.Elements())
            {
                switch (item.Name.LocalName)
                {
                    case "Movie":
                        libToPopulate.Items.Add(new Movie(item));
                        break;
                    case "Song":
                        libToPopulate.Items.Add(new Song(item));
                        break;
                    case "Photo":
                        libToPopulate.Items.Add(new Photo(item));
                        break;
                    default:
                        MessageBox.Show("Unknown media type : " + item.Name.LocalName); // TODO is this the correct way to notify a problem. What if its used in a web app?
                        break;
                }
            }

        }


        internal static void PopulateLibrary(MediaLibrary myMediaLibrary) {
            //incomplete list, feel free to add more!
            myMediaLibrary.Items.Add(
            new Song(
                "Shreveport Stomp",
                "Jelly Roll Morton",
                Path.Combine(imagesFolder, "ShreveportStomp.jpg"),
                TimeSpan.FromSeconds(180)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new Movie(
                    "Jaws",
                    "Steven Spielberg",
                    Path.Combine(imagesFolder, "JAWS.jpg"),
                    TimeSpan.FromMinutes(124)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
            new Movie(
                "Jurassic Park",
                "Steven Spielberg",
                Path.Combine(imagesFolder, "JurassicPark.jpg"),
                TimeSpan.FromMinutes(127)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
            new Movie(
                "War Horse",
                "Steven Spielberg",
                Path.Combine(imagesFolder, "WarHorse.jpg"),
                TimeSpan.FromMinutes(146)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new Song(
                    "Under The Bridge",
                    "Red Hot Chilli Peppers",
                    Path.Combine(imagesFolder, "UnderTheBridge.jpg"),
                    TimeSpan.FromSeconds(264)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new Movie(
                    "Star Wars",
                    "George Lucas",
                    Path.Combine(imagesFolder, "StarWars.jpg"),
                    TimeSpan.FromMinutes(125)) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new Song(
                    "Agadoo",
                    "Black Lace",
                    Path.Combine(imagesFolder, "Agadoo.jpg"),
                    TimeSpan.FromSeconds(186)) { Rating = Rating.Rubbish });
            myMediaLibrary.Items.Add(
                new Movie(
                    "Dirty Harry",
                    "Don Siegel",
                    Path.Combine(imagesFolder, "DirtyHarry.jpg"),
                    TimeSpan.FromMinutes(102)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new Song(
                    "A Million Love Songs",
                    "Take That",
                    Path.Combine(imagesFolder, "AMillionLoveSongs.jpg"),
                    TimeSpan.FromSeconds(232)) { Rating = Rating.Unrated });
            myMediaLibrary.Items.Add(
                new Movie(
                    "The Shawshank Redemption",
                    "Frank Darabont",
                    Path.Combine(imagesFolder, "ShawshankRedemption.jpg"),
                    TimeSpan.FromMinutes(142)) { Rating = Rating.Good });
            myMediaLibrary.Items.Add(
                new Song(
                    "Shaddap You Face",
                    "Joe Dolce Music Theatre",
                    Path.Combine(imagesFolder, "JoeDolceSYF.jpg"),
                    TimeSpan.FromSeconds(180)) { Rating = Rating.Rubbish });
            myMediaLibrary.Items.Add(
                new Song(
                    "Winin' Boy Blues",
                    "Jelly Roll Morton",
                    Path.Combine(imagesFolder, "WininBoyBlues.jpg"),
                    TimeSpan.FromSeconds(180)) { Rating = Rating.Fantastic });

            myMediaLibrary.Items.Add(
                 new Photo(
                   "Earth From Space",
                   "NASA",
                   Path.Combine(imagesFolder, "EarthFromSpace.jpg")) { Rating = Rating.Fantastic });
            myMediaLibrary.Items.Add(
                new Photo(
                    "Jellyfish",
                    "unknown",
                    Path.Combine(imagesFolder, "Jellyfish.jpg")) { Rating = Rating.Fantastic });
        }


    }
}
