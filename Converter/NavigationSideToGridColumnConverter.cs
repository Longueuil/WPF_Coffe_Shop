using CoffeShop.ViewModel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CoffeShop.Converter
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navigtionSide = (NavigationSide)value;
            return navigtionSide == NavigationSide.Left ? 0 : 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
