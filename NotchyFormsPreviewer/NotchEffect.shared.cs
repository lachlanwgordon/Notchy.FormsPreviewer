using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;

namespace NotchyFormsPreviewer
{
    [System.ComponentModel.DesignTimeVisible(true)]
    public class NotchEffect : RoutingEffect
    {
        public NotchEffect() : base("NotchyFormsPreviewer.NotchEffect")
        {
            Debug.WriteLine("ContructingRoutingEffect");
        }
    }
}
