﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class MyMasterDetailPage:MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            Master = new MyMasterPage();
            Detail = new MyDetailPage();
        }
    }
}
