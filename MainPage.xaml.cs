using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MBTA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Schedules_Clicked(object sender, System.EventArgs e)
        {

        }

        private async void Fares_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }

        private void Feedback_Clicked(object sender, EventArgs e)
        {

        }
    }
}
