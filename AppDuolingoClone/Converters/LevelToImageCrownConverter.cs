using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppDuolingoClone.Converters
{
    public class LevelToImageCrownConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var level = value as string;

            if (level == string.Empty)
                return "crown_gray_stroke";

            return "crown_stroke";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
