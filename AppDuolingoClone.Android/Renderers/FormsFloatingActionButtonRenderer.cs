using System;
using Android.Content;
using Android.Content.Res;
using Android.Support.Design.Widget;
using AppDuolingoClone.Controls;
using AppDuolingoClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatingActionButtonRenderer))]
namespace AppDuolingoClone.Droid.Renderers
{
    public class FormsFloatingActionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        private FloatingActionButton _floatingActionButton;

        public FormsFloatingActionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _floatingActionButton = new FloatingActionButton(Context);
                _floatingActionButton.UseCompatPadding = true;
                ConfigureBackgroundColor();
                _floatingActionButton.Click += OnFabClick;

                SetNativeControl(_floatingActionButton);
            }
        }

        private void ConfigureBackgroundColor()
        {
            if (Element == null)
                return;

            var floatingActionButtonColor = Element.BackgroundColor.ToAndroid();
            _floatingActionButton.BackgroundTintList = ColorStateList.ValueOf(floatingActionButtonColor);
            Element.BackgroundColor = Color.Transparent;
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}
