
using Android.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;

namespace MvvmWeather2.Droid.Views
{
    [Activity]
    public class WeatherDetailsView : MvxAppCompatActivity
    {
		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.OpenWeatherDetails);
			base.OnViewModelSet();
		}


    }
}
