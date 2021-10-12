using jogajunto_frontend.Repositories;
using jogajunto_frontend.Repositories.Interfaces;
using jogajunto_frontend.Services;
using jogajunto_frontend.Services.Interfaces;
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
            containerRegistry.RegisterForNavigation<FeedView, FeedViewModel>();
        }

        public static void AddServices(this IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IHomeService, HomeService>();
            containerRegistry.Register<IFeedService, FeedService>();
        }

        public static void AddRepositories(this IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IHomeRepository, HomeRepository>();
            containerRegistry.Register<IFeedRepository, FeedRepository>();
        }
    }
}
