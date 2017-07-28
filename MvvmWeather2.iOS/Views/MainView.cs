using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmWeather2.Core.ViewModels;

namespace MvvmWeather2.iOS.Views
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
		public MainView() : base("MainView", null)
        {
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(CityName).To(vm => vm.City);
            set.Bind(GetWeatherButton).To(vm => vm.FetchWeatherCommand);
            set.Apply();
        }
    }
}
