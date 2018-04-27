using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismPOC.ViewModels
{
    public class ViewDViewModel : BaseViewModel
    {
        public ICommand NavigateCommand { get; protected set; }
        public ICommand NavigateRootCommand { get; protected set; }
        public ICommand NavigateRootDotCommand { get; protected set; }
        public ICommand NavigateViewACommand { get; protected set; }



        public ViewDViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(async () =>
            {
                await _navigationService.GoBackAsync();
            });
            NavigateRootCommand = new Command(async () =>
            {
                await navigationService.GoBackToRootAsync();
            });
            NavigateRootDotCommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("../../../MainPage");
            });
            NavigateViewACommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("ViewA");
            });
        }


    }
}
