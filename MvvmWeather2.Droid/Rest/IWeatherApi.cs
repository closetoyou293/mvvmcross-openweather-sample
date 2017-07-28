using System.Threading.Tasks;
using MvvmWeather2.Core.Model;
using Refit;
namespace MvvmWeather2.Droid.Services
{
    public interface IWeatherApi
    {
        [Get("/weather")]
        Task<Climate> GetWeather(string AppID, string q, string units);
    }
}
