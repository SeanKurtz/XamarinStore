using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormStore.Assets.Forms
{ 
    public class NavigationStack : ContentPage
    {
        public NavigationStack()
        {
            var layout = new StackLayout();
            var storeButton = new Button { Text = "Store", VerticalOptions = LayoutOptions.Start, HorizontalOptions = LayoutOptions.FillAndExpand };
            storeButton.Clicked += Store_Button_Clicked;

            layout.Children.Add(storeButton);
            Content = layout;
        }
        private async void Store_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamarinFormStore.Assets.Forms.StorePage());
        }

    }
}
