using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MvvmWeather2.Core.Model;
using MvvmWeather2.Core.Services;
using MvvmWeather2.iOS.Services;
using Refit;
using UIKit;

namespace MvvmWeather2.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
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
