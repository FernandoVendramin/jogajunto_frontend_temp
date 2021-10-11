using jogajunto_frontend.Services.Interfaces;
using jogajunto_frontend.ViewModels.Base;
using System;
using Xamarin.Forms;

namespace jogajunto_frontend.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IHomeService _homeService;

        private string _title = "Casa da Criança de Valinhos";
        private string _description;
        private ImageSource _bannerImage;

        public HomeViewModel(IHomeService homeService)
        {
            _homeService = homeService;

            LoadData();
        }

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

        private async void LoadData()
        {
            var homeData = await _homeService.GetHomeAsync();

            Description = homeData.Description;
            Title = homeData.Title;
            BannerImage = ImageSource.FromUri(new Uri(homeData.Media.Banner));
        }
    }
}
