using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;
using Prism;

namespace AppDuolingoClone.ViewModels
{
    public class StoriesViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoriesService _storiesService;

        public ObservableCollection<StoriesGroup> Stories { get; private set; }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
            Stories = new ObservableCollection<StoriesGroup>();
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                var groups = await GetStories();

                if (Stories.Any())
                    Stories.Clear();

                foreach (var story in groups)
                    Stories.Add(story);
            }
        }

        private async Task<IList<StoriesGroup>> GetStories()
        {
            return await _storiesService.GetStories();
        }
    }
}
