using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platform.Platform;
using Refit;
using MvvmCross.Platform;
using MvvmWeather2.Droid.Services;
using MvvmWeather2.Core.Services;
using MvvmWeather2.Core.Model;
using System;
using System.Threading.Tasks;

namespace MvvmWeather2.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            var WeatherApiUrl = "http://api.openweathermap.org/data/2.5/";
            var WeatherApi = RestService.For<IWeatherApi>(WeatherApiUrl);
            IWeatherClient client = new WeatherApiClient(WeatherApi);
            Mvx.RegisterSingleton(client);
        }
    }

    class WeatherApiClient : IWeatherClient
    {
        readonly IWeatherApi _weatherApi;

        public WeatherApiClient(IWeatherApi _weatherApi)
        {
            this._weatherApi = _weatherApi;
        }

        public Task<Climate> GetWeather(string appID, string q, string units)
        {
            return _weatherApi.GetWeather(appID, q, units);
        }
    }
}
