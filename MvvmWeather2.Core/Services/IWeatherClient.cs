using System;
using System.Threading.Tasks;
using MvvmWeather2.Core.Model;

namespace MvvmWeather2.Core.Services
{
    public interface IWeatherClient
    {
        Task<Climate> GetWeather(string appID, string q, string units);
    }
}
