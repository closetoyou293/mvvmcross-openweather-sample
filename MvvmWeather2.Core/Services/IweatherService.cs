using System.Threading.Tasks;
using MvvmWeather2.Core.Model;

namespace MvvmWeather2.Core.Services
{
	public interface IWeatherService
	{
		Task<Climate> GetWeather(string AppID, string q, string units);
	}
}
