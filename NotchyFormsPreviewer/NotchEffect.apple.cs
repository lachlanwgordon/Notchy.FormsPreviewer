using NotchyFormsPreviewer.iOS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("NotchyFormsPreviewer")]
[assembly: ExportEffect(typeof(NotchEffect), "NotchEffect")]
namespace NotchyFormsPreviewer.iOS                  
{
    [System.ComponentModel.DesignTimeVisible(true)]
    public class NotchEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Debug.WriteLine("ios Attached");
            (Element as Xamarin.Forms.VisualElement).BackgroundColor = Color.Blue;
        }

        protected override void OnDetached()
        {
        }
    }
}
