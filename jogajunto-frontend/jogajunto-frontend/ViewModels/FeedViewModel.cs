using jogajunto_frontend.Models;
using jogajunto_frontend.Services.Interfaces;
using jogajunto_frontend.ViewModels.Base;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Extended;

namespace jogajunto_frontend.ViewModels
{
    public class FeedViewModel : ViewModelBase
    {
        private readonly IFeedService _feedService;
        private int _pageSize = 5;
        private int _total = 50;

        public FeedViewModel(
            INavigationService navigationService,
            IFeedService feedService)
            : base(navigationService)
        {
            _feedService = feedService;
            BackCommand = new Command(async () => await BackExecuteAsync());

            Items = new InfiniteScrollCollection<Feed>
            {
                OnLoadMore = LoadMoreFeed,
                OnCanLoadMore = () =>
                {
                    return Items.Count < _total;
                }
            };

            LoadData();
        }

        public ICommand BackCommand { get; set; }

        public InfiniteScrollCollection<Feed> Items { get; }

        private async Task BackExecuteAsync()
        {
            await NavigationService.GoBackAsync();
        }

        private async Task<IEnumerable<Feed>> LoadMoreFeed()
        {
            IsBusy = true;

            var page = (Items.Count / _pageSize) + 1;

            var pageFeed = await _feedService.GetFeedsAsync(page, _pageSize);

            IsBusy = false;

            return pageFeed.Feeds;
        }

        private async void LoadData()
        {
            try
            {
                IsBusy = true;
                var feedPage = await _feedService.GetFeedsAsync(1, _pageSize);

                _total = feedPage.Total;

                Items.AddRange(feedPage.Feeds);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
