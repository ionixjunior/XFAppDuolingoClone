using System;
using Android.Content;
using AppDuolingoClone.Controls;
using AppDuolingoClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace AppDuolingoClone.Droid.Renderers
{
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, Android.Widget.ProgressBar>
    {
        public CircularProgressBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);
        }
    }
}
