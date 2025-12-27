using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Snipcode.WPF.Converters
{
    public class TagsToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is List<Tag> tags)
            {
                string str = string.Empty;
                for(int i =0;i<tags.Count;i++)
                {
                    str += '#' + tags[i].Name;
                    if (i != tags.Count - 1) str += ", ";
                }
                return str;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
