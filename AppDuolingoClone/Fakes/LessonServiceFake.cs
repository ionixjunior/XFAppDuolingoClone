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
                            GetNewLesson("Introdução")
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações"),
                            GetNewLesson("Viagem")
                        }
                    }
                };
            });
        }

        private Lesson GetNewLesson(string name)
        {
            return new Lesson
            {
                Name = name
            };
        }
    }
}
