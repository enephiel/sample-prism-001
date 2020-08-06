using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Xamarin.Forms;

namespace sample_prism_001.ViewModels
{
	public class Page1ViewModel : BindableBase, INavigationAware, IDestructible
    {

        public AsyncReactiveCommand ButtonCommand { get; } = new AsyncReactiveCommand();

        public ReactiveProperty<string> HogeText { get; set; } = new ReactiveProperty<string>("!!! Binded !!!");

        public ReactiveProperty<Color> HogeColor { get; set; } = new ReactiveProperty<Color>(Color.Pink);


        public Page1ViewModel(INavigationService navigationService)
        {
            ButtonCommand.Subscribe(async () =>
            {
                await navigationService.NavigateAsync("/NavigationPage/Page2");
            });
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