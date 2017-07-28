using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmWeather2.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MvvmWeather2.iOS.Views
{
    public partial class WeatherDetailsView : MvxViewController<WeatherDetailsViewModel>
    {
        public WeatherDetailsView() : base("WeatherDetailsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			var set = this.CreateBindingSet<WeatherDetailsView, WeatherDetailsViewModel>();
            set.Bind(CityNameLabel).To(vm => vm.Climate.name);
        //    set.Bind(WeatherIcon).To(vm => );
            set.Bind(Temperature).To(vm => vm.Climate.main.temp);
        //    set.Bind(skyLabel).To(vm => vm.City);
            set.Bind(DateLabel).To(vm => vm.Climate.dt);
            set.Bind(WindLabel).To(vm => vm.Climate.wind.speed);
            set.Bind(CloudnessLabel).To(vm => vm.Climate.clouds.all);
            set.Bind(PressureLabel).To(vm => vm.Climate.main.pressure);
            set.Bind(HumidityLabel).To(vm => vm.Climate.main.humidity);
            set.Bind(SunriseLabel).To(vm => vm.Climate.sys.sunrise);
            set.Bind(SunsetLabel).To(vm => vm.Climate.sys.sunset);
            set.Bind(LatitudeLabel).To(vm => vm.Climate.coord.lat);
            set.Bind(LongitudeLabel).To(vm => vm.Climate.coord.lon);
			set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

