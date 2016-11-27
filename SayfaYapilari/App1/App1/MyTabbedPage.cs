using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new TabbedPage1());
            Children.Add(new TabbedPage2());
        }
    }
}
