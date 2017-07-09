using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public static class StringUtilities
    {
        public static string ToTitleCase(this string toConvert)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(toConvert);
        }
    }
}
