using System;
using Android.Content;
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
        public FormsFloatingActionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var fab = new FloatingActionButton(Context);
                fab.UseCompatPadding = true;
                fab.Click += OnFabClick;

                SetNativeControl(fab);
            }
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}
