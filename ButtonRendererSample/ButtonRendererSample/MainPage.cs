using Xamarin.Forms;

namespace ButtonRendererSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new ShadowButton
            {
                Text = "Button",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}
