using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace XamarinFormStore.Assets.Forms
{
    public class ScannerPage : ContentPage
    {
        ZXingScannerView scanView;
        ZXingDefaultOverlay scanOverlay;
        Grid resultGrid;
        public ScannerPage() : base()
        {
            scanView = new ZXingScannerView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,

            };
            scanView.OnScanResult += (result) =>
               Device.BeginInvokeOnMainThread(async () =>
               {
                   scanView.IsAnalyzing = false;
                   await DisplayAlert("Scanned Barcode", result.Text, "OK");
                   await Navigation.PopAsync();

               });
            scanOverlay = new ZXingDefaultOverlay
            {
                TopText = "Hold your phone up to the barcode",
                BottomText = "Scanning will happen automatically",
                ShowFlashButton = scanView.HasTorch,
            };
            scanOverlay.FlashButtonClicked += (sender, e) =>
            {
                scanView.IsTorchOn = !scanView.IsTorchOn;
            };

            resultGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            resultGrid.Children.Add(scanView);
            resultGrid.Children.Add(scanOverlay);

            Content = resultGrid;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            scanView.IsScanning = true;
        }
        protected override void OnDisappearing()
        {
            scanView.IsScanning = false;
            base.OnDisappearing();
        }
    }
}
