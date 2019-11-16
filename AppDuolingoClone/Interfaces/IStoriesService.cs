using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Interfaces
{
    public interface IStoriesService
    {
        Task<IList<StoriesGroup>> GetStories();
    }
}
