﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            this.BindingContext = new[] { "a", "b", "c" };
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; 
            Debug.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; 
        }
    }
}
