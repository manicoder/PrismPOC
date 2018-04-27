using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismPOC.ViewModels;
using PrismPOC.Views;
using Xamarin.Forms;

namespace PrismPOC
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null)
               : base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            // NavigationService.NavigateAsync("MainPage");
            NavigationService.NavigateAsync("NavigationPage/MainPage");


        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>("MainPage");
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>("ViewA");
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>("ViewB");
            containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>("ViewC");
            containerRegistry.RegisterForNavigation<ViewD, ViewDViewModel>("ViewD");


        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
