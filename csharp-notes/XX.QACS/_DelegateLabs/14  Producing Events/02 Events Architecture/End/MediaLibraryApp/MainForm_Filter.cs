using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibraryApp
{
    public partial class MainForm : Form
    {

        private void filterStringTextBox_TextChanged(object sender, EventArgs e)
        {
            List<MediaItem> newFilteredList = new List<MediaItem>();
            string filter = filterStringTextBox.Text.ToLower();

            if (filterStringTextBox.Text.Length > 0)
            {
                if (radForeach.Checked)
                {
                    FilterByForeach(newFilteredList, filter);
                }

                if (radDelegate.Checked)
                {
                    FilterByFindAll(ref newFilteredList, filter);
                }

                if (radLambda.Checked)
                {
                    FilterByLambda(ref newFilteredList, filter);
                }

                if (radAny.Checked)
                {
                    Any(filter);
                }

                if (radFilterByType.Checked)
                {
                    FilterByType(ref newFilteredList, filter);
                }
                if (radFilterByTitle.Checked)
                {
                    FilterByTitle(ref newFilteredList, filter);
                }
                if (radFilterByTitleAndOrderByDuration.Checked)
                {
                    FilterByTitleAndOrderByDuration(ref newFilteredList, filter);
                }
                if (radFilterByTitleAndOrderByDurationDesc.Checked)
                {
                    FilterByTitleAndOrderByDurationDesc(ref newFilteredList, filter);
                }

            }
            UpdateFilter(newFilteredList);
        }

        private void FilterByType(ref List<MediaItem> newFilteredList, string filter)
        {
            IEnumerable<MediaItem> mediaItemsByType = null;
            if (chkUseQueryExpression.Checked)
            {
                mediaItemsByType = from item in myMediaLibrary.Items
                                   where item.GetType().Name.ToLower() == filter
                                   select item;
            }
            else
            {
                mediaItemsByType = myMediaLibrary.Items
                   .Where(mi => mi.GetType().Name.ToLower() == filter);
            }
            newFilteredList = mediaItemsByType.ToList();
        }


        private void FilterByTitle(ref List<MediaItem> newFilteredList, string filter)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;
            if (chkUseQueryExpression.Checked)
            {
                mediaItemsByTitle = from item in myMediaLibrary.Items
                                    where item.Title.ToLower().Contains(filter)
                                    select item;
            }
            else
            {
                mediaItemsByTitle = myMediaLibrary.Items
                                    .Where(mi => mi.Title.ToLower().Contains(filter));
            }
            newFilteredList = mediaItemsByTitle.ToList();
        }

        private void FilterByTitleAndOrderByDuration(ref List<MediaItem> newFilteredList, string filter)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;

            mediaItemsByTitle = from item in myMediaLibrary.Items
                                where item.Title.ToLower().Contains(filter)
                                let playable = item as IPlayable
                                orderby (playable != null) ? playable.Duration.TotalMinutes : 0.0
                                select item;
            newFilteredList = mediaItemsByTitle.ToList();
        }

        private void FilterByTitleAndOrderByDurationDesc(ref List<MediaItem> newFilteredList, string filter)
        {
            IEnumerable<MediaItem> mediaItemsByTitle = null;

            mediaItemsByTitle = from item in myMediaLibrary.Items
                                where item.Title.ToLower().Contains(filter)
                                let playable = item as IPlayable
                                orderby (playable != null) ? playable.Duration.TotalMinutes : 0.0 descending
                                select item;
            newFilteredList = mediaItemsByTitle.ToList();
        }

        private void FilterByDuration(ref List<MediaItem> newFilteredList, string filter)
        {
            TimeSpan duration;
            if (TimeSpan.TryParse(filter, out duration))
            {
                IEnumerable<MediaItem> mediaItemsByDuration = null;
                if (chkUseQueryExpression.Checked)
                {
                    mediaItemsByDuration = from mi in myMediaLibrary.Items.OfType<IPlayable>()
                                           where mi.Duration <= duration
                                           select mi as MediaItem;
                }
                else
                {
                    mediaItemsByDuration = myMediaLibrary.Items.OfType<IPlayable>()
                                            .Where(mi => mi.Duration <= duration)
                                            .Select(mi => mi as MediaItem);
                }
                newFilteredList = mediaItemsByDuration.ToList();
            }
            else
            {
                MessageBox.Show("Sorry, I can't convert your search text into a duration in the format hh:mm:ss", "Filter Error");
            }
        }


        private void btnFilterByDuration_Click(object sender, EventArgs e)
        {
            List<MediaItem> newFilteredList = new List<MediaItem>();
            string filter = filterStringTextBox.Text.ToLower();
            FilterByDuration(ref newFilteredList, filter);
            UpdateFilter(newFilteredList);
        }



        private void Any(string filter)
        {
            bool contains = myMediaLibrary.Items.Any(item => item.Title.ToLower().Contains(filter));
            filterStringTextBox.ForeColor = (contains) ? Color.Green : Color.Red;
        }

        private void FilterByLambda(ref List<MediaItem> newFilteredList, string filter)
        {
            newFilteredList = myMediaLibrary.Items.FindAll(item => item.Title.ToLower().Contains(filter));
        }

        private void FilterByFindAll(ref List<MediaItem> newFilteredList, string filter)
        {
            newFilteredList = myMediaLibrary.Items.FindAll(
                    delegate(MediaItem item)
                    {
                        return item.Title.ToLower().Contains(filter);
                    });
        }

        private void FilterByForeach(List<MediaItem> newFilteredList, string filter)
        {
            foreach (var item in myMediaLibrary.Items)
            {
                if (item.Title.ToLower().Contains(filter))
                {
                    newFilteredList.Add(item);
                }
            }
        }

        private void UpdateFilter(List<MediaItem> newFilteredList)
        {
            currentItemIndex = 0;
            allItemsListBox.DataSource = newFilteredList;
            DisplayCurrentItem();
        }
    }
}
