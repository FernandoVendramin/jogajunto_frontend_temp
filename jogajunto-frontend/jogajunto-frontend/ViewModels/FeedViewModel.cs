using jogajunto_frontend.Models;
using jogajunto_frontend.Services.Interfaces;
using jogajunto_frontend.ViewModels.Base;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace jogajunto_frontend.ViewModels
{
    public class FeedViewModel : ViewModelBase
    {
        private readonly IFeedService _feedService;
        private ObservableCollection<Feed> _feeds = new ObservableCollection<Feed>();

        public FeedViewModel(
            INavigationService navigationService,
            IFeedService feedService)
            : base(navigationService)
        {
            _feedService = feedService;
            BackCommand = new Command(async () => await BackExecuteAsync());

            LoadData();
        }

        public ICommand BackCommand { get; set; }

        public ObservableCollection<Feed> Feeds
        {
            get => _feeds;
            set
            {
                _feeds = value;
                RaisePropertyChanged();
            }
        }

        private async Task BackExecuteAsync()
        {
            await NavigationService.GoBackAsync();
        }

        private async void LoadData()
        {
            var feedPage = await _feedService.GetFeedsAsync(1, 100);
            Feeds = new ObservableCollection<Feed>(feedPage.Feeds);
        }
    }
}
