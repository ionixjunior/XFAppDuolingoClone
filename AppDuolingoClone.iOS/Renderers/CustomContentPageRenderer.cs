using System;
using AppDuolingoClone.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CustomContentPageRenderer))]
namespace AppDuolingoClone.iOS.Renderers
{
    public class CustomContentPageRenderer : PageRenderer
    {
        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}
