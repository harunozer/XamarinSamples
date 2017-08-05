using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TasarimYapilari
{
    public class AbsoluteOrnek : ContentPage
    {
        public AbsoluteOrnek()
        {
            AbsoluteLayout layout = new AbsoluteLayout();

            BoxView BlueBax = new BoxView();
            BlueBax.BackgroundColor = Color.Blue;

            BoxView RedBox = new BoxView();
            RedBox.BackgroundColor = Color.Red;
            RedBox.Opacity = 0.5;
            //X = 50, Y = 50 koordinatlarında 150*150 boyutlarında ekler
            layout.Children.Add(BlueBax, new Rectangle(50, 50, 150, 150));

            //X = 175, Y = 175 koordinatlarına ekler
            layout.Children.Add(RedBox, new Point(175, 175));

            Content = layout;
        }
    }
}
