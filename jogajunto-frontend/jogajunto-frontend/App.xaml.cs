using jogajunto_frontend.Extensions;
using jogajunto_frontend.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Svg;

namespace jogajunto_frontend
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Xamarin.Forms.Device.SetFlags(new[] { "CarouselView_Experimental", "IndicatorView_Experimental" });

            SvgImageSource.RegisterAssembly();
            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(HomeView)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.AddNavigations();
            containerRegistry.AddRepositories();
            containerRegistry.AddServices();
        }
    }
}
