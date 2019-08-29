using CheatFlyout.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheatFlyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }
    }
}