using System;
using Android.Content;
using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using AppDuolingoClone.Droid.Renderers;
using AppDuolingoClone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace AppDuolingoClone.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        private TabbedPage _formsTabs;
        private BottomNavigationView _bottomNavigationView;

        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formsTabs = Element;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;

                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.SetMinimumHeight(300);
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = 150;
                _bottomNavigationView.SetShiftMode(false, false);
                _bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;

                UpdateAllTabs();
            }

            if (e.OldElement != null)
            {
                _formsTabs.CurrentPageChanged -= OnCurrentPageChanged;
            }
        }

        private void UpdateAllTabs()
        {
            for (var index = 0; index < _formsTabs.Children.Count; index++)
            {
                var androidTab = _bottomNavigationView.Menu.GetItem(index);

                if (_formsTabs.Children[index] is LessonsView)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_lessons_selected);
                        continue;
                    }

                    androidTab.SetIcon(Resource.Drawable.tab_lessons);
                    continue;
                }

                if (_formsTabs.Children[index] is ProfileView)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_profile_selected);
                        continue;
                    }

                    androidTab.SetIcon(Resource.Drawable.tab_profile);
                    continue;
                }

                if (_formsTabs.Children[index] is RankingView)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_ranking_selected);
                        continue;
                    }

                    androidTab.SetIcon(Resource.Drawable.tab_ranking);
                    continue;
                }

                if (_formsTabs.Children[index] is StoreView)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_store_selected);
                        continue;
                    }

                    androidTab.SetIcon(Resource.Drawable.tab_store);
                    continue;
                }
            }
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            UpdateAllTabs();
        }
    }
}
