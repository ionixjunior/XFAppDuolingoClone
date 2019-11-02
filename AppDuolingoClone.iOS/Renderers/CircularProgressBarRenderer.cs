using System;
using AppDuolingoClone.Controls;
using AppDuolingoClone.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace AppDuolingoClone.iOS.Renderers
{
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);
        }
    }
}
