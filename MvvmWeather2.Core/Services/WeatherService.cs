using System.Threading.Tasks;
using MvvmWeather2.Core.Model;

namespace MvvmWeather2.Core.Services
{
    public class WeatherService : IWeatherService
    {
        readonly IWeatherClient WeatherClient;

        public WeatherService(IWeatherClient weatherClient)
        {
            WeatherClient = weatherClient;
        }

        public Task<Climate> GetWeather(string AppID, string q, string units)
        {
            return WeatherClient.GetWeather(AppID, q, units);
        }
    }
}
