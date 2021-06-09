using Microsoft.Extensions.DependencyInjection;
using WeatherAcquisition.WPF.ViewModels;

namespace WeatherAcquisition.WPF
{
    class ServiceLocator
    {
        public MainWindowsViewModel MainModel => App.Services.GetRequiredService<MainWindowsViewModel>();
    }
}
