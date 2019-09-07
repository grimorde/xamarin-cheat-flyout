using System;
using CheatFlyout.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheatFlyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        bool _isExpanded;
        Rectangle _expandedMenu; // bounds for expanded menu
        Rectangle _collapsedMenu;  // bounds for hidden menu

        public MainView()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }

        private void ShowMenu_Clicked(object sender, EventArgs e)
        {
            if (_isExpanded)
                AnimateIn();
            else
                AnimateOut();

            _isExpanded = !_isExpanded;
        }

        private void AnimateOut()
        {
            // show the menu, hide the main area (and move it away completely)
            MenuArea.LayoutTo(_expandedMenu, 1200, Easing.SpringOut);
            MainArea.FadeTo(0, 200);
            MainArea.TranslateTo(-MainArea.Width, 0, 200);
        }

        private void AnimateIn()
        {
            // hide the menu, show the main area (move it back)
            MenuArea.LayoutTo(_collapsedMenu, 200, Easing.SpringIn);
            MainArea.FadeTo(1, 1200);
            MainArea.TranslateTo(0, 0, 200);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            _collapsedMenu = new Rectangle(width, 0, 0, height);
            _expandedMenu = new Rectangle(0 + (width / 5), 0, (width / 5) * 4, height);
        }

        protected override void OnAppearing()
        {
            _isExpanded = false;
            AnimateOut();
        }
    }
}