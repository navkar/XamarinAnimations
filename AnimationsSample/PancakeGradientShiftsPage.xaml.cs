using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsSample
{
    public partial class PancakeGradientShiftsPage : ContentPage
    {
        private bool _isAnimating;

        public PancakeGradientShiftsPage()
        {
            InitializeComponent();
        }

        async void StartStopAnimation_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!_isAnimating)
            {
                _isAnimating = true;
                status.Text = "RUNNING";

                for (int i = 0; i < 4; i++)
                {
                    await pancake.ColorTo(pancake.BackgroundGradientStartColor, pancake.BackgroundGradientEndColor, c => pancake.BackgroundGradientEndColor = c, 2000, Easing.Linear);
                    await pancake.ColorTo(pancake.BackgroundGradientEndColor, pancake.BackgroundGradientStartColor, c => pancake.BackgroundGradientStartColor = c, 2000, Easing.Linear);
                }

                status.Text = "DONE";
                _isAnimating = false;
            }
            else
            {
                _isAnimating = false;
                status.Text = string.Empty;
                ViewExtensions.CancelAnimations(pancake);
            }
        }
    }
}
