using Prism.Mvvm;
using Prism.Navigation;

namespace jogajunto_frontend.ViewModels.Base
{
    public abstract class ViewModelBase : BindableBase
    {
        public INavigationService NavigationService { get; }

        protected ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
