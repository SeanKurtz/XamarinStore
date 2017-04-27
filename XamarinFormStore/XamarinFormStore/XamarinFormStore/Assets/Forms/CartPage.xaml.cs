using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormStore.Assets.Data;

namespace XamarinFormStore.Assets.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class CartPage : ContentPage
    {
        ObservableCollection<Item> CartItems;
        public CartPage()
        {
            InitializeComponent();

            CartItems = new ObservableCollection<Item>()
            {
                new Item(){Image = "red_apple.png", Title = "Red Apple", Description = "a red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple2", Description = "Another red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple3", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple4", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple5", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple6", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple7", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple8", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple9", Description = "Another other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple10", Description = "Another other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple11", Description = "Another other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple12", Description = "Another other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple13", Description = "Another other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple14", Description = "Another other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple15", Description = "Another other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple16", Description = "Another other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple17", Description = "Another other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple18", Description = "Another other other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple19", Description = "Another other other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple20", Description = "Another other other other other red apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple21", Description = "Another other red other other other apple"},
                new Item(){Image = "red_apple.png", Title = "Red Apple22", Description = "Another other red other other other other other other other other happy apple"},
            };

            ItemListView.ItemsSource = CartItems;
        }

    }
}
