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
                            GetNewLesson("Introdução", "4", "lesson_egg")

						}
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog"),
                            GetNewLesson("Viagem", string.Empty, "lesson_airplane")

						}
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Cafeteria", string.Empty, "lesson_hamburger"),
                            GetNewLesson("Famílias", string.Empty, "lesson_baby")

                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus")
                        }
                    }
                };
            });
        }

        private Lesson GetNewLesson(string name, string level, string icon)
        {
            return new Lesson
            {
                Name = name,
                Level = level,
                Icon = icon
            };
        }
    }
}
