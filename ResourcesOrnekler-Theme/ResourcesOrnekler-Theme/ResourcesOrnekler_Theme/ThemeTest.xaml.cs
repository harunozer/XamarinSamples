using ResourcesOrnekler_Theme.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ResourcesOrnekler_Theme
{
    public partial class ThemeTest : ContentPage
    {
        ResourceDictionary[] Temalar;

        public ThemeTest()
        {
            InitializeComponent();
            Temalar = new ResourceDictionary[] {
                    new Theme1().Resources
                    ,new Theme2().Resources
                };
            App.Current.Resources = Temalar[0];

        }

        int SeciliThemeID = 0;

        private void TemaDegistir(object sender, EventArgs e)
        {
            SeciliThemeID++;
            if (SeciliThemeID > 1)
                SeciliThemeID = 0;

            App.Current.Resources = Temalar[SeciliThemeID];
        }

    }
}
