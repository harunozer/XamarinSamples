using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TasarimYapilari
{
    public class RelativeOrnek : ContentPage
    {
        public RelativeOrnek()
        {
            RelativeLayout layout = new RelativeLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;

            layout.Children.Add(blue, Constraint.Constant(10), Constraint.Constant(10));

            //Constraint.Constant ekrana göre konum
            //RelativeToParent: kontrolün Parentına göre bu örnekte  RelativeLayout
            //RelativeToView: başka bir view a göre
            red.Opacity = 0.6;
            layout.Children.Add(red, Constraint.RelativeToParent((parent) =>
            {
                //parent = üst katman yani layout içinde olduğu için layout
                return parent.X + 20;
            }), Constraint.RelativeToView(blue, (parent, toView) => {
                return toView.Y + 10;
            }));

            Content = layout;
        }
    }
}
