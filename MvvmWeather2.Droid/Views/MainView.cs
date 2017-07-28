
using Android.App;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Views;

namespace MvvmWeather2.Droid.Views
{
    [Activity(MainLauncher = true)]
    public class MainView : MvxAppCompatActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.MainView);
            base.OnViewModelSet();
        }
    }
}
