using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppDuolingoClone.ContentViews
{
    public partial class ProfileAchievementsContentView : ContentView
    {
        public ProfileAchievementsContentView()
        {
            InitializeComponent();
        }

        void OnAchievementSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView lv) lv.SelectedItem = null;
        }
    }
}
