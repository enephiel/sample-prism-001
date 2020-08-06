using Prism;
using Prism.Ioc;
using sample_prism_001.ViewModels;
using sample_prism_001.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sample_prism_001
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/NavigationPage/Page1");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
        }
    }
}
