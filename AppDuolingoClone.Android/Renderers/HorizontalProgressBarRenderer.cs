using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using AppDuolingoClone.Controls;
using AppDuolingoClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HorizontalProgressBar), typeof(HorizontalProgressBarRenderer))]
namespace AppDuolingoClone.Droid.Renderers
{
    public class HorizontalProgressBarRenderer : ViewRenderer<HorizontalProgressBar, Android.Widget.ProgressBar>
    {
        private const int PROGRESS_MAX_VALUE = 100;

        public HorizontalProgressBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                var nativeControl = new Android.Widget.ProgressBar(
                    Context,
                    null,
                    Android.Resource.Attribute.ProgressBarStyleHorizontal
                );

                nativeControl.SetBackground(GetHorizontalTrack(Element.TrackColor.ToAndroid()));
                nativeControl.ProgressDrawable = GetHorizontalProgress(Element.ProgressColor.ToAndroid());
                nativeControl.Max = PROGRESS_MAX_VALUE;
                nativeControl.Progress = GetProgress(Element.Progress);

                SetNativeControl(nativeControl);
            }
        }

        private Drawable GetHorizontalTrack(Android.Graphics.Color color)
        {
            var drawable = Context.GetDrawable(Resource.Drawable.horizontal_track_bar) as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));
            return drawable;
        }

        private Drawable GetHorizontalProgress(Android.Graphics.Color color)
        {
            var scale = Context.GetDrawable(Resource.Drawable.horizontal_progress_bar) as ScaleDrawable;

            var drawable = scale.Drawable as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));

            return scale;
        }

        private int GetProgress(double progress)
        {
            return Convert.ToInt32(
                Math.Floor(progress * PROGRESS_MAX_VALUE)
            );
        }
    }
}
