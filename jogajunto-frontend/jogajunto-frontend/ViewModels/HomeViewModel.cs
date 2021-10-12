using jogajunto_frontend.Services.Interfaces;
using jogajunto_frontend.ViewModels.Base;
using jogajunto_frontend.Views;
using Prism.Navigation;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace jogajunto_frontend.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IHomeService _homeService;

        private string _title = "Casa da Criança de Valinhos";
        private string _description;
        private ImageSource _bannerImage;

        public HomeViewModel(
            INavigationService navigationService,
            IHomeService homeService)
            : base(navigationService)
        {
            _homeService = homeService;
            FeedCommand = new Command<Frame>(async x => await FeedExecuteAsync(x));

            LoadData();
        }

        public ICommand FeedCommand { get; set; }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }

        public ImageSource BannerImage
        {
            get => _bannerImage;
            set
            {
                _bannerImage = value;
                RaisePropertyChanged();
            }
        }

        private async Task ScaleEffect(Frame frame)
        {
            await frame.ScaleTo(0.95, 25, Easing.Linear);
            await Task.Delay(50);
            await frame.ScaleTo(1, 50, Easing.Linear);
        }

        private async void LoadData()
        {
            var homeData = await _homeService.GetHomeAsync();

            Description = homeData.Description;
            Title = homeData.Title;
            BannerImage = ImageSource.FromUri(new Uri(homeData.Media.Banner));
        }

        private async Task FeedExecuteAsync(Frame frame)
        {
            await ScaleEffect(frame);
            await NavigationService.NavigateAsync(nameof(FeedView));
        }
    }
}
