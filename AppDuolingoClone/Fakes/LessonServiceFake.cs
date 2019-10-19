using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Enums;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        public async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroup>
                {
                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Introdução", "4", "lesson_egg", "#f19a37")


                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog", "#f19a37"),
                            GetNewLesson("Viagem", string.Empty, "lesson_airplane", "#c287f8")


                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Cafeteria", string.Empty, "lesson_hamburger", "#c287f8"),
                            GetNewLesson("Famílias", string.Empty, "lesson_baby", "#c287f8")

                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#ffffff"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#ffffff"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#ffffff")
                        }
                    }
                };
            });
        }

        private Lesson GetNewLesson(string name, string level, string icon, string color)
        {
            return new Lesson
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color
            };
        }
    }
}
