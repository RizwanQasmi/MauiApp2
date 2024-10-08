using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //cameraBarcodeReaderView.BarcodesDetected += (s, e) =>
            //{
            //    foreach (var barcode in e.Value)
            //    {
            //        // Display the scanned QR code result
            //        MainThread.BeginInvokeOnMainThread(() =>
            //        {
            //            DisplayAlert("QR Code", $"Scanned: {barcode.Value}", "OK");
            //        });
            //    }
            //};
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
