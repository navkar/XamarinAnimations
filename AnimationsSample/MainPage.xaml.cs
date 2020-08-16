using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimationsSample.Extensions;
using Xamarin.Forms;

namespace AnimationsSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, string.Empty);
        }

        async void Card3D_Clicked(System.Object sender, System.EventArgs e)
        {
            PreAnimation(Card3D);
            await Navigation.PushAsync(new Card3DPage());
        }

        async void Shake_Clicked(System.Object sender, System.EventArgs e)
        {
            PreAnimation(Shake);
            await Navigation.PushAsync(new ProfileShakePage());
        }

        async void Scale2X_Clicked(System.Object sender, System.EventArgs e)
        {
            PreAnimation(Scale2X);
            await Navigation.PushAsync(new ScaleTo2xPage());
        }

        async void Bounce_Clicked(System.Object sender, System.EventArgs e)
        {
            PreAnimation(Bounce);
            await Navigation.PushAsync(new MacIconBouncePage());
        }

        async void Gradient_Clicked(System.Object sender, System.EventArgs e)
        {
            PreAnimation(Gradient);
            await Navigation.PushAsync(new PancakeGradientShiftsPage());
        }

        async void PreAnimation(Button btn)
        {
            var actualColor = btn.BackgroundColor;
            await btn.ChangeBackgroundColorTo(Color.DarkViolet, 150, Easing.CubicOut);
            await btn.ChangeBackgroundColorTo(actualColor, 100, Easing.SinOut);
        }

    }
}
