using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace MvvmWeather2.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}
