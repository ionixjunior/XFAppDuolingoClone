using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Fakes
{
    public class StoriesServiceFake : IStoriesService
    {
        public async Task<IList<StoriesGroup>> GetStories()
        {
            return await Task.Run(() =>
            {
                return new List<StoriesGroup>
                {
                    new StoriesGroup(
                        "Série 1",
                        new List<Stories>()
                        {
                            GetNewStories("Bom dia!", "stories_coffe", "#f5b43f"),
                            GetNewStories("Um encontro", "stories_candle", "#503322"),
                            GetNewStories("Uma coisa", "stories_bread", "#68ad33"),
                            GetNewStories("Surpresa", "stories_gift", "#de90d0")
                        }
                    )
                };
            });
        }

        private Stories GetNewStories(string name, string image, string shadowBottomColor)
        {
            return new Stories
            {
                Name = name,
                Image = image,
                ShadowBottomColor = shadowBottomColor
            };
        }
    }
}
