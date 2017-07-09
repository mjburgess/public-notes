using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLibraryApp
{
    public static class MediaLibraryQueries
    {
        public static List<MediaItem> SearchByForEach(MediaLibrary myMediaLibrary, string search)
        {
            List<MediaItem> results = new List<MediaItem>();

            foreach (var item in myMediaLibrary.Items)
            {
                if (item.Title.ToLower().Contains(search))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static List<MediaItem> SearchByDelegate(MediaLibrary myMediaLibrary, string search)
        {
            List<MediaItem> results;

            results = myMediaLibrary.Items.FindAll(
                delegate(MediaItem item)
                {
                    return item.Title.ToLower().Contains(search);
                });

            return results;
        }

        public static List<MediaItem> SearchByLambda(MediaLibrary myMediaLibrary, string search)
        {
            List<MediaItem> results = myMediaLibrary.Items.FindAll(item => item.Title.ToLower().Contains(search));
            return results;
        }

        public static List<MediaItem> FindByType(MediaLibrary library, string search, bool useQueryExpression)
        {
            IEnumerable<MediaItem> mediaItemsByType = null;
            if (useQueryExpression)
            {
                // TODO 1 : In the else block is the lambda-style. 
                //          Write the same query using the Query Expression style here
                mediaItemsByType = from item in library.Items
                                   where item.GetType().Name.ToLower() == search
                                   select item;
            }
            else
            {
                mediaItemsByType = library.Items
                   .Where(mi => mi.GetType().Name.ToLower() == search);
            }
            return mediaItemsByType.ToList();
        }

        public static List<MediaItem> FindByTitle(MediaLibrary library, string search, bool useQueryExpression)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;
            if (useQueryExpression)
            {
                mediaItemsByTitle = from item in library.Items
                                    where item.Title.ToLower().Contains(search)
                                    select item;
            }
            else
            {
                // TODO 2 : In the if block is the Query Expression style.
                //          Write the same query using the lambda style here
                mediaItemsByTitle = library.Items
                                    .Where(mi => mi.Title.ToLower().Contains(search));
            }
            return mediaItemsByTitle.ToList();
        }

        public static List<MediaItem> FindByTitleAndOrderByDuration(MediaLibrary library, string search)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;

            // we will just use the Query Expression style here
            mediaItemsByTitle = from item in library.Items
                                where item.Title.ToLower().Contains(search)
                                // TODO 3 :  try to cast the item 'as' an IPlayable in a 'let' expression.
                                //           call the 'let' variable 'playable'
                                let playable = item as IPlayable
                                // TODO 4 : add an 'orderby' expression where the parameter to the orderby
                                //          is a ternary expression testing on the above 'let' variable
                                //          (playable != null) ? playable.Duration.TotalMinutes : 0.0
                                orderby (playable != null) ? playable.Duration.TotalMinutes : 0.0
                                select item;

            // TODO 5 : Note when using LINQ we do not need to implement our own sorting code in any of our
            //          MediaItem classes.
            //
            //          To show this advantage uncomment the following 2 lines of code
            //          Run, select this filter and you will get an exception thrown :
            //              "Failed to compare two elements in the array."
            //          After the test, comment the code out again.
            //MediaItem[] test = library.Items.ToArray();
            //Array.Sort(test);

            return mediaItemsByTitle.ToList();
        }

        public static List<MediaItem> FindByTitleAndOrderByDurationDesc(MediaLibrary library, string search)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;
            // we will again just use the Query Expression style here

            // TODO 6 : Copy the code you've just created in the previous method
            //          (FindByTitleAndOrderByDuration) - just the LINQ code, not the array code
            //          and add ONE word to reverse the sorting order 
            mediaItemsByTitle = from item in library.Items
                                where item.Title.ToLower().Contains(search)
                                let playable = item as IPlayable
                                orderby (playable != null) ? playable.Duration.TotalMinutes : 0.0 descending
                                select item;
            return mediaItemsByTitle.ToList();
        }

        public static List<MediaItem> FindByDuration(MediaLibrary library, string search, bool useQueryExpression)
        {
            TimeSpan duration;
            // parse the search text to get a duration (hh:mm)
            // TODO 7 : replace 'true' in the following line with a TryParse expression to determine
            //          whether the search text can be parsed to a TimeSpan
            if (TimeSpan.TryParse(search, out duration))
            {
                IEnumerable<MediaItem> mediaItemsByDuration = null;
                if (useQueryExpression)
                {
                    // TODO 8 : Write a Query Expression that extracts all items of type IPlayable which
                    //          have a duration less than or equal to the duration parsed from the search text
                    //         (HINT : .OfType<>())
                    mediaItemsByDuration = from mi in library.Items.OfType<IPlayable>()
                                           where mi.Duration <= duration
                                           select mi as MediaItem;
                }
                else
                {
                    // TODO 9 : As above, but use a lambda expression instead.
                    mediaItemsByDuration = library.Items.OfType<IPlayable>()
                                            .Where(mi => mi.Duration <= duration)
                                            .Select(mi => mi as MediaItem);
                }
                return mediaItemsByDuration.ToList();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Sorry, I can't convert your search text into a duration in the format hh:mm:ss", "Search Error");
                return null;
            }
        }


    }
}
