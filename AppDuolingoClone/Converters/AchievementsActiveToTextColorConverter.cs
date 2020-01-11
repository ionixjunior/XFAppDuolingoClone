using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppDuolingoClone.Converters
{
    public class AchievementsActiveToTextColorConverter : IValueConverter
    {
        private Color _activeColor = Color.White;
        private Color _finishedColor = Color.FromHex("#cc7700");

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isActive)
            {
                if (isActive)
                    return _activeColor;

                return _finishedColor;
            }

            return _activeColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
