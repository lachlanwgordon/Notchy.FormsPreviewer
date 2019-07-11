using System;
using System.Diagnostics;
using System.ComponentModel;
using Xamarin.Forms;
using static NotchyFormsPreviewer.Device;

namespace NotchyFormsPreviewer
{
    [DesignTimeVisible(true)]
    public class NotchEffect : RoutingEffect
    {
        public NotchEffect() : base("NotchyFormsPreviewer.NotchEffect")
        {
            Debug.WriteLine("ContructingRoutingEffect");
        }
        
        public PhoneModels Model { get; set; }
        public Device CustomDevice { get; set; } = new Device();
    }
}
