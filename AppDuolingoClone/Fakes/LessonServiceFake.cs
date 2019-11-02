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
                            GetNewLesson("Introdução", "5", "lesson_egg", _colorLevel5, 1.0)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog", _colorLevel4, 0.8),
                            GetNewLesson("Viagem", "3", "lesson_airplane", _colorLevel3, 0.0)


                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Cafeteria", "2", "lesson_hamburger", _colorLevel2, 0.7),
                            GetNewLesson("Famílias", "1", "lesson_baby", _colorLevel1, 0.1)

                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Loja", string.Empty, "lesson_sock", _colorLevel0, 0.0),
                            GetNewLesson("Estudos", "1", "lesson_pencil", _colorLevel1, 0.3),
                            GetNewLesson("Ocupações", "2", "lesson_hat", _colorLevel2, 0.4)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Encontros", "1", "lesson_bag", _colorLevel1, 0.9)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson(string.Empty, "1", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    }, 

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson("Rotinas", "1", "lesson_bike", _colorLevel1, 0.6),
                            GetNewLesson("Emoções", string.Empty, "lesson_heart", _colorLevel0, 0.5)
                        }
                    },

                    new LessonGroup
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<Lesson>
                        {
                            GetNewLesson(string.Empty, "2", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    },
                };
            });
        }

        private Lesson GetNewLesson(string name, string level, string icon, string color, double progress)
        {
            return new Lesson
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color,
                Progress = progress
            };
        }
    }
}
