using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class HeartBeat : ContentPage
    {
        public HeartBeat()
        {
            InitializeComponent();
        }

        async void StartAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            await Task.WhenAll<bool>
            (
                heart.ScaleTo(2, 1000),
                heart.FadeTo(0, 1000, Easing.SinInOut)
            );

            await Task.WhenAny<bool>
            (
                heart.ScaleTo(1, 0),
                heart.FadeTo(1, 0)
            );
        }
    }
}
