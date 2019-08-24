using System;
using System.Collections.Generic;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Views.TitleViews;
using Xamarin.Forms;

namespace AppDuolingoClone.Views
{
    public partial class LessonsView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private View _title;

        public LessonsView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_lessons";
        }

        public string GetSelectedIcon()
        {
            return "tab_lessons_selected";
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new LessonsTitleView();

            return _title;
        }
    }
}
