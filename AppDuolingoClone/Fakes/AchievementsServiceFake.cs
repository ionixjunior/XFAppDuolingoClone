using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Fakes
{
    public class AchievementsServiceFake : IAchievementsService
    {
        public async Task<IList<Achievement>> GetAchievementsAsync()
        {
            return await Task.Run(() =>
            {
                return new List<Achievement>
                {
                    GetAchievement(
                        "profile_achievements_01",
                        "NÍVEL 9",
                        "Majestade",
                        "Ganhe 80 coroas",
                        0.9875,
                        "79/80",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_02",
                        "NÍVEL 8",
                        "Intelectual",
                        "Aprenda 1.000 novas palavras em um curso",
                        0.863,
                        "863/1K",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_03",
                        "NÍVEL 5",
                        "Na Mosca",
                        "Complete 100 lições sem errar nada",
                        0.81,
                        "81/100",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_04",
                        "NÍVEL 7",
                        "Sabe-tudo",
                        "Ganhe 7500 XP",
                        0.72,
                        "5,4K/7,5K",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_05",
                        "NÍVEL 3",
                        "Fogueira",
                        "Alcance uma ofensiva de 14 dias",
                        0.5,
                        "7/14",
                        true
                    ),
                    GetAchievement(
                        "profile_achievements_06",
                        "NÍVEL 1",
                        "Estrategista",
                        "Você leu uma dica",
                        1,
                        string.Empty,
                        false
                    )
                };
            });
        }

        private Achievement GetAchievement(
            string icon,
            string level,
            string name,
            string description,
            double progress,
            string status,
            bool isActive)
        {
            return new Achievement
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status,
                IsActive = isActive
            };
        }
    }
}
