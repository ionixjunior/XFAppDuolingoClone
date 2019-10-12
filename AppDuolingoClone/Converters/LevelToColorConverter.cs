using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppDuolingoClone.Converters
{
    public class LevelToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var level = value as string;

            if (level == "4")
                return "#f19a37";

            return "#c287f8";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
