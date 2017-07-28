using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmWeather2.Core.Model;

namespace MvvmWeather2.Core.ViewModels
{
    public class WeatherDetailsViewModel : MvxViewModel<Climate>
    {
        Climate _climate;

        public override Task Initialize(Climate parameter)
        {
            Climate = parameter;
            return Task.FromResult(true);
        }

        public Climate Climate 
        {
            get { return _climate; }
            set 
            {
                _climate = value;
                RaisePropertyChanged(() => Climate);
            }
        }
    }
}