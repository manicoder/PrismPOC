using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismPOC.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NavigateCommand { get; protected set; }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("ViewA");
            });
        }
    }
}
