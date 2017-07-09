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

            //searchTextForMyMethod = search;
            //Predicate<MediaItem> pred = new Predicate<MediaItem>(MyMethod);
            //results = myMediaLibrary.Items.FindAll(pred);

            results = myMediaLibrary.Items.FindAll(
                delegate(MediaItem item)
                {
                    return item.Title.ToLower().Contains(search);
                });

            return results;
        }

        //private static string searchTextForMyMethod;
        //private static bool MyMethod(MediaItem mediaItem)
        //{
        //    if (mediaItem.Title.ToLower().Contains(searchTextForMyMethod))
        //        return true;
        //    else
        //        return false;
        //}

        public static List<MediaItem> SearchByLambda(MediaLibrary myMediaLibrary, string search)
        {
            List<MediaItem> results = myMediaLibrary.Items.FindAll(item => item.Title.ToLower().Contains(search));
            return results;
        }

    }
}
