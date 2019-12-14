using System;
using System.Collections.Generic;
using AppDuolingoClone.ContentViews;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuolingoClone.Views
{
    public partial class ProfileView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;
        private Lazy<ProfileAchievementsContentView> _sectionAchievements = new Lazy<ProfileAchievementsContentView>();
        private Lazy<ProfileFriendsContentView> _sectionFriends = new Lazy<ProfileFriendsContentView>();

        public ProfileView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var index = 0;
            foreach (var view in flexLayoutSection.Children)
            {
                if (view is Grid grid)
                {
                    if (index++ == 0)
                    {
                        GoToStateSelected(grid);
                        sectionAchievements.IsVisible = true;
                        sectionAchievements.Content = _sectionAchievements.Value;
                        continue;
                    }

                    GoToStateUnSelected(grid);
                }
            }
        }

        public string GetIcon()
        {
            return "tab_profile";
        }

        public string GetSelectedIcon()
        {
            return "tab_profile_selected";
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new ProfileTitleView();

            return _title;
        }

        private void OnTappedSection(object sender, EventArgs args)
        {
            if (sender is Grid grid)
            {
                GoToStateUnSelected(_lastSelected);
                GoToStateSelected(grid);

                if (grid.AutomationId == "gridAchievements")
                {
                    sectionFriends.IsVisible = false;
                    sectionAchievements.IsVisible = true;
                    sectionAchievements.Content = _sectionAchievements.Value;
                    return;
                }

                if (grid.AutomationId == "gridFriends")
                {
                    sectionAchievements.IsVisible = false;
                    sectionFriends.IsVisible = true;
                    sectionFriends.Content = _sectionFriends.Value;
                    return;
                }
            }
        }

        private Grid _lastSelected;

        private void GoToStateSelected(Grid grid)
        {
            _lastSelected = grid;

            if (grid.Children[0] is Label label &&
                grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "Selected");
                VisualStateManager.GoToState(boxView, "Selected");
            }
        }

        private void GoToStateUnSelected(Grid grid)
        {
            if (grid.Children[0] is Label label &&
                grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "UnSelected");
                VisualStateManager.GoToState(boxView, "UnSelected");
            }
        }
    }
}
