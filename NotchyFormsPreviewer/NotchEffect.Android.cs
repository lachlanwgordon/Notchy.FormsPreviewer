using NotchyFormsPreviewer.Android;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("NotchyFormsPreviewer")]
[assembly: ExportEffect(typeof(NotchEffect), "NotchEffect")]
namespace NotchyFormsPreviewer.Android
{
    public class NotchEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            (Element as Page).BackgroundColor = Color.Blue;
        }

        protected override void OnDetached()
        {
        }
    }
}
