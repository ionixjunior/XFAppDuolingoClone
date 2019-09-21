using System;
using AppDuolingoClone.ContentViews;
using AppDuolingoClone.Enums;
using AppDuolingoClone.Models;
using Xamarin.Forms;

namespace AppDuolingoClone.Templates
{
    public class LessonGroupDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Single { get; private set; }
        public DataTemplate Multi { get; private set; }
        public DataTemplate Bonus { get; private set; }

        public LessonGroupDataTemplateSelector()
        {
            Single = new DataTemplate(typeof(LessonGroupSingleContentView));
            Multi = new DataTemplate(typeof(LessonGroupMultiContentView));
            Bonus = new DataTemplate(typeof(LessonGroupBonusContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is LessonGroup group)
            {
                if (group.Type == LessonGroupTypeEnum.Multi)
                    return Multi;

                if (group.Type == LessonGroupTypeEnum.Bonus)
                    return Bonus;
            }

            return Single;
        }
    }
}
