using ButtonRendererSample;
using ButtonRendererSample.iOS;

using CoreGraphics;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShadowButton), typeof(ShadowButtonCustomRenderer))]
namespace ButtonRendererSample.iOS
{
    public class ShadowButtonCustomRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.ShadowColor = UIColor.Black.CGColor;
                Control.Layer.ShadowOpacity = 0.8f;
                Control.Layer.ShadowRadius = 12;
                Control.Layer.ShadowOffset = new CGSize(10, 10);
            }
        }
    }
}
