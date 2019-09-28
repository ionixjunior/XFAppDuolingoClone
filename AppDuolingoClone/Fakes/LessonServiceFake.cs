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
                            GetNewLesson("Introdução", "4")
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações", "4"),
                            GetNewLesson("Viagem", string.Empty)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bônus", string.Empty),
                            GetNewLesson("Bônus", string.Empty),
                            GetNewLesson("Bônus", string.Empty)
                        }
                    }
                };
            });
        }

        private Lesson GetNewLesson(string name, string level)
        {
            return new Lesson
            {
                Name = name,
                Level = level
            };
        }
    }
}
