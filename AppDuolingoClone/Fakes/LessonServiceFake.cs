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
        private string _colorLevel5 = "#f7c745";
        private string _colorLevel4 = "#f19a37";
        private string _colorLevel3 = "#ec5954";
        private string _colorLevel2 = "#8bc63b";
        private string _colorLevel1 = "#4faef0";
        private string _colorLevel0 = "#c287f8";
        private string _colorBonus = "#ffffff";

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
                            GetNewLesson("Introdução", "5", "lesson_egg", _colorLevel5)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog", _colorLevel4),
                            GetNewLesson("Viagem", "3", "lesson_airplane", _colorLevel3)


                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Cafeteria", "2", "lesson_hamburger", _colorLevel2),
                            GetNewLesson("Famílias", "1", "lesson_baby", _colorLevel1)

                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus)
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
