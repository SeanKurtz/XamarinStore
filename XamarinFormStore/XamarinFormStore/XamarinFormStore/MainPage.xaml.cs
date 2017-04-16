using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormStore
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }
        private async void Cart_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.CartPage());

        }

        private async void Store_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.StorePage());
        }

        private async void Options_Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.OptionsPage());
        }

        private async void Camera_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.CameraPage());
        }
    }
}
