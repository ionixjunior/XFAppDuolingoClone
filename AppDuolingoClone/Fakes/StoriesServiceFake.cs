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
                            GetNewStories("Bom dia!", "stories_coffe"),
                            GetNewStories("Um encontro", "stories_candle"),
                            GetNewStories("Uma coisa", "stories_bread"),
                            GetNewStories("Surpresa", "stories_gift")
                        }
                    )
                };
            });
        }

        private Stories GetNewStories(string name, string image)
        {
            return new Stories
            {
                Name = name,
                Image = image
            };
        }
    }
}
