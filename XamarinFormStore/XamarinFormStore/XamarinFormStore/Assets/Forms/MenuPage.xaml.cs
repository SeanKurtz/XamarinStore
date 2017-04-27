using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormStore.Assets.Forms;

namespace XamarinFormStore.Assets.Forms
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private async void Cart_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.Assets.Forms.CartPage());
        }

        private async void Store_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.Assets.Forms.StorePage());
        }

        private async void Options_Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.Assets.Forms.OptionsPage());
        }

        private async void Camera_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.Assets.Forms.ScannerPage());
        }
    }
}
