using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using CheatFlyout.Views;
using Xamarin.Forms;

namespace CheatFlyout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
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
