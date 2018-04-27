using System;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismPOC.ViewModels
{
    public class ViewAViewModel : BaseViewModel
    {
        public ICommand NavigateCommand { get; protected set; }

        public ViewAViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(async () =>
            {
                await _navigationService.NavigateAsync("ViewB");
            });
        }
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
