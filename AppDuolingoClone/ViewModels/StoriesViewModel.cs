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

        public ObservableCollection<Stories> Stories { get; private set; }

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
            Stories = new ObservableCollection<Stories>();
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                var stories = await GetStories();

                if (Stories.Any())
                    Stories.Clear();

                foreach (var story in stories)
                    Stories.Add(story);
            }
        }

        private async Task<IList<Stories>> GetStories()
        {
            return await _storiesService.GetStories();
        }
    }
}
