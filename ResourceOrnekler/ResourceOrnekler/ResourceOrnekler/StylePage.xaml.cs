using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ResourceOrnekler
{
    public partial class StylePage : ContentPage
    {
        public StylePage()
        {
            InitializeComponent();

            var buttonStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter { Property = Button.TextColorProperty,   Value = Color.Red }
                }
            };

            button1.Style = buttonStyle;
        }

        private void ThemeDegistir(object sender, EventArgs e)
        {
            Application.Current.Resources["Theme1Title"] = Application.Current.Resources["Theme2Title"];
            Application.Current.Resources["Theme1Button"] = Application.Current.Resources["Theme2Button"];
            Application.Current.Resources["Theme1Background"] = Application.Current.Resources["Theme2Background"];
        }
        
    }
}
