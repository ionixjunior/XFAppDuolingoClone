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

            if (Control is null)
            {
                var nativeControl = new Android.Widget.ProgressBar(
                    Context,
                    null,
                    Android.Resource.Attribute.ProgressBarStyleHorizontal
                );

                nativeControl.SetBackground(Context.GetDrawable(Resource.Drawable.circular_track_bar));
                nativeControl.ProgressDrawable = Context.GetDrawable(Resource.Drawable.circular_progress_bar);
                nativeControl.Max = 100;
                nativeControl.Progress = 20;

                SetNativeControl(nativeControl);
            }
        }
    }
}
