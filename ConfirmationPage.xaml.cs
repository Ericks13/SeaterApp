using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Seater.Views
{
    public partial class ConfirmationPage : ContentView
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }

    }
}
