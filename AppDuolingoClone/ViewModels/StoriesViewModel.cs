using System;
using AppDuolingoClone.Interfaces;

namespace AppDuolingoClone.ViewModels
{
    public class StoriesViewModel : ViewModelBase
    {
        private readonly IStoriesService _storiesService;

        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
        }
    }
}
