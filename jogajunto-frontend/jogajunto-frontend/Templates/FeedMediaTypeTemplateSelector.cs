using jogajunto_frontend.Models;
using jogajunto_frontend.Views.Cells;
using Xamarin.Forms;

namespace jogajunto_frontend.Templates
{
    public class FeedMediaTypeTemplateSelector : DataTemplateSelector
    {
        private DataTemplate _photoTemplate;
        private DataTemplate _videoTemplate;

        public FeedMediaTypeTemplateSelector()
        {
            _photoTemplate = new DataTemplate(typeof(FeedMediaPhotoTemplateCell));
            _videoTemplate = new DataTemplate(typeof(FeedMediaVideoTemplateCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
            => ((Feed)item).Media.IsPhoto ? _photoTemplate : _videoTemplate;
    }
}
