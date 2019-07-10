using NotchyFormsPreviewer.Android;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.WriteLine("android Attached");

            if (Element != null)
            {
                var view = Element as VisualElement;
                if(view != null)
                {
                    (Element as VisualElement).BackgroundColor = Color.Blue;
                }

            }

        }

        protected override void OnDetached()
        {
        }
    }
}
