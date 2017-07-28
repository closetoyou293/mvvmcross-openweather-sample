using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmWeather2.Core.Model;
using MvvmWeather2.Core.Services;

namespace MvvmWeather2.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        readonly IWeatherService _weatherService;
        readonly IMvxNavigationService _navigationService;

        const string APIKEY = "44c4acdf150c75c309d3f45dba63a70b";

        public MainViewModel(IWeatherService _weatherService, IMvxNavigationService _navigationService)
        {
            this._weatherService = _weatherService;
            this._navigationService = _navigationService;
        }

        string _city;
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                RaisePropertyChanged(() => City);
            }
        }

        bool _showProgress = false;
        public bool ShowProgress
        {
            get { return _showProgress; }
	        set
            {
                _showProgress = value;
				RaisePropertyChanged(() => ShowProgress);
            }
        }

        public IMvxCommand FetchWeatherCommand => new MvxCommand(FetchWeather);
        async void FetchWeather()
        {
            ShowProgress = true;
            Climate weather = await _weatherService.GetWeather(APIKEY, City, "metric");
            await _navigationService.Navigate<WeatherDetailsViewModel, Climate>(weather);
            ShowProgress = false;
        }

    }
}
