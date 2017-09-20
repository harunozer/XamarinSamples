using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormKontrolleri
{
    public partial class KontrollerOrnek : ContentPage
    {
        public KontrollerOrnek()
        {
            InitializeComponent();

            /*Bu özellikler xaml de de belirtilebilir*/
            DatePicker1.MinimumDate = Convert.ToDateTime("2016-01-01");
            DatePicker1.MaximumDate = Convert.ToDateTime("2018-01-01");
            DatePicker1.Date = DateTime.Now;
            DatePicker1.Format = "dd/MM/yyyy";
            /*
            Label Header = new Label
            {
                Text = "WebView"
                ,FontSize = 50
                ,FontAttributes = FontAttributes.Bold
                ,HorizontalOptions = LayoutOptions.Center
            };

            WebView wView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://www.google.com.tr"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
            this.Content = new StackLayout
            {
                Children =
                {
                    Header,wView
                }
            };
            */
        }

        public void Button1Click(object sender, EventArgs e)
        {
            LoadingIndicator.IsRunning = !LoadingIndicator.IsRunning;
            /*
             1 parametre hangi değere gideceği, 2. kaç milisaniyede gideceği, 3. parametre de animasyondur
            */
            progress1.ProgressTo(0.8, 2000, Easing.Linear);
        }

        private void pickerChange(object sender, EventArgs e)
        {
            Picker p = (Picker)sender;
            string selectedItem = p.Items[p.SelectedIndex];
            DisplayAlert("Picker Change", selectedItem, "TAMAM", "İPTAL");
        }

        private void onToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switch Toggled", e.Value.ToString(), "TAMAM", "İPTAL");
        }

    }
}
