using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ResourcesOrnekler_Theme
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ThemeTest();
        }
    }
}
