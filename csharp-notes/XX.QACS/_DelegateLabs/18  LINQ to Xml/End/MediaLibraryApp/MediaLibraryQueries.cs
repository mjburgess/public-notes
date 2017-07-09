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
                                let playable = item as IPlayable
                                orderby (playable != null) ? playable.Duration.TotalMinutes : 0.0
                                select item;

            return mediaItemsByTitle.ToList();
        }

        public static List<MediaItem> FindByTitleAndOrderByDurationDesc(MediaLibrary library, string search)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;
            // we will again just use the Query Expression style here

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
            if (TimeSpan.TryParse(search, out duration))
            {
                IEnumerable<MediaItem> mediaItemsByDuration = null;
                if (useQueryExpression)
                {
                    mediaItemsByDuration = from mi in library.Items.OfType<IPlayable>()
                                           where mi.Duration <= duration
                                           select mi as MediaItem;
                }
                else
                {
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
