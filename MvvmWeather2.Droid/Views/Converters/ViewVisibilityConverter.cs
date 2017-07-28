using System;
using MvvmCross.Platform.Converters;
using Android.Views;

namespace MvvmWeather2.Droid.Views.Converters
{
    public class ViewVisibilityConverter : MvxValueConverter<bool, ViewStates>
    {
        protected override ViewStates Convert(bool value, Type targetType, object parameter,
                                              System.Globalization.CultureInfo culture)
        {
            return value ? ViewStates.Visible : ViewStates.Gone;
        }
    }
}
