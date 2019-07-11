using NotchyFormsPreviewer.iOS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using static NotchyFormsPreviewer.Device;

[assembly: ResolutionGroupName("NotchyFormsPreviewer")]
[assembly: ExportEffect(typeof(NotchEffect), "NotchEffect")]
namespace NotchyFormsPreviewer.iOS                  
{
    [System.ComponentModel.DesignTimeVisible(true)]
    public class NotchEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var notchInfo = Element.Effects.FirstOrDefault(x => x is NotchyFormsPreviewer.NotchEffect) as NotchyFormsPreviewer.NotchEffect;
            if (notchInfo != null)
            {
                Device device;
                if (notchInfo.Model == PhoneModels.Custom)
                {
                    device = notchInfo.CustomDevice;
                }
                else
                {
                    device = Devices[notchInfo.Model];
                }

                NotchView notch;
                if (DesignMode.IsDesignModeEnabled)
                {
                    notch = new NotchView(new System.Drawing.RectangleF(0, 0, (float)device.ScreenWidth, (float)device.ScreenHeight), device);//Previewer always reports size of an iphone 5
                }
                else
                {
                    notch = new NotchView(new System.Drawing.RectangleF(0, 0, (float)Container.Bounds.Width, (float)Container.Bounds.Height), device);
                }

                notch.Bounds = notch.Frame;

                Container.Add(notch);
            }

        }

        protected override void OnDetached()
        {
        }
    }
}
