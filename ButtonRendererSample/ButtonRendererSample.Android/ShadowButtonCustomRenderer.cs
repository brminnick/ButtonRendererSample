using System.ComponentModel;

using Android.Content;

using ButtonRendererSample;
using ButtonRendererSample.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShadowButton), typeof(ShadowButtonCustomRenderer))]
namespace ButtonRendererSample.Droid
{
    public class ShadowButtonCustomRenderer : ButtonRenderer
    {
        public ShadowButtonCustomRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Elevation = 20;
            }
        }
    }
}
