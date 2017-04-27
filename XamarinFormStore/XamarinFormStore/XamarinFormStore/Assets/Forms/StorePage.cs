using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormStore.Assets.Forms;
using XamarinFormStore.Assets.Data;

namespace XamarinFormStore.Assets.Forms
{
    public class StorePage : ContentPage
    {
        public ObservableCollection<Item> items { get; set; }
        public StorePage()
        {
            items = new ObservableCollection<Item>();
            ListView listView = new ListView();
            listView.RowHeight = 60;
            listView.ItemTemplate = new DataTemplate(typeof(ItemCell));
            //items.Add(new Item(1, "apple", "a red apple", "red_apple.png"));

        }
        public class ItemCell : ViewCell
        {
            public ItemCell()
            {
                var image = new Image();
                var nameLabel = new Label();
                var descriptionLabel = new Label();

                var verticalLayout = new StackLayout();
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.Black } ;

                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));

                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                image.HorizontalOptions = LayoutOptions.End;
                nameLabel.FontSize = 20;

                image.BackgroundColor = Color.White;
                nameLabel.BackgroundColor = Color.Gray;
                descriptionLabel.BackgroundColor = Color.Yellow;


                verticalLayout.Children.Add(nameLabel);
                verticalLayout.Children.Add(descriptionLabel);
                horizontalLayout.Children.Add(verticalLayout);
                horizontalLayout.Children.Add(image);

                

                View = horizontalLayout;
            }
        }
    }
}
