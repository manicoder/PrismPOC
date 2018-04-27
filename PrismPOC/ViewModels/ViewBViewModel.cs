using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismPOC.ViewModels
{
    public class ViewBViewModel:BaseViewModel
    {
        public ICommand NavigateCommand { get; protected set; }

        public ViewBViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("ViewC");
            });
        }
    }
}
