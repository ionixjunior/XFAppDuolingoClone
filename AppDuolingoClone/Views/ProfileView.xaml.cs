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
    }
}
