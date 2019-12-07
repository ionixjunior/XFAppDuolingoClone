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
                        98.75,
                        "79/80"
                    ),
                    GetAchievement(
                        "profile_achievements_02",
                        "NÍVEL 8",
                        "Intelectual",
                        "Aprenda 1.000 novas palavras em um curso",
                        86.3,
                        "863/1K"
                    ),
                    GetAchievement(
                        "profile_achievements_03",
                        "NÍVEL 5",
                        "Na Mosca",
                        "Complete 100 lições sem errar nada",
                        81,
                        "81/100"
                    ),
                    GetAchievement(
                        "profile_achievements_04",
                        "NÍVEL 7",
                        "Sabe-tudo",
                        "Ganhe 7500 XP",
                        72,
                        "5,4K/7,5K"
                    ),
                    GetAchievement(
                        "profile_achievements_05",
                        "NÍVEL 3",
                        "Fogueira",
                        "Alcance uma ofensiva de 14 dias",
                        50,
                        "7/14"
                    ),
                    GetAchievement(
                        "profile_achievements_06",
                        "NÍVEL 1",
                        "Estrategista",
                        "Você leu uma dica",
                        100,
                        string.Empty
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
            string status)
        {
            return new Achievement
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status
            };
        }
    }
}
