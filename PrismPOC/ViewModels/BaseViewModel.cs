using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismPOC.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        protected INavigationService _navigationService { get; }
        private string mNavPath;
        public string NavPath
        {
            get { return mNavPath; }
            set
            {
                if (value != null || value != mNavPath) mNavPath = value;
                RaisePropertyChanged();
            }
        }
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            this.NavPath = _navigationService.GetNavigationUriPath();
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
