using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace CheatFlyout.ViewModels
{
    class MainViewModel
    {
        public ICommand ButtonClickCommand => new Command<string>(ButtonClickExecute);

        private void ButtonClickExecute(object o)
        {
            UserDialogs.Instance.Alert($"You clicked {o.ToString()}!");
        }
    }
}
