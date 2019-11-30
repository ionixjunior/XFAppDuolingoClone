using System;
using System.Collections.Generic;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuolingoClone.Views
{
    public partial class ProfileView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;

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
                    System.Diagnostics.Debug.WriteLine("aba conquistas");
                    return;
                }

                if (grid.AutomationId == "gridFriends")
                {
                    System.Diagnostics.Debug.WriteLine("aba amigos");
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
