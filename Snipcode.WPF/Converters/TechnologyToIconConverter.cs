using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using Wpf.Ui.Controls;

namespace Snipcode.WPF.Converters
{
    public class TechnologyToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string file = String.Empty;
            if (value is Technology language)
            {
                file = language switch
                {
                    Technology.CSharp => "cSharp.png",
                    Technology.Python => "python.png",
                    Technology.JavaScript => "javaScript.png",
                    Technology.CPlusPlus => "cPlusPlus.png",
                    Technology.HTML => "html.png",
                    //решту не забути
                    _ => "terminal.png"
                };
            }
            return $"/Resources/TechnologyIcons/{file}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
