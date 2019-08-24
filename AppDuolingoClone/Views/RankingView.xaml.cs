using System;
using System.Collections.Generic;
using AppDuolingoClone.Interfaces;
using Xamarin.Forms;

namespace AppDuolingoClone.Views
{
    public partial class RankingView : ContentPage, ITabPageIcons
    {
        public RankingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_ranking";
        }

        public string GetSelectedIcon()
        {
            return "tab_ranking_selected";
        }
    }
}
