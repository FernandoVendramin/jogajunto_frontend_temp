using jogajunto_frontend.ViewModels;
using jogajunto_frontend.Views;
using Prism.Ioc;
using Xamarin.Forms;

namespace jogajunto_frontend.Extensions
{
    public static class ConfigureContainerExtension
    {
        public static void AddNavigations(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomeView, HomeViewModel>();
        }
    }
}
