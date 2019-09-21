using System;
using System.Collections.Generic;
using AppDuolingoClone.Enums;

namespace AppDuolingoClone.Models
{
    public class LessonGroup
    {
        public LessonGroupTypeEnum Type { get; set; }
        public IList<Lesson> Lessons { get; set; }

        public LessonGroup()
        {
            Lessons = new List<Lesson>();
        }
    }
}
