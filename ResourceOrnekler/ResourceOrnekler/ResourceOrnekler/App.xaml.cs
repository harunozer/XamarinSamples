using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ResourceOrnekler
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            // The root page of your application
            var buttonStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter { Property = Button.TextColorProperty,   Value = Color.Blue }
                    ,new Setter { Property = Button.BackgroundColorProperty,   Value = Color.Silver }
                }
            };
            
            App.Current.Resources.Add("GlobalButtonStyleCS", buttonStyle);
            
            MainPage = new StylePage();
        }
    }
}
