using Android.Widget;
using NotchyFormsPreviewer.Droid;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using static Android.Views.View;
using static NotchyFormsPreviewer.Device;

[assembly: ResolutionGroupName("NotchyFormsPreviewer")]
[assembly: ExportEffect(typeof(NotchEffect), "NotchEffect")]
namespace NotchyFormsPreviewer.Droid
{
    public class NotchEffect : PlatformEffect
    {
        public LinearLayout NotchLayout { get; private set; }
        public Device Device { get; private set; }
        public Android.Views.View.IOnLayoutChangeListener UpdateLayout { get; private set; }
        NotchyFormsPreviewer.NotchEffect NotchInfo;

        protected override void OnAttached()
        {
            NotchInfo = Element.Effects.FirstOrDefault(x => x is NotchyFormsPreviewer.NotchEffect) as NotchyFormsPreviewer.NotchEffect;

            if (Element == null)
            {
                NotchLayout = null;
            }
            else if (NotchLayout == null)
            {
                InitView();
            }
        }

        protected override void OnDetached()
        {
        }


        void InitView()
        {
            NotchLayout = new LinearLayout(Container.Context);
            NotchLayout.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.MatchParent, Android.Views.ViewGroup.LayoutParams.MatchParent);


            var button = new Android.Widget.Button(Container.Context);
            button.Text = "Notch";

            var page = Element as Page;

            if (NotchInfo.Model == PhoneModels.Custom)
            {
                Device = NotchInfo.CustomDevice;
            }
            else
            {
                Device = Devices[NotchInfo.Model];
            }


            var notch = new NotchView(Container.Context) { Device = Device };

            NotchLayout.AddView(notch);
            Container.AddView(NotchLayout);

            NotchLayout.Parent.BringChildToFront(NotchLayout);


            Container.LayoutChange += (sender, e) =>
            {
                if (NotchLayout != null)
                {
                    var msw = MeasureSpec.MakeMeasureSpec(e.Right, MeasureSpecMode.Exactly);
                    var msh = MeasureSpec.MakeMeasureSpec(e.Bottom, MeasureSpecMode.Exactly);

                    NotchLayout.Measure(msw, msh);
                    NotchLayout.Layout(0, 0, e.Right, e.Bottom);

                    NotchLayout.Parent.BringChildToFront(NotchLayout);

                }

            };
        }


    }
}
