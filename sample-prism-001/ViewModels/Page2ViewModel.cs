using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sample_prism_001.ViewModels
{
	public class Page2ViewModel : BindableBase, INavigationAware, IDestructible
    {
        public AsyncReactiveCommand ButtonCommand { get; } = new AsyncReactiveCommand();

        public Page2ViewModel(INavigationService navigationService)
        {
            ButtonCommand.Subscribe(async () =>
            {
                await navigationService.NavigateAsync("/NavigationPage/Page1");
            });

            // Set the wait time so you can see the issue
            Device.BeginInvokeOnMainThread(() => Thread.Sleep(1000)); 
        }

        public void Destroy()
        {
            
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}