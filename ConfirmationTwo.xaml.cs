using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Seater.Views
{
    public partial class ConfirmationPageTwo: ContentView
    {
        public ConfirmationPageTwo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //This should go to the reservation page
            Navigation.PushAsync(new SearchPage());
        }
    }
}
