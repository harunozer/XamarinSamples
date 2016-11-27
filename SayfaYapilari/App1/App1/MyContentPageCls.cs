using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class MyContentPageCls : ContentPage
    {
        public MyContentPageCls()
        {
            Label l = new Label();
            l.Text = "Xamarin Content Page Class";
            l.VerticalOptions = LayoutOptions.Center;
            l.HorizontalOptions = LayoutOptions.Center;
            Content = l;
        }
    }
}
