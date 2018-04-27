using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismPOC.ViewModels
{
    public class ViewCViewModel:BaseViewModel
    {
        public ICommand NavigateCommand { get; protected set; }

        public ViewCViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("ViewD");
            });
        }
    }
}
